﻿namespace ProjectV3
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
            SuspendLayout();
            // 
            // StudentUserName
            // 
            StudentUserName.BackColor = Color.FromArgb(242, 226, 203);
            StudentUserName.Font = new Font("Viner Hand ITC", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StudentUserName.Location = new Point(306, 238);
            StudentUserName.Margin = new Padding(0);
            StudentUserName.Name = "StudentUserName";
            StudentUserName.Size = new Size(209, 46);
            StudentUserName.TabIndex = 2;
            StudentUserName.Text = "UserName";
            StudentUserName.TextChanged += UserName_TextChanged;
            // 
            // Password
            // 
            Password.BackColor = Color.FromArgb(242, 226, 203);
            Password.Font = new Font("Viner Hand ITC", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password.Location = new Point(306, 287);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(209, 46);
            Password.TabIndex = 3;
            // 
            // LoginMessage
            // 
            LoginMessage.BackColor = Color.Transparent;
            LoginMessage.Font = new Font("Viner Hand ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginMessage.Location = new Point(306, 183);
            LoginMessage.Name = "LoginMessage";
            LoginMessage.Size = new Size(209, 36);
            LoginMessage.TabIndex = 6;
            LoginMessage.Text = "Student Register Page";
            LoginMessage.Click += LoginMessage_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.FromArgb(242, 226, 203);
            RegisterButton.BackgroundImage = (Image)resources.GetObject("RegisterButton.BackgroundImage");
            RegisterButton.BackgroundImageLayout = ImageLayout.None;
            RegisterButton.Location = new Point(350, 339);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(107, 23);
            RegisterButton.TabIndex = 4;
            RegisterButton.Text = "Accept";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // QuitButton
            // 
            QuitButton.BackColor = Color.FromArgb(242, 226, 203);
            QuitButton.Location = new Point(367, 368);
            QuitButton.Name = "QuitButton";
            QuitButton.Size = new Size(73, 21);
            QuitButton.TabIndex = 5;
            QuitButton.Text = "Quit";
            QuitButton.UseVisualStyleBackColor = false;
            QuitButton.Click += QuitButton_Click;
            // 
            // StudentRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
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
    }
}