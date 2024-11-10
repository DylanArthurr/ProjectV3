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
            this.Hide();
            Forms.MainWindow.Show();
        }

        private void TeacherUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
