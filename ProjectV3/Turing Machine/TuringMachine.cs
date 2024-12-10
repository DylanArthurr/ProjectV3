namespace MajorProject
{
    public partial class MainForm : Form
    {
        private ObjMachine Machine = new ObjMachine();
        private TextBox[] tapevalues;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(Dictionary<(string, char), (string, char, int)> stateTable, HashSet<char> customAlphabet)
        {
            InitializeComponent();
            InitializeTapeValues();
        }
        private void InitializeTapeValues()
        {
            // Map tape values to the existing tape controls
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
            int i = 0;
            for (int x = Machine.GetHeadPos() - 7; x <= Machine.GetHeadPos() + 7; x++)
            {
                tapevalues[i].Text = Machine.GetTapeValue(x);
                i++;
            }

            currstatetextbox.Text = Machine.GetCurrentState(); // Update current state
        }

        private void UpdateTapeValues(object sender, EventArgs e)
        {
            int i = 0;
            for (int x = Machine.GetHeadPos() - 7; x <= Machine.GetHeadPos() + 7; x++)
            {
                if (!Machine.GetAlphabet().Contains(Machine.GetTapeValue(x)))
                {
                    tapevalues[i].BackColor = Color.Red;
                    MessageBox.Show("One or more characters are not in the machine's alphabet");
                }
                else
                {
                    tapevalues[i].BackColor = Color.White;
                    Machine.SetTapeValue(tapevalues[i].Text, x);
                }
                i++;
            }
        }

        private void ExecuteInstruction()
        {
            int p = Machine.Execute();
            if (p == -1)
            {
                MessageBox.Show("Simulation Completed");
                return;
            }

            GetTapeValues();

            if (Machine.GetCurrentState() == Machine.GetAcceptState())
            {
                MessageBox.Show("Accepted State Reached!");
            }
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
            Machine.SetCurrentState("start");
            currstatetextbox.Text = "start";
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
            Machine.MoveHeadRight();
            GetTapeValues();
        }

        private void cleartapebttn_Click(object sender, EventArgs e)
        {
            Machine.ClearTape();
            foreach (var textBox in tapevalues)
            {
                textBox.Text = "";
                textBox.BackColor = Color.White;
            }
        }

        private void moveleftbttn_Click(object sender, EventArgs e)
        {
            Machine.MoveHeadLeft();
            GetTapeValues();
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

        private void savechangesbttn_Click(object sender, EventArgs e)
        {

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
            Machine.SetAlphabet(alphabettextbox.Text); // Alphabet from `alphabettextbox`
        }
    }


    public class ObjMachine
    {
        private Dictionary<(string state, char symbol), (string newState, char newSymbol, int moveDirection)> stateTable;
        private List<char> tape = new List<char>();
        private int tapeHead = 0;
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

        public string GetTapeValue(int index)
        {
            while (index >= tape.Count) tape.Add(' ');
            return index >= 0 ? tape[index].ToString() : " ";
        }

        public void SetTapeValue(string value, int index)
        {
            while (index >= tape.Count) tape.Add(' ');
            if (index >= 0) tape[index] = value[0];
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
            if (stateTable.ContainsKey((currentState, currentSymbol)))
            {
                var (newState, newSymbol, moveDirection) = stateTable[(currentState, currentSymbol)];
                tape[tapeHead] = newSymbol;
                currentState = newState;
                tapeHead += moveDirection;
                return stateTable.Keys.ToList().IndexOf((currentState, currentSymbol));
            }
            return -1;
        }

        // Method to clear the tape
        public void ClearTape()
        {
            tape.Clear();
            tapeHead = 0;
            currentState = "start";
        }
    }

}
 
