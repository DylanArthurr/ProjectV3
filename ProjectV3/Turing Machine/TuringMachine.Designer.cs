namespace MajorProject
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            FiniteStateButton = new Button();
            LogOutButton = new Button();
            tape1 = new TextBox();
            tape2 = new TextBox();
            tape3 = new TextBox();
            tape4 = new TextBox();
            tape6 = new TextBox();
            tape5 = new TextBox();
            tape7 = new TextBox();
            tape8 = new TextBox();
            tape9 = new TextBox();
            tape10 = new TextBox();
            tape11 = new TextBox();
            tape12 = new TextBox();
            tape13 = new TextBox();
            tape14 = new TextBox();
            cleartapebttn = new Button();
            stopbttn = new Button();
            savealphabetbttn = new Button();
            stepbttn = new Button();
            runbttn = new Button();
            currstatelabel = new Label();
            acceptingstatelabel = new Label();
            alphabetlabel = new Label();
            currstatetextbox = new TextBox();
            acceptingstatetextbox = new TextBox();
            alphabettextbox = new TextBox();
            savechangesbttn = new Button();
            newinstructionbttn = new Button();
            loadFSMButton = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            headPositionTextbox = new TextBox();
            SetHeadPositionButton = new Button();
            SuspendLayout();
            // 
            // FiniteStateButton
            // 
            FiniteStateButton.BackColor = Color.FromArgb(168, 147, 118);
            FiniteStateButton.FlatStyle = FlatStyle.Popup;
            FiniteStateButton.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FiniteStateButton.ForeColor = Color.Transparent;
            FiniteStateButton.Location = new Point(12, 12);
            FiniteStateButton.Name = "FiniteStateButton";
            FiniteStateButton.Size = new Size(114, 45);
            FiniteStateButton.TabIndex = 3;
            FiniteStateButton.Text = "Finite State Table";
            FiniteStateButton.UseVisualStyleBackColor = false;
            FiniteStateButton.Click += Button2_Click;
            // 
            // LogOutButton
            // 
            LogOutButton.BackColor = Color.FromArgb(168, 147, 118);
            LogOutButton.FlatStyle = FlatStyle.Popup;
            LogOutButton.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOutButton.ForeColor = Color.Transparent;
            LogOutButton.Location = new Point(482, 324);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(114, 45);
            LogOutButton.TabIndex = 6;
            LogOutButton.Text = "Logout";
            LogOutButton.UseVisualStyleBackColor = false;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // tape1
            // 
            tape1.Location = new Point(12, 116);
            tape1.Name = "tape1";
            tape1.Size = new Size(25, 20);
            tape1.TabIndex = 7;
            tape1.TextChanged += tape1_TextChanged;
            // 
            // tape2
            // 
            tape2.Location = new Point(55, 116);
            tape2.Name = "tape2";
            tape2.Size = new Size(25, 20);
            tape2.TabIndex = 8;
            tape2.TextChanged += tape2_TextChanged;
            // 
            // tape3
            // 
            tape3.Location = new Point(101, 116);
            tape3.Name = "tape3";
            tape3.Size = new Size(25, 20);
            tape3.TabIndex = 9;
            tape3.TextChanged += tape3_TextChanged;
            // 
            // tape4
            // 
            tape4.Location = new Point(143, 116);
            tape4.Name = "tape4";
            tape4.Size = new Size(25, 20);
            tape4.TabIndex = 10;
            tape4.TextChanged += tape4_TextChanged;
            // 
            // tape6
            // 
            tape6.Location = new Point(224, 116);
            tape6.Name = "tape6";
            tape6.Size = new Size(25, 20);
            tape6.TabIndex = 11;
            tape6.TextChanged += tape6_TextChanged;
            // 
            // tape5
            // 
            tape5.Location = new Point(183, 116);
            tape5.Name = "tape5";
            tape5.Size = new Size(25, 20);
            tape5.TabIndex = 11;
            tape5.TextChanged += tape5_TextChanged;
            // 
            // tape7
            // 
            tape7.Location = new Point(266, 116);
            tape7.Name = "tape7";
            tape7.Size = new Size(25, 20);
            tape7.TabIndex = 12;
            tape7.TextChanged += tape7_TextChanged;
            // 
            // tape8
            // 
            tape8.Location = new Point(307, 116);
            tape8.Name = "tape8";
            tape8.Size = new Size(25, 20);
            tape8.TabIndex = 13;
            tape8.TextChanged += textBox8_TextChanged;
            // 
            // tape9
            // 
            tape9.Location = new Point(348, 116);
            tape9.Name = "tape9";
            tape9.Size = new Size(25, 20);
            tape9.TabIndex = 14;
            tape9.TextChanged += textBox9_TextChanged;
            // 
            // tape10
            // 
            tape10.Location = new Point(390, 116);
            tape10.Name = "tape10";
            tape10.Size = new Size(25, 20);
            tape10.TabIndex = 15;
            tape10.TextChanged += tape10_TextChanged;
            // 
            // tape11
            // 
            tape11.Location = new Point(431, 116);
            tape11.Name = "tape11";
            tape11.Size = new Size(25, 20);
            tape11.TabIndex = 16;
            tape11.TextChanged += tape11_TextChanged;
            // 
            // tape12
            // 
            tape12.Location = new Point(471, 116);
            tape12.Name = "tape12";
            tape12.Size = new Size(25, 20);
            tape12.TabIndex = 17;
            tape12.TextChanged += tape12_TextChanged;
            // 
            // tape13
            // 
            tape13.Location = new Point(518, 116);
            tape13.Name = "tape13";
            tape13.Size = new Size(25, 20);
            tape13.TabIndex = 18;
            tape13.TextChanged += tape13_TextChanged;
            // 
            // tape14
            // 
            tape14.Location = new Point(560, 116);
            tape14.Name = "tape14";
            tape14.Size = new Size(25, 20);
            tape14.TabIndex = 19;
            tape14.TextChanged += tape14_TextChanged;
            // 
            // cleartapebttn
            // 
            cleartapebttn.BackColor = Color.FromArgb(168, 147, 118);
            cleartapebttn.FlatStyle = FlatStyle.Popup;
            cleartapebttn.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            cleartapebttn.ForeColor = Color.Transparent;
            cleartapebttn.Location = new Point(208, 152);
            cleartapebttn.Name = "cleartapebttn";
            cleartapebttn.Size = new Size(165, 34);
            cleartapebttn.TabIndex = 21;
            cleartapebttn.Text = "Clear Tape";
            cleartapebttn.UseVisualStyleBackColor = false;
            cleartapebttn.Click += cleartapebttn_Click;
            // 
            // stopbttn
            // 
            stopbttn.BackColor = Color.FromArgb(168, 147, 118);
            stopbttn.FlatStyle = FlatStyle.Popup;
            stopbttn.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stopbttn.ForeColor = Color.Transparent;
            stopbttn.Location = new Point(242, 324);
            stopbttn.Name = "stopbttn";
            stopbttn.Size = new Size(114, 45);
            stopbttn.TabIndex = 23;
            stopbttn.Text = "Stop";
            stopbttn.UseVisualStyleBackColor = false;
            stopbttn.Click += stopbttn_Click;
            // 
            // savealphabetbttn
            // 
            savealphabetbttn.BackColor = Color.FromArgb(168, 147, 118);
            savealphabetbttn.FlatStyle = FlatStyle.Popup;
            savealphabetbttn.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            savealphabetbttn.ForeColor = Color.Transparent;
            savealphabetbttn.Location = new Point(362, 324);
            savealphabetbttn.Name = "savealphabetbttn";
            savealphabetbttn.Size = new Size(114, 45);
            savealphabetbttn.TabIndex = 24;
            savealphabetbttn.Text = "Save Alphabet";
            savealphabetbttn.UseVisualStyleBackColor = false;
            savealphabetbttn.Click += savealphabetbttn_Click;
            // 
            // stepbttn
            // 
            stepbttn.BackColor = Color.FromArgb(168, 147, 118);
            stepbttn.FlatStyle = FlatStyle.Popup;
            stepbttn.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stepbttn.ForeColor = Color.Transparent;
            stepbttn.Location = new Point(122, 324);
            stepbttn.Name = "stepbttn";
            stepbttn.Size = new Size(114, 45);
            stepbttn.TabIndex = 25;
            stepbttn.Text = "Step";
            stepbttn.UseVisualStyleBackColor = false;
            stepbttn.Click += stepbttn_Click;
            // 
            // runbttn
            // 
            runbttn.BackColor = Color.FromArgb(168, 147, 118);
            runbttn.FlatStyle = FlatStyle.Popup;
            runbttn.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            runbttn.ForeColor = Color.Transparent;
            runbttn.Location = new Point(2, 324);
            runbttn.Name = "runbttn";
            runbttn.Size = new Size(114, 45);
            runbttn.TabIndex = 26;
            runbttn.Text = "Run";
            runbttn.UseVisualStyleBackColor = false;
            runbttn.Click += runbttn_Click;
            // 
            // currstatelabel
            // 
            currstatelabel.AutoSize = true;
            currstatelabel.BackColor = Color.FromArgb(168, 147, 118);
            currstatelabel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            currstatelabel.ForeColor = Color.Black;
            currstatelabel.Location = new Point(50, 213);
            currstatelabel.Name = "currstatelabel";
            currstatelabel.Size = new Size(123, 18);
            currstatelabel.TabIndex = 27;
            currstatelabel.Text = "Current State =";
            // 
            // acceptingstatelabel
            // 
            acceptingstatelabel.AutoSize = true;
            acceptingstatelabel.BackColor = Color.FromArgb(168, 147, 118);
            acceptingstatelabel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            acceptingstatelabel.ForeColor = Color.Black;
            acceptingstatelabel.Location = new Point(50, 249);
            acceptingstatelabel.Name = "acceptingstatelabel";
            acceptingstatelabel.Size = new Size(140, 18);
            acceptingstatelabel.TabIndex = 28;
            acceptingstatelabel.Text = "Accepting State =";
            // 
            // alphabetlabel
            // 
            alphabetlabel.AutoSize = true;
            alphabetlabel.BackColor = Color.FromArgb(168, 147, 118);
            alphabetlabel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            alphabetlabel.ForeColor = Color.Black;
            alphabetlabel.Location = new Point(50, 289);
            alphabetlabel.Name = "alphabetlabel";
            alphabetlabel.Size = new Size(92, 18);
            alphabetlabel.TabIndex = 29;
            alphabetlabel.Text = "Alphabet = ";
            // 
            // currstatetextbox
            // 
            currstatetextbox.BackColor = Color.FromArgb(168, 147, 118);
            currstatetextbox.Location = new Point(183, 213);
            currstatetextbox.Name = "currstatetextbox";
            currstatetextbox.Size = new Size(106, 20);
            currstatetextbox.TabIndex = 30;
            currstatetextbox.TextChanged += currstatetextbox_TextChanged;
            // 
            // acceptingstatetextbox
            // 
            acceptingstatetextbox.BackColor = Color.FromArgb(168, 147, 118);
            acceptingstatetextbox.Location = new Point(195, 245);
            acceptingstatetextbox.Name = "acceptingstatetextbox";
            acceptingstatetextbox.Size = new Size(94, 20);
            acceptingstatetextbox.TabIndex = 31;
            acceptingstatetextbox.TextChanged += acceptingstatetextbox_TextChanged;
            // 
            // alphabettextbox
            // 
            alphabettextbox.BackColor = Color.FromArgb(168, 147, 118);
            alphabettextbox.Location = new Point(143, 287);
            alphabettextbox.Name = "alphabettextbox";
            alphabettextbox.Size = new Size(146, 20);
            alphabettextbox.TabIndex = 32;
            alphabettextbox.TextChanged += alphabettextbox_TextChanged;
            // 
            // savechangesbttn
            // 
            savechangesbttn.BackColor = Color.FromArgb(168, 147, 118);
            savechangesbttn.FlatStyle = FlatStyle.Popup;
            savechangesbttn.Location = new Point(316, 217);
            savechangesbttn.Name = "savechangesbttn";
            savechangesbttn.Size = new Size(91, 24);
            savechangesbttn.TabIndex = 33;
            savechangesbttn.Text = "Save Changes";
            savechangesbttn.UseVisualStyleBackColor = false;
            savechangesbttn.Click += savechangesbttn_Click;
            // 
            // newinstructionbttn
            // 
            newinstructionbttn.BackColor = Color.FromArgb(168, 147, 118);
            newinstructionbttn.FlatStyle = FlatStyle.Popup;
            newinstructionbttn.Location = new Point(416, 222);
            newinstructionbttn.Name = "newinstructionbttn";
            newinstructionbttn.Size = new Size(127, 19);
            newinstructionbttn.TabIndex = 34;
            newinstructionbttn.Text = "Add New Instruction";
            newinstructionbttn.UseVisualStyleBackColor = false;
            newinstructionbttn.Click += newinstructionbttn_Click;
            // 
            // loadFSMButton
            // 
            loadFSMButton.Location = new Point(23, 375);
            loadFSMButton.Name = "loadFSMButton";
            loadFSMButton.Size = new Size(75, 23);
            loadFSMButton.TabIndex = 0;
            loadFSMButton.Text = "Load FSM Rules";
            loadFSMButton.Click += savechangesbttn_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // headPositionTextbox
            // 
            headPositionTextbox.BackColor = Color.FromArgb(168, 147, 118);
            headPositionTextbox.Location = new Point(449, 268);
            headPositionTextbox.Name = "headPositionTextbox";
            headPositionTextbox.Size = new Size(94, 20);
            headPositionTextbox.TabIndex = 36;
            // 
            // SetHeadPositionButton
            // 
            SetHeadPositionButton.BackColor = Color.FromArgb(168, 147, 118);
            SetHeadPositionButton.FlatStyle = FlatStyle.Popup;
            SetHeadPositionButton.Location = new Point(316, 269);
            SetHeadPositionButton.Name = "SetHeadPositionButton";
            SetHeadPositionButton.Size = new Size(127, 19);
            SetHeadPositionButton.TabIndex = 37;
            SetHeadPositionButton.Text = "Set Head Pos";
            SetHeadPositionButton.UseVisualStyleBackColor = false;
            SetHeadPositionButton.Click += SetHeadPositionButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(597, 390);
            Controls.Add(SetHeadPositionButton);
            Controls.Add(headPositionTextbox);
            Controls.Add(loadFSMButton);
            Controls.Add(newinstructionbttn);
            Controls.Add(savechangesbttn);
            Controls.Add(alphabettextbox);
            Controls.Add(acceptingstatetextbox);
            Controls.Add(currstatetextbox);
            Controls.Add(alphabetlabel);
            Controls.Add(acceptingstatelabel);
            Controls.Add(currstatelabel);
            Controls.Add(runbttn);
            Controls.Add(stepbttn);
            Controls.Add(savealphabetbttn);
            Controls.Add(stopbttn);
            Controls.Add(cleartapebttn);
            Controls.Add(tape14);
            Controls.Add(tape13);
            Controls.Add(tape12);
            Controls.Add(tape11);
            Controls.Add(tape10);
            Controls.Add(tape9);
            Controls.Add(tape8);
            Controls.Add(tape7);
            Controls.Add(tape5);
            Controls.Add(tape6);
            Controls.Add(tape4);
            Controls.Add(tape3);
            Controls.Add(tape2);
            Controls.Add(tape1);
            Controls.Add(LogOutButton);
            Controls.Add(FiniteStateButton);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            HelpButton = true;
            Name = "MainForm";
            Text = "Turing Machine";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Input;
        private DataGridViewTextBoxColumn StartState;
        private DataGridViewTextBoxColumn Output;
        private DataGridViewComboBoxColumn Movement;
        private DataGridViewTextBoxColumn EndState;
        private Panel panel1;
        private Button FiniteStateButton;
        private Button LogOutButton;
        private TextBox tape1;
        private TextBox tape2;
        private TextBox tape3;
        private TextBox tape4;
        private TextBox tape6;
        private TextBox tape5;
        private TextBox tape7;
        private TextBox tape8;
        private TextBox tape9;
        private TextBox tape10;
        private TextBox tape11;
        private TextBox tape12;
        private TextBox tape13;
        private TextBox tape14;
        private Button cleartapebttn;
        private Button stopbttn;
        private Button savealphabetbttn;
        private Button stepbttn;
        private Button runbttn;
        private Label currstatelabel;
        private Label acceptingstatelabel;
        private Label alphabetlabel;
        private TextBox currstatetextbox;
        private TextBox acceptingstatetextbox;
        private TextBox alphabettextbox;
        private Button savechangesbttn;
        private Button newinstructionbttn;
        private Button loadFSMButton;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox headPositionTextbox;
        private Button SetHeadPositionButton;
    }
}