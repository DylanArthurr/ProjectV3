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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            FiniteStateButton = new Button();
            Tape = new RichTextBox();
            pictureBox1 = new PictureBox();
            LogOutButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // Tape
            // 
            Tape.BackColor = Color.Silver;
            Tape.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tape.ForeColor = SystemColors.MenuBar;
            Tape.Location = new Point(20, 123);
            Tape.Name = "Tape";
            Tape.ScrollBars = RichTextBoxScrollBars.ForcedHorizontal;
            Tape.Size = new Size(559, 37);
            Tape.TabIndex = 4;
            Tape.Text = "";
            Tape.TextChanged += Tape_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Location = new Point(20, 166);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(13, 25);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // LogOutButton
            // 
            LogOutButton.BackColor = Color.FromArgb(168, 147, 118);
            LogOutButton.FlatStyle = FlatStyle.Popup;
            LogOutButton.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOutButton.ForeColor = Color.Transparent;
            LogOutButton.Location = new Point(471, 324);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(114, 45);
            LogOutButton.TabIndex = 6;
            LogOutButton.Text = "Logout";
            LogOutButton.UseVisualStyleBackColor = false;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(597, 390);
            Controls.Add(LogOutButton);
            Controls.Add(pictureBox1);
            Controls.Add(Tape);
            Controls.Add(FiniteStateButton);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            HelpButton = true;
            Name = "MainForm";
            Text = "Turing Machine";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Input;
        private DataGridViewTextBoxColumn StartState;
        private DataGridViewTextBoxColumn Output;
        private DataGridViewComboBoxColumn Movement;
        private DataGridViewTextBoxColumn EndState;
        private Panel panel1;
        private Button button1;
        private Button FiniteStateButton;
        private RichTextBox Tape;
        private PictureBox pictureBox1;
        private Button LogOutButton;
    }
}
