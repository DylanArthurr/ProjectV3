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
            dataGridView1.AllowUserToAddRows = false; // Disable the "new row" feature
            dataGridView1.Rows.Clear();

            // Add 6 predefined test transitions
            dataGridView1.Rows.Add('0', "start", '1', ">", "halt");
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();

            Transitions = new Dictionary<(string, char), (string, char, int)>();
        }




        public void LoadTransitions()
        {
            Transitions.Clear();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Skip empty rows or the automatic "new row"
                if (row.IsNewRow ||
                    row.Cells[0].Value == null ||
                    row.Cells[1].Value == null ||
                    row.Cells[2].Value == null ||
                    row.Cells[3].Value == null ||
                    row.Cells[4].Value == null)
                {
                    continue; // Skip invalid/incomplete rows
                }

                // Extract values
                char input = Convert.ToChar(row.Cells[0].Value);
                string startState = row.Cells[1].Value.ToString();
                char output = Convert.ToChar(row.Cells[2].Value);
                string movementStr = row.Cells[3].Value.ToString();
                string endState = row.Cells[4].Value.ToString();

                // Movement handling
                int movement = movementStr == ">" ? 1 : (movementStr == "<" ? -1 : 0);

                // Add to transitions dictionary
                Transitions[(startState, input)] = (endState, output, movement);

                MessageBox.Show($"Transitions Loaded: {Transitions.Count}");
                foreach (var transition in Transitions)
                {
                    MessageBox.Show($"From {transition.Key.Item1} on {transition.Key.Item2} → Write {transition.Value.Item2}, Move {transition.Value.Item3}, To {transition.Value.Item1}");
                }

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void SaveTransitionsButton_Click(object sender, EventArgs e)
        {
            LoadTransitions();  // Reads the prefilled DataGridView rows
            MessageBox.Show("FSM Transitions Loaded Successfully!");
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        /*(private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string headerText = dataGridView1.Columns[e.ColumnIndex].HeaderText;

            // Ensure Input and Output are valid single characters
            if ((headerText == "Input" || headerText == "Output") && e.FormattedValue.ToString().Length != 1)
            {
                dataGridView1.Rows[e.RowIndex].ErrorText = "Input and Output must be exactly one character.";
                e.Cancel = true;
            }

            // Ensure Movement is valid
            if (headerText == "Movement" && !(e.FormattedValue.ToString() == ">" || e.FormattedValue.ToString() == "<"))
            {
                dataGridView1.Rows[e.RowIndex].ErrorText = "Movement must be '>' or '<'.";
                e.Cancel = true;
            }
        }*/

    }
}
