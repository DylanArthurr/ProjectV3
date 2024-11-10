namespace ProjectV3
{
    partial class FrontPage
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
            Label LoginMessage;
            Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrontPage));
            TeacherLoginForm = new Button();
            StudentLoginForm = new Button();
            QuitButton = new Button();
            button1 = new Button();
            button2 = new Button();
            LoginMessage = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // LoginMessage
            // 
            LoginMessage.BackColor = Color.Transparent;
            LoginMessage.Font = new Font("Viner Hand ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginMessage.Location = new Point(351, 160);
            LoginMessage.Name = "LoginMessage";
            LoginMessage.Size = new Size(103, 33);
            LoginMessage.TabIndex = 7;
            LoginMessage.Text = "Welcome";
            LoginMessage.Click += LoginMessage_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Viner Hand ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(298, 193);
            label1.Name = "label1";
            label1.Size = new Size(199, 33);
            label1.TabIndex = 8;
            label1.Text = "Choose From Below";
            // 
            // TeacherLoginForm
            // 
            TeacherLoginForm.BackColor = Color.FromArgb(242, 226, 203);
            TeacherLoginForm.Location = new Point(298, 229);
            TeacherLoginForm.Name = "TeacherLoginForm";
            TeacherLoginForm.Size = new Size(200, 30);
            TeacherLoginForm.TabIndex = 9;
            TeacherLoginForm.Text = "Teacher Login";
            TeacherLoginForm.UseVisualStyleBackColor = false;
            TeacherLoginForm.Click += TeacherLoginForm_Click;
            // 
            // StudentLoginForm
            // 
            StudentLoginForm.BackColor = Color.FromArgb(242, 226, 203);
            StudentLoginForm.Location = new Point(298, 262);
            StudentLoginForm.Name = "StudentLoginForm";
            StudentLoginForm.Size = new Size(200, 30);
            StudentLoginForm.TabIndex = 10;
            StudentLoginForm.Text = "Student Login";
            StudentLoginForm.UseVisualStyleBackColor = false;
            StudentLoginForm.Click += StudentLoginForm_Click;
            // 
            // QuitButton
            // 
            QuitButton.BackColor = Color.FromArgb(242, 226, 203);
            QuitButton.Location = new Point(351, 364);
            QuitButton.Name = "QuitButton";
            QuitButton.Size = new Size(103, 21);
            QuitButton.TabIndex = 11;
            QuitButton.Text = "Quit";
            QuitButton.UseVisualStyleBackColor = false;
            QuitButton.Click += QuitButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(242, 226, 203);
            button1.Location = new Point(298, 296);
            button1.Name = "button1";
            button1.Size = new Size(200, 30);
            button1.TabIndex = 12;
            button1.Text = "Teacher Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(242, 226, 203);
            button2.Location = new Point(298, 328);
            button2.Name = "button2";
            button2.Size = new Size(200, 30);
            button2.TabIndex = 13;
            button2.Text = "Student Register";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FrontPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(QuitButton);
            Controls.Add(StudentLoginForm);
            Controls.Add(TeacherLoginForm);
            Controls.Add(label1);
            Controls.Add(LoginMessage);
            Name = "FrontPage";
            Text = "FrontPage";
            ResumeLayout(false);
        }

        #endregion

        private Button TeacherLoginForm;
        private Button StudentLoginForm;
        private Button QuitButton;
        private Button button1;
        private Button button2;
    }
}