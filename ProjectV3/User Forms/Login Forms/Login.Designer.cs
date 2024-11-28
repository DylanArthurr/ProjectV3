namespace MajorProject
{
    public partial class StudnetLoginPage : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudnetLoginPage));
            LoginButton = new Button();
            QuitButton = new Button();
            StudentLoginTextBox = new TextBox();
            StudentLoginPassword = new TextBox();
            mainMenu = new Button();
            LoginMessage = new Label();
            SuspendLayout();
            // 
            // LoginMessage
            // 
            LoginMessage.BackColor = Color.Transparent;
            LoginMessage.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginMessage.Location = new Point(240, 183);
            LoginMessage.Name = "LoginMessage";
            LoginMessage.Size = new Size(209, 36);
            LoginMessage.TabIndex = 0;
            LoginMessage.Text = "Student Login Page";
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(242, 226, 203);
            LoginButton.Location = new Point(277, 318);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(139, 23);
            LoginButton.TabIndex = 3;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // QuitButton
            // 
            QuitButton.BackColor = Color.FromArgb(242, 226, 203);
            QuitButton.Location = new Point(316, 374);
            QuitButton.Name = "QuitButton";
            QuitButton.Size = new Size(73, 21);
            QuitButton.TabIndex = 4;
            QuitButton.Text = "Quit";
            QuitButton.UseVisualStyleBackColor = false;
            QuitButton.Click += QuitButton_Click_1;
            // 
            // StudentLoginTextBox
            // 
            StudentLoginTextBox.BackColor = Color.FromArgb(242, 226, 203);
            StudentLoginTextBox.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StudentLoginTextBox.Location = new Point(240, 222);
            StudentLoginTextBox.Name = "StudentLoginTextBox";
            StudentLoginTextBox.Size = new Size(209, 35);
            StudentLoginTextBox.TabIndex = 6;
            StudentLoginTextBox.Text = "UserName";
            StudentLoginTextBox.TextChanged += StudentLoginTextBox_TextChanged;
            // 
            // StudentLoginPassword
            // 
            StudentLoginPassword.BackColor = Color.FromArgb(242, 226, 203);
            StudentLoginPassword.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StudentLoginPassword.Location = new Point(240, 277);
            StudentLoginPassword.Name = "StudentLoginPassword";
            StudentLoginPassword.Size = new Size(209, 35);
            StudentLoginPassword.TabIndex = 7;
            StudentLoginPassword.Text = "Password";
            StudentLoginPassword.TextChanged += StudentLoginPassword_TextChanged;
            // 
            // mainMenu
            // 
            mainMenu.BackColor = Color.FromArgb(242, 226, 203);
            mainMenu.Location = new Point(296, 347);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(104, 21);
            mainMenu.TabIndex = 16;
            mainMenu.Text = "Main  Menu";
            mainMenu.UseVisualStyleBackColor = false;
            mainMenu.Click += mainMenu_Click;
            // 
            // StudnetLoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(698, 450);
            Controls.Add(mainMenu);
            Controls.Add(StudentLoginPassword);
            Controls.Add(StudentLoginTextBox);
            Controls.Add(QuitButton);
            Controls.Add(LoginButton);
            Controls.Add(LoginMessage);
            Name = "StudnetLoginPage";
            Text = "Quit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        private Button QuitButton;
        private TextBox StudentLoginTextBox;
        private TextBox StudentLoginPassword;
        private Button mainMenu;
    }
}