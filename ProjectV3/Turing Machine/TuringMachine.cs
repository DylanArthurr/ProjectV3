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
            int tapeStart = Machine.GetHeadPos() - tapevalues.Length / 2;

            for (int i = 0; i < tapevalues.Length; i++)
            {
                int tapeIndex = tapeStart + i;
                tapevalues[i].Text = Machine.GetTapeValue(tapeIndex); // Ensure UI updates
            }

            currstatetextbox.Text = Machine.GetCurrentState(); // Update current state display
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

            GetTapeValues(); // Refresh UI display
            MessageBox.Show($"Head Position: {Machine.GetHeadPos()}, Tape: {string.Join("", Machine.GetTapeSnapshot())}");
        }





        private void StepButton_Click(object sender, EventArgs e)
        {
            ExecuteInstruction();
            GetTapeValues();  // Ensure the UI updates after every step
            this.Refresh(); // Force UI redraw
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

            public string GetTapeSnapshot()
            {
                return new string(tape.ToArray());
            }

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
                if (index < 0)
                    return "0";  // Return default value for negative indices

                // Ensure the tape list is long enough
                while (index >= tape.Count)
                {
                    tape.Add('0');
                }
                return tape[index].ToString();
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

                if (stateTable.TryGetValue((currentState, currentSymbol), out var transition))
                {
                    (string newState, char newSymbol, int moveDirection) = transition;
                    tape[tapeHead] = newSymbol;  // Ensure the new symbol is written
                    currentState = newState;
                    tapeHead += moveDirection;  // Move the head

                    return 0;
                }

                return -1;  // No valid transition, halt the machine
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
 
