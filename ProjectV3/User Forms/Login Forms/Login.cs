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

            string filePath = "Students.txt";

            // Check if file exists
            if (!File.Exists(filePath))
            {
                // Create a new file if it doesn't exist
                File.Create(filePath).Close();
            }

            // Initialize a dictionary to store the students (username as key, hashed password as value)
            Dictionary<string, string> Students = new Dictionary<string, string>();

            // Read the existing data from the file
            using (StreamReader FRead = new StreamReader(filePath))
            {
                while (!FRead.EndOfStream)
                {
                    string Users = FRead.ReadLine();
                    string[] UserSplit = Users.Split(",");
                    string UserName = UserSplit[0];
                    string Password = UserSplit[1];
                    Students.Add(UserName, Password);
                }
            }

            // Check if the username exists in the dictionary
            if (Students.ContainsKey(StudentLoginTextBox.Text))
            {
                // Username exists, now check if the password matches
                string storedPasswordHash = Students[StudentLoginTextBox.Text];

                if (storedPasswordHash == enteredPasswordHash)
                {
                    // Password matches, allow login
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    Forms.MainWindow.Show();
                }
                else
                {
                    // Password does not match
                    MessageBox.Show("Incorrect password! Please try again.");
                    StudentLoginPassword.Clear(); // Clear the password field for the user to try again
                    StudentLoginPassword.Focus(); // Focus the password field again
                }
            }
            else
            {
                // Username does not exist
                MessageBox.Show("Username not found! Please try again.");
                StudentLoginTextBox.Clear(); // Clear the username field for the user to try again
                StudentLoginTextBox.Focus(); // Focus the username field again
            }
            StudentLoginTextBox.ResetText();
            StudentLoginPassword.ResetText();
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

        private void QuitButton_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            StudentLoginTextBox.ResetText();
            StudentLoginPassword.ResetText();
            this.Hide();
            Forms.Frontpage.Show();
        }
    }
}
