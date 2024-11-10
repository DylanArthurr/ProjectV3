using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Microsoft.Data.SqlClient;
using MajorProject;

namespace ProjectV3
{
    public partial class StudentRegister : Form
    {
        public StudentRegister()
        {
            InitializeComponent();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void LoginMessage_Click(object sender, EventArgs e)
        {

        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            //Connect to database
            SqlConnection dbconn = new SqlConnection(Database.connection);
            //Opens Connection
            dbconn.Open();
            //Selects Database to go thought usernames
            string SQLCheck = "SELECT * FROM TBLUsers WHERE UserName = @UN";
            SqlDataAdapter da = new SqlDataAdapter(SQLCheck, dbconn);
            //Adds usernames found to SQLDataTable
            da.SelectCommand.Parameters.AddWithValue("@UN", StudentUserName.Text);
            DataTable results = new DataTable();
            //Fills datatable with usernames
            da.Fill(results);
            //if the username isnt in the datatable
            if (results.Rows.Count == 0)
            {
                // Adds username and password eneterd to database
                string SQLInsert = "INSERT INTO TBLUsers (UserName,PasswordHash,Teacher) VALUES (@UN, @PW, 0)";
                SqlCommand AddStud = new SqlCommand(SQLInsert, dbconn);
                AddStud.Parameters.AddWithValue("@UN", StudentUserName.Text);
                AddStud.Parameters.AddWithValue("@PW", HashPassword(Password.Text));
                AddStud.ExecuteNonQuery();
                this.Hide();
                Forms.MainWindow.Show();
            }
            else
            {
                //Prints Error Message
                MessageBox.Show("This user already exists");
            }
            //closes connection
            dbconn.Close();


        }
        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }


    }
}
