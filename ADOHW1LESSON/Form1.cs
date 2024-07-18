using System.Data;
using System.Data.SqlClient;

namespace ADOHW1LESSON
{
    public partial class RegisterWin : Form
    {
        string connectionString = @"Server = (localdb)\MSSQLLocalDB;Integrated Security = SSPI;Database = RegData;";

        SqlConnection sqlConnection = null;
        SqlDataReader reader = null;
        SqlCommand cmd = new();

        public RegisterWin()
        {

            InitializeComponent();
        }

        private void SingUpButton_Click(object sender, EventArgs e)
        {
            RegForm regForm = new RegForm();
            regForm.Show();
        }


        private void SignInButton_Click(object sender, EventArgs e)
        {
            using (sqlConnection = new SqlConnection(connectionString))
            {
                cmd = new(@"SELECT * FROM RegTable", sqlConnection);
                sqlConnection.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (LoginTextBox.Text == reader[4].ToString() && PasswordTextBox.Text == reader["Password"].ToString())
                    {
                        MessageBox.Show($"Welcome! {reader["Name"]} {reader["Surname"]}");
                    }
                }

            }
        }
    }
}
