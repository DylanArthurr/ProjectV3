namespace ProjectV3
{
    partial class StudentRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentRegister));
            StudentUserName = new TextBox();
            Password = new TextBox();
            LoginMessage = new Label();
            RegisterButton = new Button();
            QuitButton = new Button();
            mainMenu = new Button();
            SuspendLayout();
            // 
            // StudentUserName
            // 
            StudentUserName.BackColor = Color.FromArgb(242, 226, 203);
            StudentUserName.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StudentUserName.Location = new Point(297, 219);
            StudentUserName.Margin = new Padding(0);
            StudentUserName.Name = "StudentUserName";
            StudentUserName.Size = new Size(209, 35);
            StudentUserName.TabIndex = 2;
            StudentUserName.TextChanged += UserName_TextChanged;
            // 
            // Password
            // 
            Password.BackColor = Color.FromArgb(242, 226, 203);
            Password.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password.Location = new Point(297, 257);
            Password.Name = "Password";
            Password.Size = new Size(209, 35);
            Password.TabIndex = 3;
            Password.UseSystemPasswordChar = true;
            Password.TextChanged += Password_TextChanged;
            // 
            // LoginMessage
            // 
            LoginMessage.BackColor = Color.Transparent;
            LoginMessage.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginMessage.Location = new Point(306, 172);
            LoginMessage.Name = "LoginMessage";
            LoginMessage.Size = new Size(172, 36);
            LoginMessage.TabIndex = 6;
            LoginMessage.Text = "Student Register Page";
            LoginMessage.Click += LoginMessage_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.FromArgb(242, 226, 203);
            RegisterButton.BackgroundImage = (Image)resources.GetObject("RegisterButton.BackgroundImage");
            RegisterButton.BackgroundImageLayout = ImageLayout.None;
            RegisterButton.Location = new Point(329, 298);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(149, 23);
            RegisterButton.TabIndex = 4;
            RegisterButton.Text = "Accept";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // QuitButton
            // 
            QuitButton.BackColor = Color.FromArgb(242, 226, 203);
            QuitButton.Location = new Point(364, 354);
            QuitButton.Name = "QuitButton";
            QuitButton.Size = new Size(73, 21);
            QuitButton.TabIndex = 5;
            QuitButton.Text = "Quit";
            QuitButton.UseVisualStyleBackColor = false;
            QuitButton.Click += QuitButton_Click;
            // 
            // mainMenu
            // 
            mainMenu.BackColor = Color.FromArgb(242, 226, 203);
            mainMenu.Location = new Point(349, 327);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(104, 21);
            mainMenu.TabIndex = 14;
            mainMenu.Text = "Main  Menu";
            mainMenu.UseVisualStyleBackColor = false;
            mainMenu.Click += mainMenu_Click;
            // 
            // StudentRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(mainMenu);
            Controls.Add(LoginMessage);
            Controls.Add(QuitButton);
            Controls.Add(RegisterButton);
            Controls.Add(Password);
            Controls.Add(StudentUserName);
            Name = "StudentRegister";
            Text = "SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RegisterButton;
        private Button QuitButton;
        private TextBox StudentUserName;
        private TextBox Password;
        private Label LoginMessage;
        private Button mainMenu;
    }
}