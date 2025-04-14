using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace PMexam
{
    public partial class RegisterForm : Form
    {
        private Dictionary<string, int> educationLevelsDict = new Dictionary<string, int>();
        private ComboBox[] egeBoxes;
        private NumericUpDown[] scoreBoxes;
        private string[] allEgeSubjects;
        private List<string> uploadedPdfPaths = new List<string>();
        public RegisterForm()
        {
            InitializeComponent();
            allEgeSubjects = cboEGE1.Items.Cast<string>().ToArray();
            egeBoxes = new ComboBox[] { cboEGE1, cboEGE2, cboEGE3 };
            scoreBoxes = new NumericUpDown[] { numScoreEGE1, numScoreEGE2, numScoreEGE3 };
            panelEGE.Visible = false;
            numAvgScore.Visible = false;
            lblAvgScore.Visible = false;
            lblEGE.Visible = false;
            foreach (var box in egeBoxes)
            {
                box.SelectedIndexChanged += EgeSubjectChanged;
            }

            LoadEducationLevels();

        }

        private void LoadEducationLevels()
        {
            cboEducationLevel.Items.Clear();
            educationLevelsDict.Clear();

            using (var conn = Database.GetConnection())
            {
                using (var cmd = new NpgsqlCommand("SELECT id, level_name FROM education_levels ORDER BY level_name", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        educationLevelsDict[name] = id;
                        cboEducationLevel.Items.Add(name);
                    }
                }
            }
        }

        private void cboEducationLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cboEducationLevel.SelectedItem.ToString();

            panelEGE.Visible = (selected == "Бакалавриат" || selected == "Специалитет");
            numAvgScore.Visible = (selected == "СПО" || selected == "Магистратура");
            lblAvgScore.Visible = (selected == "СПО" || selected == "Магистратура");
            lblEGE.Visible = (selected == "Бакалавриат" || selected == "Специалитет");

            if (selected == "СПО")
                numAvgScore.Maximum = 5;
            else if (selected == "Магистратура")
                numAvgScore.Maximum = 100;

            LoadDirectionsForLevel(selected);
        }

        private void LoadDirectionsForLevel(string level)
        {
            clbDirections.Items.Clear();

            if (!educationLevelsDict.TryGetValue(level, out int levelId))
                return;

            using (var conn = Database.GetConnection())
            {
                using (var cmd = new NpgsqlCommand("SELECT direction_name FROM directions WHERE level_id = @level_id ORDER BY direction_name", conn))
                {
                    cmd.Parameters.AddWithValue("level_id", levelId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clbDirections.Items.Add(reader.GetString(0));
                        }
                    }
                }
            }
        }

        private void lblEGE_Click(object sender, EventArgs e)
        {

        }

        private bool ValidateInputFields()
        {
            // Проверка ФИО абитуриента
            if (!Regex.IsMatch(txtFullName.Text.Trim(), @"^[А-Яа-яЁё\s\-]+$"))
            {
                MessageBox.Show("Поле 'Полное имя' должно содержать только буквы, пробелы и дефисы.", "Поле пустое или заполнено неверно", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFullName.BackColor = Color.MistyRose;
                return false;
            }

            // Проверка ФИО родителя
            if (!Regex.IsMatch(txtParentName.Text.Trim(), @"^[А-Яа-яЁё\s\-]+$"))
            {
                MessageBox.Show("Поле 'ФИО родителя' должно содержать только буквы, пробелы и дефисы.", "Поле пустое или заполнено неверно", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtParentName.BackColor = Color.MistyRose;
                return false;
            }

            // Проверка email
            if (!Regex.IsMatch(txtEmail.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Введите корректный адрес электронной почты.", "Поле пустое или заполнено неверно", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.BackColor = Color.MistyRose;
                return false;
            }

            if (clbDirections.CheckedItems.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы одно направление подготовки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string educationLevel = cboEducationLevel.SelectedItem?.ToString();

            if (educationLevel == "СПО" || educationLevel == "Магистратура")
            {
                if (numAvgScore.Value == 0)
                {
                    MessageBox.Show("Укажите средний балл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (educationLevel == "СПО" && numAvgScore.Value > 5)
                {
                    MessageBox.Show("Средний балл аттестата не может быть больше 5.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (educationLevel == "Магистратура" && numAvgScore.Value > 100)
                {
                    MessageBox.Show("Средний балл диплома не может быть больше 100.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else // Бакалавриат и Специалитет
            {
                ComboBox[] egeBoxes = { cboEGE1, cboEGE2, cboEGE3 };
                NumericUpDown[] scoreBoxes = { numScoreEGE1, numScoreEGE2, numScoreEGE3 };

                for (int i = 0; i < 3; i++)
                {
                    if (egeBoxes[i].SelectedItem == null || scoreBoxes[i].Value == 0)
                    {
                        MessageBox.Show("Укажите все предметы ЕГЭ и соответствующие баллы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    if (scoreBoxes[i].Value > 100)
                    {
                        MessageBox.Show("Баллы ЕГЭ не могут быть больше 100.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            if (uploadedPdfPaths.Count == 0)
            {
                MessageBox.Show("Загрузите хотя бы один документ об образовании (PDF).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }

        private void EgeSubjectChanged(object sender, EventArgs e)
        {
            var selected = egeBoxes
                .Select(cb => cb.SelectedItem?.ToString())
                .Where(s => !string.IsNullOrEmpty(s))
                .ToList();

            foreach (var box in egeBoxes)
                box.SelectedIndexChanged -= EgeSubjectChanged;

            foreach (var box in egeBoxes)
            {
                var current = box.SelectedItem?.ToString();

                box.Items.Clear();
                box.Items.AddRange(allEgeSubjects
                    .Where(subj => !selected.Contains(subj) || subj == current)
                    .ToArray());

                if (!string.IsNullOrEmpty(current) && box.Items.Contains(current))
                    box.SelectedItem = current;
                else
                    box.SelectedItem = null;
            }

            foreach (var box in egeBoxes)
                box.SelectedIndexChanged += EgeSubjectChanged;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            txtFullName.BackColor = Color.White;
            txtParentName.BackColor = Color.White;
            txtEmail.BackColor = Color.White;

            if (!ValidateInputFields())
                return;

            string fullName = txtFullName.Text.Trim();
            string passport = txtPassport.Text.Trim();
            string snils = txtSnils.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string parentName = txtParentName.Text.Trim();
            string graduatedFrom = txtGraduatedFrom.Text.Trim();
            string educationLevel = cboEducationLevel.SelectedItem?.ToString();

            if (!decimal.TryParse(numAvgScore.Text.Trim(), out decimal averageScore))
            {
                MessageBox.Show("Введите корректный средний балл.");
                return;
            }

            var directions = clbDirections.CheckedItems.Cast<string>().ToList();
            var egeSubjects = new List<string>();
            var egeScores = new List<int>();

            foreach (var box in egeBoxes)
            {
                if (box.SelectedItem != null)
                    egeSubjects.Add(box.SelectedItem.ToString());
            }

            foreach (var scoreBox in scoreBoxes) // предполагается, что есть список TextBox'ов по баллам
            {
                if (int.TryParse(scoreBox.Text.Trim(), out int score))
                    egeScores.Add(score);
                else
                    egeScores.Add(0); // или покажи ошибку, если обязательно
            }

            var documentPaths = uploadedPdfPaths.ToList(); // предполагается, что ты уже собираешь документы где-то

            string generatedLogin, generatedPassword;

            bool success = ApplicantRepository.RegisterApplicant(
                fullName, passport, snils, email, phone,
                parentName, graduatedFrom, educationLevel, averageScore,
                directions, egeSubjects, egeScores, documentPaths,
                out generatedLogin, out generatedPassword
            );

            if (success)
            {
                MessageBox.Show($"Регистрация прошла успешно!\nВаш логин: {generatedLogin}\nПароль: {generatedPassword}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // или очистить поля, если хочешь остаться на форме
            }
        }


        private void btnUploadPdf_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "PDF файлы (*.pdf)|*.pdf",
                Title = "Выберите документы об образовании",
                Multiselect = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                uploadedPdfPaths.Clear();
                uploadedPdfPaths.AddRange(openFileDialog.FileNames);

                MessageBox.Show($"Загружено файлов: {uploadedPdfPaths.Count}", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public class ApplicantRepository
        {
            public static bool RegisterApplicant(string fullName, string passport, string snils, string email, string phone,
                string parentName, string graduatedFrom, string educationLevel, decimal averageScore,
                List<string> directions, List<string> egeSubjects, List<int> egeScores,
                List<string> documentPaths, out string generatedLogin, out string generatedPassword)
            {
                generatedLogin = email;
                generatedPassword = Guid.NewGuid().ToString().Substring(0, 8);

                using (var conn = Database.GetConnection())
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        using (var checkCmd = new NpgsqlCommand("SELECT COUNT(*) FROM applicants WHERE email = @e OR phone = @p", conn))
                        {
                            checkCmd.Parameters.AddWithValue("e", email);
                            checkCmd.Parameters.AddWithValue("p", phone);
                            var exists = (long)checkCmd.ExecuteScalar();

                            if (exists > 0)
                            {
                                MessageBox.Show("Пользователь с таким email или телефоном уже зарегистрирован.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                generatedLogin = null;
                                generatedPassword = null;
                                return false;
                            }
                        }

                        string passwordHash = BCrypt.Net.BCrypt.HashPassword(generatedPassword);

                        using (var cmd = new NpgsqlCommand("INSERT INTO users (login, passwordhash, role) VALUES (@login, @password, 'Абитуриент') RETURNING id", conn, tran))
                        {
                            cmd.Parameters.AddWithValue("login", generatedLogin);
                            cmd.Parameters.AddWithValue("password", passwordHash);
                            int userId = (int)cmd.ExecuteScalar();

                            using (var applicantCmd = new NpgsqlCommand(@"
                        INSERT INTO applicants 
                            (user_id, full_name, passport, snils, email, phone, parent_name, graduated_from,
                            education_level, average_score, directions, ege_subjects, ege_scores, document_paths)
                        VALUES
                            (@user_id, @full_name, @passport, @snils, @email, @phone, @parent_name, @graduated_from,
                            @education_level, @average_score, @directions, @ege_subjects, @ege_scores, @document_paths)", conn, tran))
                            {
                                applicantCmd.Parameters.AddWithValue("user_id", userId);
                                applicantCmd.Parameters.AddWithValue("full_name", fullName);
                                applicantCmd.Parameters.AddWithValue("passport", passport);
                                applicantCmd.Parameters.AddWithValue("snils", snils);
                                applicantCmd.Parameters.AddWithValue("email", email);
                                applicantCmd.Parameters.AddWithValue("phone", phone);
                                applicantCmd.Parameters.AddWithValue("parent_name", parentName);
                                applicantCmd.Parameters.AddWithValue("graduated_from", graduatedFrom);
                                applicantCmd.Parameters.AddWithValue("education_level", educationLevel);
                                applicantCmd.Parameters.AddWithValue("average_score", averageScore);
                                applicantCmd.Parameters.AddWithValue("directions", directions.ToArray());
                                applicantCmd.Parameters.AddWithValue("ege_subjects", egeSubjects?.ToArray() ?? new string[0]);
                                applicantCmd.Parameters.AddWithValue("ege_scores", egeScores?.ToArray() ?? new int[0]);
                                applicantCmd.Parameters.AddWithValue("document_paths", documentPaths.ToArray());

                                applicantCmd.ExecuteNonQuery();
                                int applicantId;
                                using (var getApplicantIdCmd = new NpgsqlCommand("SELECT id FROM applicants WHERE user_id = @user_id", conn, tran))
                                {
                                    getApplicantIdCmd.Parameters.AddWithValue("user_id", userId);
                                    applicantId = (int)getApplicantIdCmd.ExecuteScalar();
                                }

                                // Для каждого названия направления — получим его id и вставим в applicant_directions
                                foreach (var directionName in directions)
                                {
                                    int directionId;
                                    using (var getDirectionIdCmd = new NpgsqlCommand("SELECT id FROM directions WHERE direction_name = @name", conn, tran))
                                    {
                                        getDirectionIdCmd.Parameters.AddWithValue("name", directionName);
                                        var result = getDirectionIdCmd.ExecuteScalar();
                                        if (result == null)
                                            throw new Exception($"Направление \"{directionName}\" не найдено в базе данных.");

                                        directionId = (int)result;
                                    }

                                    using (var insertLinkCmd = new NpgsqlCommand(
                                        "INSERT INTO applicant_directions (applicant_id, direction_id) VALUES (@applicantId, @directionId)", conn, tran))
                                    {
                                        insertLinkCmd.Parameters.AddWithValue("applicantId", applicantId);
                                        insertLinkCmd.Parameters.AddWithValue("directionId", directionId);
                                        insertLinkCmd.ExecuteNonQuery();
                                    }
                                }

                            }
                        }

                        tran.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show("Ошибка при регистрации: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }


                }

            }
        }

    }
}
