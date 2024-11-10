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

namespace ProjectV3
{
    public partial class FrontPage : Form
    {
        public FrontPage()
        {
            InitializeComponent();
        }

        private void LoginMessage_Click(object sender, EventArgs e)
        {

        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void TeacherLoginForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.TeacherLogin.Show();
        }

        private void StudentLoginForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.StudentLogin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.StudentRegisterForm.Show();
        }
    }
}
