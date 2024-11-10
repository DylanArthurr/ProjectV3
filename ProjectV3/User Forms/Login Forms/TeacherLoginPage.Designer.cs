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
            TextBox TeacherUserName;
            TextBox TeacherPassword;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherLoginPage));
            LoginButton = new Button();
            QuitButton = new Button();
            LoginMessage = new Label();
            TeacherUserName = new TextBox();
            TeacherPassword = new TextBox();
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
            // TeacherUserName
            // 
            TeacherUserName.BackColor = Color.FromArgb(242, 226, 203);
            TeacherUserName.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeacherUserName.Location = new Point(296, 202);
            TeacherUserName.Margin = new Padding(0);
            TeacherUserName.Name = "TeacherUserName";
            TeacherUserName.Size = new Size(209, 35);
            TeacherUserName.TabIndex = 3;
            TeacherUserName.Text = "UserName";
            TeacherUserName.TextChanged += TeacherUserName_TextChanged;
            // 
            // TeacherPassword
            // 
            TeacherPassword.BackColor = Color.FromArgb(242, 226, 203);
            TeacherPassword.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeacherPassword.Location = new Point(296, 262);
            TeacherPassword.Name = "TeacherPassword";
            TeacherPassword.Size = new Size(209, 35);
            TeacherPassword.TabIndex = 4;
            TeacherPassword.Text = "Password";
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(242, 226, 203);
            LoginButton.Location = new Point(342, 314);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(131, 23);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // QuitButton
            // 
            QuitButton.BackColor = Color.FromArgb(242, 226, 203);
            QuitButton.Location = new Point(371, 343);
            QuitButton.Name = "QuitButton";
            QuitButton.Size = new Size(73, 21);
            QuitButton.TabIndex = 6;
            QuitButton.Text = "Quit";
            QuitButton.UseVisualStyleBackColor = false;
            QuitButton.Click += QuitButton_Click;
            // 
            // TeacherLoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(QuitButton);
            Controls.Add(LoginButton);
            Controls.Add(TeacherPassword);
            Controls.Add(TeacherUserName);
            Controls.Add(LoginMessage);
            Name = "TeacherLoginPage";
            Text = "TeacherLoginPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        private Button QuitButton;
    }
}