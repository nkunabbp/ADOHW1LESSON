using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOHW1LESSON
{
    public partial class RegForm : Form
    {
        string connectionString = @"Server = (localdb)\MSSQLLocalDB;Integrated Security = SSPI;Database = RegData;";

        SqlConnection sqlConnection = null;

        string insertString = @"INSERT INTO RegTable(Name , Surname, Age, Login, Password)
                           VALUES(@Name, @Surname , @Age , @Login, @Password )";
        SqlCommand cmd = new();
        public RegForm()
        {
            InitializeComponent();
        }

        private void Adduser(string Name, string Surname, int Age, string Login, string Password)
        {
            using (cmd = new SqlCommand(insertString, sqlConnection))
            {
                cmd.Parameters.Add(new SqlParameter("Name", Name));
                cmd.Parameters.Add(new SqlParameter("Surname", Surname));
                cmd.Parameters.Add(new SqlParameter("Age", Age));
                cmd.Parameters.Add(new SqlParameter("Login", Login));
                cmd.Parameters.Add(new SqlParameter("Password", Password));
                cmd.ExecuteNonQuery();
            }
        }

        private void Regbutton_Click(object sender, EventArgs e)
        {
            using (sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                Adduser(NametextBox.Text, SurNametextBox.Text, Int32.Parse(AgetextBox.Text), LogintextBox.Text, PasswordtextBox.Text);
            }
        }

        
    }
}
