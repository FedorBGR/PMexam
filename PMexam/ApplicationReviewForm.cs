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
    public partial class ApplicationReviewForm : Form
    {
        private int applicantId;

        public ApplicationReviewForm(int applicantId)
        {
            InitializeComponent();
            this.applicantId = applicantId;
            LoadApplicantData();
            LoadWorkers();
            LoadDirections();
        }

        private void LoadApplicantData()
        {
            using (var conn = Database.GetConnection())
            {
                var cmd = new NpgsqlCommand(@"
                    SELECT full_name, email, phone, passport, snils, parent_name,
                           graduated_from, education_level, average_score,
                           application_status, comment, executor_id
                    FROM applicants
                    WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("id", applicantId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lblFullName.Text = reader["full_name"].ToString();
                        lblEmail.Text = reader["email"].ToString();
                        lblPhone.Text = reader["phone"].ToString();
                        lblPassport.Text = reader["passport"].ToString();
                        lblSnils.Text = reader["snils"].ToString();
                        lblParentName.Text = reader["parent_name"].ToString();
                        lblGraduatedFrom.Text = reader["graduated_from"].ToString();
                        lblEducation_level.Text = reader["education_level"].ToString();
                        cbStatus.SelectedItem = reader["application_status"].ToString();
                        txtComment.Text = reader["comment"].ToString();

                        int executorId = reader["executor_id"] != DBNull.Value ? (int?)reader["executor_id"] ?? 0 : 0;
                        if (executorId > 0)
                        {
                            cbExecutor.SelectedValue = executorId;
                        }

                        string educationLevel = reader["education_level"].ToString();

                        if (educationLevel == "Бакалавриат" || educationLevel == "Специалитет")
                        {
                            label10.Visible = lblAverage_score.Visible = false;
                            lblEGEsubject1.Visible = lblEGEscore1.Visible = true;
                            lblEGEsubject2.Visible = lblEGEscore2.Visible = true;
                            lblEGEsubject3.Visible = lblEGEscore3.Visible = true;
                            LoadEGEScores();
                        }
                        else if (educationLevel == "СПО" || educationLevel == "Магистратура")
                        {
                            lblEGEsubject1.Visible = lblEGEscore1.Visible = false;
                            lblEGEsubject2.Visible = lblEGEscore2.Visible = false;
                            lblEGEsubject3.Visible = lblEGEscore3.Visible = false;
                            label10.Visible = lblAverage_score.Visible = true;
                            lblAverage_score.Text = reader["average_score"].ToString();
                        }
                    }
                }
            }

            using (var conn2 = Database.GetConnection())
            {
                var dirCmd = new NpgsqlCommand(@"
                    SELECT unnest(directions) AS direction_name
                    FROM applicants
                    WHERE id = @id", conn2);
                dirCmd.Parameters.AddWithValue("id", applicantId);

                using (var dirReader = dirCmd.ExecuteReader())
                {
                    lbDirections.Items.Clear();
                    while (dirReader.Read())
                    {
                        lbDirections.Items.Add(dirReader["direction_name"].ToString());
                    }
                }
            }
        }

        private void LoadWorkers()
        {
            List<KeyValuePair<int, string>> workers = new List<KeyValuePair<int, string>>();

            using (var conn = Database.GetConnection())
            {
                var cmd = new NpgsqlCommand("SELECT id, login FROM users WHERE role = 'Работник'", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        workers.Add(new KeyValuePair<int, string>((int)reader["id"], reader["login"].ToString()));
                    }
                }
            }

            cbExecutor.DataSource = workers;
            cbExecutor.DisplayMember = "Value";
            cbExecutor.ValueMember = "Key";
        }

        private void LoadDirections()
        {
            using (var conn = Database.GetConnection())
            {
                var dirCmd = new NpgsqlCommand(@"
                    SELECT unnest(directions) AS direction_name
                    FROM applicants
                    WHERE id = @id", conn);
                dirCmd.Parameters.AddWithValue("id", applicantId);

                using (var dirReader = dirCmd.ExecuteReader())
                {
                    lbDirections.Items.Clear();
                    while (dirReader.Read())
                    {
                        lbDirections.Items.Add(dirReader["direction_name"].ToString());
                    }
                }
            }
        }

        private void LoadEGEScores()
        {
            using (var conn3 = Database.GetConnection())
            {
                var egeCmd = new NpgsqlCommand(@"
                    SELECT unnest(ege_subjects) AS subject, unnest(ege_scores) AS score
                    FROM applicants
                    WHERE id = @id", conn3);
                egeCmd.Parameters.AddWithValue("id", applicantId);

                using (var egeReader = egeCmd.ExecuteReader())
                {
                    int count = 0;
                    while (egeReader.Read() && count < 3)
                    {
                        switch (count)
                        {
                            case 0:
                                lblEGEsubject1.Text = egeReader["subject"].ToString();
                                lblEGEscore1.Text = egeReader["score"].ToString();
                                break;
                            case 1:
                                lblEGEsubject2.Text = egeReader["subject"].ToString();
                                lblEGEscore2.Text = egeReader["score"].ToString();
                                break;
                            case 2:
                                lblEGEsubject3.Text = egeReader["subject"].ToString();
                                lblEGEscore3.Text = egeReader["score"].ToString();
                                break;
                        }
                        count++;
                    }
                }
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string selectedStatus = cbStatus.SelectedItem.ToString();
            string comment = txtComment.Text;
            int selectedExecutorId = (int)cbExecutor.SelectedValue;

            using (var conn = Database.GetConnection())
            {
                var updateCmd = new NpgsqlCommand(@"
                    UPDATE applicants
                    SET application_status = @status, comment = @comment, executor_id = @executor_id
                    WHERE id = @id", conn);
                updateCmd.Parameters.AddWithValue("status", selectedStatus);
                updateCmd.Parameters.AddWithValue("comment", comment);
                updateCmd.Parameters.AddWithValue("executor_id", selectedExecutorId);
                updateCmd.Parameters.AddWithValue("id", applicantId);

                updateCmd.ExecuteNonQuery();
            }

            MessageBox.Show("Статус и исполнитель обновлены успешно!");
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.SelectedItem != null && cbStatus.SelectedItem.ToString() == "В ДОРАБОТКУ")
            {
                txtComment.Visible = true;
                lblcom.Visible = true;
            }
            else
            {
                txtComment.Visible = false;
                lblcom.Visible = false;
            }
        }
    }
}
