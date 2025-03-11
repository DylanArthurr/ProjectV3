using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MajorProject
{
    public partial class FiniteStateForm : Form
    {
        public Dictionary<(string, char), (string, char, int)> Transitions { get; private set; }

        public FiniteStateForm()
        {
            InitializeComponent();
            Transitions = new Dictionary<(string, char), (string, char, int)>();
        }

        public void LoadTransitions()
        {
            Transitions.Clear();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow && row.Cells[0].Value != null && row.Cells[1].Value != null &&
                    row.Cells[2].Value != null && row.Cells[3].Value != null && row.Cells[4].Value != null)
                {
                    char input = Convert.ToChar(row.Cells[0].Value);
                    string startState = row.Cells[1].Value.ToString();
                    char output = Convert.ToChar(row.Cells[2].Value);
                    string movementStr = row.Cells[3].Value.ToString();
                    string endState = row.Cells[4].Value.ToString();

                    int movement = movementStr == ">" ? 1 : (movementStr == "<" ? -1 : 0);

                    Transitions[(startState, input)] = (endState, output, movement);
                }
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // Optionally add initialization code here.
        }

        private void SaveTransitionsButton_Click(object sender, EventArgs e)
        {
            LoadTransitions();
            MessageBox.Show("FSM Transitions Loaded Successfully!");
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optionally add code here, or leave it empty.
        }
    }
}
