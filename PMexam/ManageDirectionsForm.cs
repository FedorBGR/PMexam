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
    public partial class ManageDirectionsForm : Form
    {
        public ManageDirectionsForm()
        {
            InitializeComponent();
            LoadEducationLevels();
            cbEducationLevels.SelectedIndexChanged += (s, e) => LoadDirections();
        }

        private void LoadEducationLevels()
        {
            cbEducationLevels.Items.Clear();
            using (var conn = Database.GetConnection())
            using (var cmd = new NpgsqlCommand("SELECT id, level_name FROM education_levels ORDER BY level_name", conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    cbEducationLevels.Items.Add(new ComboBoxItem(reader.GetString(1), reader.GetInt32(0)));
                }
            }

            if (cbEducationLevels.Items.Count > 0)
                cbEducationLevels.SelectedIndex = 0;
        }

        private void LoadDirections()
        {
            dgvDirections.Columns.Clear(); 
            dgvDirections.Rows.Clear();    

            dgvDirections.Columns.Add("id", "ID");
            dgvDirections.Columns.Add("name", "Название направления");

            dgvDirections.Columns["id"].Visible = false;

            if (cbEducationLevels.SelectedItem is ComboBoxItem selected)
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new NpgsqlCommand("SELECT id, direction_name FROM directions WHERE level_id = @id ORDER BY direction_name", conn))
                {
                    cmd.Parameters.AddWithValue("id", selected.Value);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvDirections.Rows.Add(reader.GetInt32(0), reader.GetString(1));
                        }
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbEducationLevels.SelectedItem is ComboBoxItem selected)
            {
                string newDirection = txtNewDirection.Text.Trim();
                if (string.IsNullOrEmpty(newDirection))
                {
                    MessageBox.Show("Введите название направления.");
                    return;
                }

                using (var conn = Database.GetConnection())
                using (var cmd = new NpgsqlCommand("INSERT INTO directions (direction_name, level_id) VALUES (@name, @level)", conn))
                {
                    cmd.Parameters.AddWithValue("name", newDirection);
                    cmd.Parameters.AddWithValue("level", selected.Value);
                    cmd.ExecuteNonQuery();
                }

                txtNewDirection.Clear();
                LoadDirections();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDirections.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите направление для удаления.");
                return;
            }

            var confirm = MessageBox.Show("Удалить выбранное направление?", "Подтверждение", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.No) return;

            int directionId = (int)dgvDirections.SelectedRows[0].Cells[0].Value;

            using (var conn = Database.GetConnection())
            using (var cmd = new NpgsqlCommand("DELETE FROM directions WHERE id = @id", conn))
            {
                cmd.Parameters.AddWithValue("id", directionId);
                cmd.ExecuteNonQuery();
            }

            LoadDirections();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvDirections.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите направление для обновления.");
                return;
            }

            string updatedName = txtNewDirection.Text.Trim();
            if (string.IsNullOrEmpty(updatedName))
            {
                MessageBox.Show("Введите новое название.");
                return;
            }

            int directionId = (int)dgvDirections.SelectedRows[0].Cells[0].Value;

            using (var conn = Database.GetConnection())
            using (var cmd = new NpgsqlCommand("UPDATE directions SET direction_name = @name WHERE id = @id", conn))
            {
                cmd.Parameters.AddWithValue("name", updatedName);
                cmd.Parameters.AddWithValue("id", directionId);
                cmd.ExecuteNonQuery();
            }

            txtNewDirection.Clear();
            LoadDirections();
        }

        private void btnAddLevel_Click(object sender, EventArgs e)
        {
            string levelName = txtNewLevel.Text.Trim();
            if (string.IsNullOrEmpty(levelName))
            {
                MessageBox.Show("Введите название уровня образования.");
                return;
            }

            using (var conn = Database.GetConnection())
            using (var cmd = new NpgsqlCommand("INSERT INTO education_levels (level_name) VALUES (@name)", conn))
            {
                cmd.Parameters.AddWithValue("name", levelName);
                cmd.ExecuteNonQuery();
            }

            txtNewLevel.Clear();
            LoadEducationLevels();
        }
    }
    public class ComboBoxItem
    {
        public string Text { get; }
        public int Value { get; }

        public ComboBoxItem(string text, int value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString() => Text;
    }
}
