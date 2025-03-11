using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MajorProject
{
    public partial class FiniteStateForm : Form
    {
        private Dictionary<(string, char), (char, string, char)> transitions;
        private string currentState;

        public FiniteStateForm()
        {
            InitializeComponent();
            transitions = new Dictionary<(string, char), (char, string, char)>();

            // Attempt to get the existing "Movement" column.
            var movementCol = dataGridView1.Columns["Movement"] as DataGridViewComboBoxColumn;
            if (movementCol != null)
            {
                // Modify the existing column's properties
                movementCol.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
                movementCol.DisplayStyleForCurrentCellOnly = false;
                movementCol.Items.Clear();
                movementCol.Items.AddRange(new object[] { ">", "<", "-" });
            }
            else
            {
                // If not found, create and add a new column.
                movementCol = new DataGridViewComboBoxColumn();
                movementCol.HeaderText = "Movement";
                movementCol.Name = "Movement";
                movementCol.Items.AddRange(new object[] { ">", "<", "-" });
                movementCol.MaxDropDownItems = 3;
                movementCol.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
                movementCol.DisplayStyleForCurrentCellOnly = false;
                dataGridView1.Columns.Add(movementCol);
            }

            // Input TextBox
            inputTextBox = new TextBox();
            inputTextBox.Location = new Point(10, 420);
            inputTextBox.Size = new Size(200, 30);
            Controls.Add(inputTextBox);

            // Test Button
            testButton = new Button();
            testButton.Text = "Run FSM";
            testButton.Location = new Point(220, 420);
            testButton.Click += TestButton_Click;
            Controls.Add(testButton);

            // Output Label
            outputLabel = new Label();
            outputLabel.Location = new Point(10, 460);
            outputLabel.Size = new Size(300, 30);
            Controls.Add(outputLabel);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadTransitions();
        }

        private void LoadTransitions()
        {
            transitions.Clear();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Skip new row placeholder if present.
                if (!row.IsNewRow)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null &&
                        row.Cells[2].Value != null && row.Cells[3].Value != null &&
                        row.Cells[4].Value != null)
                    {
                        char input = Convert.ToChar(row.Cells[0].Value);
                        string startState = row.Cells[1].Value.ToString();
                        char output = Convert.ToChar(row.Cells[2].Value);
                        char move = Convert.ToChar(row.Cells[3].Value);
                        string endState = row.Cells[4].Value.ToString();

                        transitions[(startState, input)] = (output, endState, move);
                    }
                }
            }
        }

        public string ProcessInput(string input)
        {
            char[] tape = input.ToCharArray();
            int head = 0;
            currentState = "q0"; // Assume initial state is "q0"

            while (head >= 0 && head < tape.Length)
            {
                if (!transitions.TryGetValue((currentState, tape[head]), out var transition))
                {
                    MessageBox.Show("No valid transition found, halting.");
                    return new string(tape);
                }

                tape[head] = transition.Item1;
                currentState = transition.Item2;

                if (transition.Item3 == '>')
                    head++;
                else if (transition.Item3 == '<')
                    head--;
            }

            return new string(tape);
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Please enter an input string.");
                return;
            }

            string output = ProcessInput(input);
            outputLabel.Text = $"Output: {output}";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Additional cell click logic if needed.
        }
    }
}
