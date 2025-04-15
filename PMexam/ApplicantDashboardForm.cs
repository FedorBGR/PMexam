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
    public partial class ApplicantDashboardForm : Form
    {
        private int _userId;
        public ApplicantDashboardForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
            LoadApplicantInfo();
        }

        private void LoadApplicantInfo()
        {
            using (var conn = Database.GetConnection())
            {
                var cmd = new NpgsqlCommand("SELECT * FROM applicants WHERE user_id = @uid", conn);
                cmd.Parameters.AddWithValue("uid", _userId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lblEmail.Text = reader["email"].ToString();
                        lblFullName.Text = reader["full_name"].ToString();
                        lblStatus.Text = reader["application_status"].ToString();

                        string comment = reader["comment"]?.ToString();

                        if (lblStatus.Text == "В ДОРАБОТКУ" && !string.IsNullOrWhiteSpace(comment))
                        {
                            lblComment.Text = "Комментарий: " + comment;
                            lblComment.Visible = true;
                        }
                        else
                        {
                            lblComment.Text = "";
                            lblComment.Visible = false;
                        }

                        string[] directions = (string[])reader["directions"];
                        lbDirections.Items.Clear();
                        lbDirections.Items.AddRange(directions);
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadApplicantInfo();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string fullName = lblFullName.Text;
            string[] directions = lbDirections.Items.Cast<string>().ToArray();
            string directionsText = string.Join(Environment.NewLine, directions);
            string today = DateTime.Now.ToString("dd.MM.yyyy");

            string content = $"\n\nЯ, {fullName}, подал документы в ВУЗ\nНа направления подготовки:\n{directionsText}\n\n{today}";

            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "PDF файлы (*.pdf)|*.pdf",
                FileName = "Заявление.pdf"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveDialog.FileName;

                var doc = new PdfSharp.Pdf.PdfDocument();
                var page = doc.AddPage();
                var gfx = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
                var font = new PdfSharp.Drawing.XFont("Arial", 14);


                var titleFont = new PdfSharp.Drawing.XFont("Arial", 18);
                gfx.DrawString("ЗАЯВЛЕНИЕ", titleFont, PdfSharp.Drawing.XBrushes.Black,
                    new PdfSharp.Drawing.XRect(0, 40, page.Width, 30), PdfSharp.Drawing.XStringFormats.TopCenter);

                var tf = new PdfSharp.Drawing.Layout.XTextFormatter(gfx);
                var rect = new PdfSharp.Drawing.XRect(40, 40, page.Width - 80, page.Height - 80);
                tf.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
                tf.DrawString(content, font, PdfSharp.Drawing.XBrushes.Black, rect, PdfSharp.Drawing.XStringFormats.TopLeft);

                doc.Save(path);
                MessageBox.Show("PDF-документ сохранён.", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = path,
                    UseShellExecute = true
                });
            }
        }
    }
}
