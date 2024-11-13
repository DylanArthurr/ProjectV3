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
            if (!File.Exists("Students.txt"))
            {
                File.Create("Students.txt");
            }

            //instantiate file reading and writing
            StreamWriter FWrite = new StreamWriter("Students.txt");
            StreamReader FRead = new StreamReader("Students.txt");

            //List of Studnets
            Dictionary<string, string> Students = new Dictionary<string, string>();
            //Puts Students into list
            while(!FRead.EndOfStream)
            {

                string Users = FRead.ReadLine();
                string[] UserSplit = Users.Split(",");
                string UserName = UserSplit[0];
                string Password = UserSplit[1];
                Students.Add(UserName, HashPassword(Password));
            }
            FRead.Close();
            //Selects Database to go thought usernames
            if (Students.ContainsKey(StudentUserName.Text))
            {
                MessageBox.Show("This UserName Already Exists");
            }
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
