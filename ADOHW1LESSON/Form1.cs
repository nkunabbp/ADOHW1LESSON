using System.Data.SqlClient;

namespace ADOHW1LESSON
{
    public partial class RegisterWin : Form
    {

        public RegisterWin()
        {
            InitializeComponent();
        }

        DataConnect dataConnect = new DataConnect();

        //string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=RegTable;Integrated Security=SSPI;";


        private void SingUpButton_Click(object sender, EventArgs e)
        {

        }

        private void SignInButton_Click(object sender, EventArgs e)
        {

            try
            {
                dataConnect.openconnection();
                SqlCommand cmd = new(@"SELECT * FROM RegTable");
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (LoginTextBox == reader["Login"] && PasswordTextBox == reader["Password"])
                    {
                        MessageBox.Show($"Welcome! {reader["Name"]} {reader["Surname"]}");
                    }
                }
            }
            finally
            {
                dataConnect.closeconnection();
            }

            //using SqlConnection connection = new(connectionString);
            //{
            //    connection.Open();
            //    SqlCommand cmd = new(@"SELECT * FROM RegTable", connection);
            //    SqlDataReader reader = cmd.ExecuteReader();
            //    while (reader.Read()) {
            //        if (LoginTextBox == reader["Login"] && PasswordTextBox == reader["Password"]) {
            //            MessageBox.Show($"Welcome! {reader["Name"]} {reader["Surname"]}");
            //        }
            //    }
            //}
        }
    }
}