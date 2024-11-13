using MajorProject;
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


namespace ProjectV3.User_Forms.Login_Forms
{
    public partial class TeacherRegister : Form
    {
        public TeacherRegister()
        {
            InitializeComponent();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {

        }

        private void LoginBttn_Click(object sender, EventArgs e)
        {

        }

        private void TeacherPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void TeacherName_TextChanged(object sender, EventArgs e)
        {
            string filePath = "Teachers.txt";

            // Check if file exists
            if (!File.Exists(filePath))
            {
                // Create a new file if it doesn't exist
                File.Create(filePath).Close();
            }

            // Initialize a dictionary to store the students
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

            // Check if the username already exists
            if (Students.ContainsKey(TeacherNa.Text))
            {
                MessageBox.Show("This UserName Already Exists");
            }
            else
            {
                // Hash the password
                string password = HashPassword(TeacherPassw.Text);

                // Append the new student data to the file
                using (StreamWriter FWrite = new StreamWriter(filePath, append: true))
                {
                    FWrite.WriteLine($"{TeacherPassw.Text},{password}");
                }
            }
            TeacherPassw.ResetText();
            // Hide the current form and show the main window
            this.Hide();
            Forms.MainWindow.Show();
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
