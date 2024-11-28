namespace MajorProject
{
    public partial class MainForm : Form
    {
        private Dictionary<(string state, char symbol), (string newState, char newSymbol, int moveDirection)> stateTable;
        private List<char> tape;
        private int tapeHead;
        private string currentState;
        private HashSet<char> customAlphabet;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(Dictionary<(string, char), (string, char, int)> stateTable, HashSet<char> customAlphabet)
        {
            this.stateTable = stateTable;
            this.tape = new List<char> { ' ' }; // Initialize with a blank symbol
            this.tapeHead = 0;
            this.currentState = "start";
            this.customAlphabet = customAlphabet;
        }

        public void SetTape(string input)
        {
            tape = new List<char>(input);
            tapeHead = 0;
        }

        public string GetTape()
        {
            return string.Join("", tape);
        }

        public void Step()
        {
            char currentSymbol = tape[tapeHead];
            if (stateTable.ContainsKey((currentState, currentSymbol)))
            {
                var action = stateTable[(currentState, currentSymbol)];
                tape[tapeHead] = action.newSymbol;
                tapeHead += action.moveDirection;
                currentState = action.newState;

                if (tapeHead < 0)
                {
                    tape.Insert(0, ' ');
                    tapeHead = 0;
                }
                else if (tapeHead >= tape.Count)
                {
                    tape.Add(' ');
                }
            }
            else
            {
                Console.WriteLine("No transition found for current state and symbol.");
            }
        }

        public void Run()
        {
            while (currentState != "halt")
            {
                Step();
            }
        }

        public void SetAdditionStates()
        {
            stateTable = new Dictionary<(string, char), (string, char, int)>
            {
                { ("start", '1'), ("add", '1', 1) },
                { ("add", '1'), ("add", '1', 1) },
                { ("add", ' '), ("write_result", ' ', -1) },
                { ("write_result", '1'), ("write_result", '1', -1) },
                { ("write_result", ' '), ("halt", '2', 0) }  // Assume '2' represents the result
            };
            currentState = "start";
        }

        public void SetCustomAlphabet(HashSet<char> alphabet)
        {
            this.customAlphabet = alphabet;
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
    }
}
