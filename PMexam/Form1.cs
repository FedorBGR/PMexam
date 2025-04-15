using Npgsql;

namespace PMexam
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("������� ����� � ������");
                return;
            }

            using (var conn = Database.GetConnection())
            {
                var cmd = new NpgsqlCommand("SELECT * FROM Users WHERE Login = @login", conn);
                cmd.Parameters.AddWithValue("login", login);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string storedHash = reader["PasswordHash"].ToString();
                        string role = reader["Role"].ToString();
                        int userId = Convert.ToInt32(reader["Id"]);

                        if (PasswordHelper.VerifyPassword(password, storedHash))
                        {
                            if (role == "����������")
                                new ApplicantDashboardForm(userId).Show();
                            else
                                new AdminDashboardForm().Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("�������� ������");
                        }
                    }
                    else
                    {
                        MessageBox.Show("������������ �� ������");
                    }
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }
}
