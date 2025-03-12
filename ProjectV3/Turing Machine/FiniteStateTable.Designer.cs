namespace MajorProject
{
    partial class FiniteStateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Input = new DataGridViewTextBoxColumn();
            StartState = new DataGridViewTextBoxColumn();
            Output = new DataGridViewTextBoxColumn();
            Movement = new DataGridViewComboBoxColumn();
            EndState = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.FromArgb(168, 147, 118);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Input, StartState, Output, Movement, EndState });
            dataGridView1.GridColor = Color.FromArgb(64, 64, 64);
            dataGridView1.Location = new Point(-7, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(543, 400);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Input
            // 
            Input.Name = "Input";
            // 
            // StartState
            // 
            StartState.Name = "StartState";
            // 
            // Output
            // 
            Output.Name = "Output";
            // 
            // Movement
            // 
            Movement.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            Movement.HeaderText = "Movement";
            Movement.Items.AddRange(new object[] { ">", "<", "-" });
            Movement.MaxDropDownItems = 3;
            Movement.Name = "Movement";
            // 
            // EndState
            // 
            EndState.Name = "EndState";
            // 
            // FiniteStateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 399);
            Controls.Add(dataGridView1);
            Name = "FiniteStateForm";
            Text = "Finite State Table";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Input;
        private DataGridViewTextBoxColumn StartState;
        private DataGridViewTextBoxColumn Output;
        private DataGridViewComboBoxColumn Movement;
        private DataGridViewTextBoxColumn EndState;
        private Button testButton;
        private TextBox inputTextBox;
        private Label outputLabel;
    }
}
