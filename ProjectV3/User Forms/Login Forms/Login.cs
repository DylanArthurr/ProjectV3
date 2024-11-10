using Microsoft.Data.SqlClient;
using ProjectV3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Cryptography;


namespace MajorProject
{
    public partial class StudnetLoginPage : Form
    {
        public StudnetLoginPage()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ToRegisterForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.StudentRegisterForm.Show();
        }

        private void StudentLoginPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Retrieve and hash the entered password
            string enteredPasswordHash = HashPassword(StudentLoginPassword.Text);

            // Connect to the database
            using (SqlConnection dbconn = new SqlConnection(Database.connection))
            {
                dbconn.Open();

                // SQL query to check if the username and hashed password exist
                string SQLCheck = "SELECT COUNT(*) FROM TBLUsers WHERE UserName = @UN AND PasswordHash = @PW";
                using (SqlCommand command = new SqlCommand(SQLCheck, dbconn))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@UN", StudentLoginTextBox.Text);
                    command.Parameters.AddWithValue("@PW", enteredPasswordHash);

                    // Execute the query and get the count result
                    int count = (int)command.ExecuteScalar();

                    // Check if a matching record was found
                    if (count == 1)
                    {
                        this.Hide();
                        Forms.MainWindow.Show();
                    }
                    else
                    {
                        // Show an error message if login fails
                        MessageBox.Show("This user doesn't exist.");
                        StudentLoginPassword.Clear(); // Clear the password field for security
                    }
                }
            }
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
        private void StudentLoginTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
