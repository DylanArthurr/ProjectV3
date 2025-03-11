namespace ProjectV3.User_Forms.Login_Forms
{
    partial class TeacherRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherRegister));
            TeacherPassw = new TextBox();
            LoginBttn = new Button();
            QuitButton = new Button();
            TeacherNa = new TextBox();
            mainMenu = new Button();
            LoginMessage = new Label();
            SuspendLayout();
            // 
            // LoginMessage
            // 
            LoginMessage.BackColor = Color.Transparent;
            LoginMessage.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginMessage.Location = new Point(276, 178);
            LoginMessage.Name = "LoginMessage";
            LoginMessage.Size = new Size(230, 36);
            LoginMessage.TabIndex = 2;
            LoginMessage.Text = "Teacher Register Page";
            // 
            // TeacherPassw
            // 
            TeacherPassw.BackColor = Color.FromArgb(242, 226, 203);
            TeacherPassw.Font = new Font("Segoe UI", 18F);
            TeacherPassw.Location = new Point(294, 251);
            TeacherPassw.Name = "TeacherPassw";
            TeacherPassw.Size = new Size(212, 39);
            TeacherPassw.TabIndex = 9;
            TeacherPassw.UseSystemPasswordChar = true;
            TeacherPassw.TextChanged += TeacherPass_TextChanged;
            // 
            // LoginBttn
            // 
            LoginBttn.BackColor = Color.FromArgb(242, 226, 203);
            LoginBttn.Location = new Point(333, 296);
            LoginBttn.Name = "LoginBttn";
            LoginBttn.Size = new Size(131, 23);
            LoginBttn.TabIndex = 10;
            LoginBttn.Text = "Accept";
            LoginBttn.UseVisualStyleBackColor = false;
            LoginBttn.Click += LoginBttn_Click;
            // 
            // QuitButton
            // 
            QuitButton.BackColor = Color.FromArgb(242, 226, 203);
            QuitButton.Location = new Point(363, 352);
            QuitButton.Name = "QuitButton";
            QuitButton.Size = new Size(73, 21);
            QuitButton.TabIndex = 11;
            QuitButton.Text = "Quit";
            QuitButton.UseVisualStyleBackColor = false;
            QuitButton.Click += QuitButton_Click;
            // 
            // TeacherNa
            // 
            TeacherNa.BackColor = Color.FromArgb(242, 226, 203);
            TeacherNa.Font = new Font("Segoe UI", 18F);
            TeacherNa.Location = new Point(294, 206);
            TeacherNa.Name = "TeacherNa";
            TeacherNa.Size = new Size(212, 39);
            TeacherNa.TabIndex = 12;
            // 
            // mainMenu
            // 
            mainMenu.BackColor = Color.FromArgb(242, 226, 203);
            mainMenu.Location = new Point(349, 325);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(104, 21);
            mainMenu.TabIndex = 13;
            mainMenu.Text = "Main  Menu";
            mainMenu.UseVisualStyleBackColor = false;
            mainMenu.Click += mainMenu_Click;
            // 
            // TeacherRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(mainMenu);
            Controls.Add(TeacherNa);
            Controls.Add(QuitButton);
            Controls.Add(LoginBttn);
            Controls.Add(TeacherPassw);
            Controls.Add(LoginMessage);
            Name = "TeacherRegister";
            Text = "TeacherRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TeacherPass;
        private Button LoginBttn;
        private Button QuitButton;
        private TextBox TeacherPassw;
        private TextBox TeacherNa;
        private Button mainMenu;
    }
}