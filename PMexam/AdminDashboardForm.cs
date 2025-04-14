using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMexam
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
            dgvStatements.Columns.Add("Id", "Id");
            dgvStatements.Columns["Id"].Visible = false;
            dgvStatements.Columns.Add("FullName", "ФИО");
            dgvStatements.Columns.Add("Email", "Email");
            dgvStatements.Columns.Add("Phone", "Телефон");
            dgvStatements.Columns.Add("application_status", "Статус");
            dgvStatements.Columns.Add("education_level", "Уровень образования");
            dgvStatements.Columns.Add("SubmissionDate", "Дата подачи");
            LoadApplications();
        }

        private void LoadApplications(DateTime? filterDate = null)
        {
            using (var conn = Database.GetConnection())
            {
                var query = "SELECT id, full_name, email, phone, application_status, education_level, submission_date FROM applicants";

                if (filterDate.HasValue)
                {
                    query += " WHERE submission_date::date = @filterDate";
                }

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    if (filterDate.HasValue)
                    {
                        cmd.Parameters.AddWithValue("filterDate", filterDate.Value.Date); // обрезаем время
                    }

                    using (var reader = cmd.ExecuteReader())
                    {
                        dgvStatements.Rows.Clear();
                        while (reader.Read())
                        {
                            dgvStatements.Rows.Add(
                                reader["id"],
                                reader["full_name"].ToString(),
                                reader["email"].ToString(),
                                reader["phone"].ToString(),
                                reader["application_status"].ToString(),
                                reader["education_level"].ToString(),
                                Convert.ToDateTime(reader["submission_date"]).ToString("dd.MM.yyyy")
                            );
                        }
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadApplications();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadApplications(dtpPicker.Value);
        }

        private void dgvStatements_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int applicantId = Convert.ToInt32(dgvStatements.Rows[e.RowIndex].Cells["Id"].Value);
                var reviewForm = new ApplicationReviewForm(applicantId);
                reviewForm.ShowDialog();

                LoadApplications();
            }
        }
    }
}
