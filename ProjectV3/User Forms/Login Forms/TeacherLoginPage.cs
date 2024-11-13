using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Security.Cryptography;
using Microsoft.Data.SqlClient;
using MajorProject;
using System.IO;
using static System.Windows.Forms.LinkLabel;
using System.Collections;
using Microsoft.Identity.Client;

namespace ProjectV3
{
    public partial class TeacherLoginPage : Form
    {
        public TeacherLoginPage()
        {
            InitializeComponent();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Retrieve and hash the entered password
            string enteredPasswordHash = HashPassword(TeacherPassword.Text);

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
            if (Students.ContainsKey(TeacherUserName.Text))
            {
                // Username exists, now check if the password matches
                string storedPasswordHash = Students[TeacherUserName.Text];

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
                    TeacherPassword.Clear(); // Clear the password field for the user to try again
                    TeacherPassword.Focus(); // Focus the password field again
                }
            }
            else
            {
                // Username does not exist
                MessageBox.Show("Username not found! Please try again.");
                TeacherUserName.Clear(); // Clear the username field for the user to try again
                TeacherUserName.Focus(); // Focus the username field again
            }
            TeacherUserName.ResetText();
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

        private void TeacherUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
