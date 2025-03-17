using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MajorProject
{
    public partial class MainForm : Form
    {
        private ObjMachine Machine = new ObjMachine();
        private FiniteStateForm FSM = new FiniteStateForm();
        private TextBox[] tapevalues;
        public MainForm()
        {
            InitializeComponent();
            InitializeTapeValues();
        }
        // Loads FSM transitions from the FiniteStateForm into the Turing Machine.
        public void LoadFSMTransitionsIntoTuringMachine()
        {
            FSM.LoadTransitions(); // This method is public in FiniteStateForm
            Machine.SetStateTable(FSM.Transitions);
            MessageBox.Show("FSM Transitions Applied to Turing Machine!");
        }
        private void InitializeTapeValues()
        {
            tapevalues = new TextBox[]
            {
                tape1, tape2, tape3, tape4, tape5, tape6, tape7,
                tape8, tape9, tape10, tape11, tape12, tape13, tape14
            };

            /*foreach (var textBox in tapevalues)
            {
                textBox.Leave += UpdateTapeValues;
            }*/
        }
        private void GetTapeValues()
        {
            int tapeStart = Machine.GetHeadPos() - tapevalues.Length / 2;  // Center around the head

            for (int i = 0; i < tapevalues.Length; i++)
            {
                int tapeIndex = tapeStart + i;  // Ensure we're reading the correct tape index


            }

            currstatetextbox.Text = Machine.GetCurrentState(); // ? Ensure current state is shown
        }

        private void UpdateTapeValues(object sender, EventArgs e)
        {
            for (int i = -7; i < tapevalues.Length; i++)
            {
                int x = Machine.GetHeadPos() - 7 + i;  // Correctly map textbox to tape index

                if (x < 0)
                {
                    Machine.SetTapeValue("0", x);  // Ensure negative indices have '0'
                }
                else
                {
                    tapevalues[i].BackColor = Color.White;
                    Machine.SetTapeValue(tapevalues[i].Text, x);  // Correctly save user input
                }
            }

            GetTapeValues();  // Refresh UI display after updates
        }



        private void ExecuteInstruction()
        {
            int result = Machine.Execute();
            if (result == -1)
            {
                MessageBox.Show("Simulation Completed");
            }
            GetTapeValues();

            if (Machine.GetCurrentState() == Machine.GetAcceptState())
            {
                MessageBox.Show("Accepted State Reached!");
            }
        }



        // Event handler for the "Step" button.
        private void StepButton_Click(object sender, EventArgs e)
        {


            ExecuteInstruction();
            foreach (var transition in FSM.Transitions)
            {
                MessageBox.Show($"From {transition.Key.Item1} on {transition.Key.Item2} ? To {transition.Value.Item2}, Write {transition.Value.Item1}, Move {transition.Value.Item3}");
            }
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Single definition of ObjMachine (outside MainForm) so that its methods (including SetAlphabet) are available.
        public class ObjMachine
        {
            private Dictionary<(string state, char symbol), (string newState, char newSymbol, int moveDirection)> stateTable =
                new Dictionary<(string, char), (string, char, int)>();
            private List<char> tape = new List<char>();
            internal int tapeHead = 0; // internal for our simple access
            private string currentState = "start";
            private string acceptState = "accept";
            private HashSet<char> alphabet = new HashSet<char>();

            public string GetCurrentState() => currentState;
            public string GetAcceptState() => acceptState;
            public void SetCurrentState(string state) => currentState = state;
            public void SetAcceptState(string state) => acceptState = state;
            public int GetHeadPos() => tapeHead;
            public void MoveHeadRight() => tapeHead++;
            public void MoveHeadLeft() => tapeHead--;

            // New method to set the head position.
            public void SetHeadPos(int pos)
            {
                tapeHead = pos;
            }

            public string GetTapeValue(int index)
            {
                while (index >= tape.Count || index < 0)  // Fix: Ensure negatives are initialized
                {
                    tape.Insert(0, '0');  // Fix: Prepend '0' for negative indexes
                }
                return index >= 0 ? tape[index].ToString() : "0";  //Fix: Always return '0' if out of bounds
            }


            public void SetTapeValue(string value, int index)
            {
                while (index >= tape.Count) tape.Add(' ');
                if (index >= 0 && !string.IsNullOrEmpty(value))
                    tape[index] = value[0];
            }

            public string GetAlphabet() => new string(alphabet.ToArray());
            public void SetAlphabet(string alpha)
            {
                alphabet = new HashSet<char>(alpha.ToCharArray());
            }

            public int Execute()
            {
                char currentSymbol = tape[tapeHead];
                MessageBox.Show($"Executing Step | State: {currentState} | Tape Symbol: '{currentSymbol}'");

                if (stateTable.TryGetValue((currentState, currentSymbol), out var transition))
                {
                    (string newState, char newSymbol, int moveDirection) = transition;
                    tape[tapeHead] = newSymbol;
                    currentState = newState;
                    tapeHead += moveDirection;

                    MessageBox.Show($"Transition Applied: Write '{newSymbol}', Move {moveDirection}, New State: {newState}");
                    return 0;
                }

                MessageBox.Show("No valid transition found — halting.");
                return -1;  // No matching transition
            }


            public void ClearTape()
            {
                tape.Clear();
                tapeHead = 0;
                currentState = "start";
            }

            // Allows setting the FSM state table.
            public void SetStateTable(Dictionary<(string, char), (string, char, int)> table)
            {
                stateTable = table;
            }
        }



        private void Button1_Click(object sender, EventArgs e)
        {

        }
        private void Button2_Click(object sender, EventArgs e)
        {


            if (Forms.FiniteStateTable.Visible)
            {

            }
            else if (!Forms.FiniteStateTable.Visible)
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
            Machine.ClearTape();  // Ensure tape starts fresh
            Machine.SetCurrentState("start");
            Machine.SetAcceptState("halt");
            Machine.SetAlphabet("01 "); // Default alphabet

            // Prepopulate ALL tape positions with '0' (including negative indices)
            for (int i = -7; i < 14; i++)  // Fix: Start from -7 to cover all displayed cells
            {
                Machine.SetTapeValue("0", i);
            }

            Machine.SetHeadPos(0);  // Set head to first valid cell
            GetTapeValues();  // Refresh tape values in UI CAUSING ERROR 
        }




        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.Frontpage.Show();
        }
        private void Tape_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        private void tape1_TextChanged(object sender, EventArgs e)
        {

        }
        private void tape2_TextChanged(object sender, EventArgs e)
        {

        }
        private void tape3_TextChanged(object sender, EventArgs e)
        {

        }
        private void tape4_TextChanged(object sender, EventArgs e)
        {

        }
        private void tape5_TextChanged(object sender, EventArgs e)
        {

        }
        private void tape6_TextChanged(object sender, EventArgs e)
        {

        }
        private void tape7_TextChanged(object sender, EventArgs e)
        {

        }
        private void tape10_TextChanged(object sender, EventArgs e)
        {

        }
        private void tape11_TextChanged(object sender, EventArgs e)
        {

        }
        private void tape12_TextChanged(object sender, EventArgs e)
        {

        }
        private void tape13_TextChanged(object sender, EventArgs e)
        {

        }
        private void tape14_TextChanged(object sender, EventArgs e)
        {

        }
        private void moverightbttn_Click(object sender, EventArgs e)
        {

        }
        private void cleartapebttn_Click(object sender, EventArgs e)
        {
            Machine.ClearTape();
        }
        private void moveleftbttn_Click(object sender, EventArgs e)
        {

        }
        private void currstatetextbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void acceptingstatetextbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void alphabettextbox_TextChanged(object sender, EventArgs e)
        {

        }
        // Event handler for the "Load FSM Rules" button.
        private void savechangesbttn_Click(object sender, EventArgs e)
        {
            LoadFSMTransitionsIntoTuringMachine();
        }
        private void newinstructionbttn_Click(object sender, EventArgs e)
        {

        }
        private void runbttn_Click(object sender, EventArgs e)
        {
            while (Machine.GetCurrentState() != "halt")
            {
                ExecuteInstruction();
            }
        }
        private void stepbttn_Click(object sender, EventArgs e)
        {
            ExecuteInstruction();
        }
        private void stopbttn_Click(object sender, EventArgs e)
        {

        }
        private void savealphabetbttn_Click(object sender, EventArgs e)
        {

        }

        private void SetHeadPositionButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(headPositionTextbox.Text, out int newHeadPos))
            {
                Machine.SetHeadPos(newHeadPos);
                GetTapeValues();  // Refresh tape values after head position change
                MessageBox.Show($"Head position set to {newHeadPos}");
            }
            else
            {
                MessageBox.Show("Invalid head position. Please enter a number.");
            }
        }
    }
}
 
