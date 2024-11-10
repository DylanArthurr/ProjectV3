namespace MajorProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {


            if (Forms.FiniteStateTable.Visible)
            {

            }
            else if(!Forms.FiniteStateTable.Visible)
            {

            }
            else
            {
                Forms.FiniteStateTable = new FiniteStateForm();
            }
            Forms.FiniteStateTable.Visible = !Forms.FiniteStateTable.Visible;
            Forms.FiniteStateTable.Height = 438;
            Forms.FiniteStateTable.Width = 555;





        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.Frontpage.Show();
        }
    }
}
