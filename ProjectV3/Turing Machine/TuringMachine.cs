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

            foreach (var textBox in tapevalues)
            {
                textBox.Leave += UpdateTapeValues;
            }
        }
        private void GetTapeValues()
        {
            for (int i = 0; i < tapevalues.Length; i++)
            {
                int x = Machine.GetHeadPos() - 7 + i;
                tapevalues[i].Text = Machine.GetTapeValue(x);
            }
            currstatetextbox.Text = Machine.GetCurrentState(); // Update current state textbox.
        }
        private void UpdateTapeValues(object sender, EventArgs e)
        {
            for (int i = 0; i < tapevalues.Length; i++)
            {
                int x = Machine.GetHeadPos() - 7 + i;
                tapevalues[i].BackColor = Color.White;
                Machine.SetTapeValue(tapevalues[i].Text, x);
            }
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
            // Optional: Handle DataGridView cell clicks if needed.
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
                while (index >= tape.Count) tape.Add(' ');
                return index >= 0 ? tape[index].ToString() : " ";
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
                if (tapeHead < 0 || tapeHead >= tape.Count) return -1;
                char currentSymbol = tape[tapeHead];
                if (stateTable.TryGetValue((currentState, currentSymbol), out var transition))
                {
                    (string newState, char newSymbol, int moveDirection) = transition;
                    tape[tapeHead] = newSymbol;
                    currentState = newState;
                    tapeHead += moveDirection;
                    return 0;
                }
                return -1;
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
            Machine.SetAlphabet("01 "); // Default alphabet
            alphabettextbox.Text = "01 ";
            Machine.SetCurrentState("start"); // Ensure starting state is "start"

            // Initialize tape with zeros
            for (int i = 0; i < 14; i++)
            {
                Machine.SetTapeValue("0", i);
            }

            Machine.SetHeadPos(7); // Start in the middle of the tape
            currstatetextbox.Text = "start";
            GetTapeValues();
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
    }
}
 
