namespace ProjectV3
{
    partial class TeacherLoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherLoginPage));
            QuitButton = new Button();
            LoginButton = new Button();
            TeacherPassw = new TextBox();
            TeacherNamee = new TextBox();
            mainMenu = new Button();
            LoginMessage = new Label();
            SuspendLayout();
            // 
            // LoginMessage
            // 
            LoginMessage.BackColor = Color.Transparent;
            LoginMessage.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginMessage.Location = new Point(293, 173);
            LoginMessage.Name = "LoginMessage";
            LoginMessage.Size = new Size(209, 36);
            LoginMessage.TabIndex = 1;
            LoginMessage.Text = "Teacher Login Page";
            // 
            // QuitButton
            // 
            QuitButton.BackColor = Color.FromArgb(242, 226, 203);
            QuitButton.Location = new Point(362, 358);
            QuitButton.Name = "QuitButton";
            QuitButton.Size = new Size(73, 21);
            QuitButton.TabIndex = 6;
            QuitButton.Text = "Quit";
            QuitButton.UseVisualStyleBackColor = false;
            QuitButton.Click += QuitButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(242, 226, 203);
            LoginButton.Location = new Point(334, 302);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(131, 23);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // TeacherPassw
            // 
            TeacherPassw.BackColor = Color.FromArgb(242, 226, 203);
            TeacherPassw.Font = new Font("Segoe UI", 18F);
            TeacherPassw.Location = new Point(293, 257);
            TeacherPassw.Name = "TeacherPassw";
            TeacherPassw.Size = new Size(209, 39);
            TeacherPassw.TabIndex = 8;
            TeacherPassw.UseSystemPasswordChar = true;
            TeacherPassw.TextChanged += TeacherPassw_TextChanged;
            // 
            // TeacherNamee
            // 
            TeacherNamee.BackColor = Color.FromArgb(242, 226, 203);
            TeacherNamee.Font = new Font("Segoe UI", 18F);
            TeacherNamee.Location = new Point(293, 212);
            TeacherNamee.Name = "TeacherNamee";
            TeacherNamee.Size = new Size(209, 39);
            TeacherNamee.TabIndex = 7;
            TeacherNamee.TextChanged += TeacherName_TextChanged;
            // 
            // mainMenu
            // 
            mainMenu.BackColor = Color.FromArgb(242, 226, 203);
            mainMenu.Location = new Point(347, 331);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(104, 21);
            mainMenu.TabIndex = 15;
            mainMenu.Text = "Main  Menu";
            mainMenu.UseVisualStyleBackColor = false;
            mainMenu.Click += mainMenu_Click;
            // 
            // TeacherLoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(mainMenu);
            Controls.Add(TeacherPassw);
            Controls.Add(TeacherNamee);
            Controls.Add(QuitButton);
            Controls.Add(LoginButton);
            Controls.Add(LoginMessage);
            Name = "TeacherLoginPage";
            Text = "TeacherLoginPage";
            Load += TeacherLoginPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button QuitButton;
        private Button LoginButton;
        private TextBox TeacherPassw;
        private TextBox TeacherNamee;
        private Button mainMenu;
    }
}