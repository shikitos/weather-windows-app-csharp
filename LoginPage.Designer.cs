namespace WeatherApp
{
    partial class LoginPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.showRegisterFormButton = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.inputPasswordLogin = new System.Windows.Forms.TextBox();
            this.inputUsernameLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logginButtonContainer = new WeatherApp.ButtonComponent();
            this.SuspendLayout();
            // 
            // showRegisterFormButton
            // 
            this.showRegisterFormButton.AutoSize = true;
            this.showRegisterFormButton.Location = new System.Drawing.Point(218, 201);
            this.showRegisterFormButton.Name = "showRegisterFormButton";
            this.showRegisterFormButton.Size = new System.Drawing.Size(45, 13);
            this.showRegisterFormButton.TabIndex = 9;
            this.showRegisterFormButton.TabStop = true;
            this.showRegisterFormButton.Text = "Sign Up";
            this.showRegisterFormButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowRegisterFormButton_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Don\'t have an account?";
            // 
            // inputPasswordLogin
            // 
            this.inputPasswordLogin.Location = new System.Drawing.Point(45, 141);
            this.inputPasswordLogin.Name = "inputPasswordLogin";
            this.inputPasswordLogin.Size = new System.Drawing.Size(272, 20);
            this.inputPasswordLogin.TabIndex = 7;
            this.inputPasswordLogin.Text = "Password";
            this.inputPasswordLogin.UseSystemPasswordChar = true;
            // 
            // inputUsernameLogin
            // 
            this.inputUsernameLogin.Location = new System.Drawing.Point(45, 93);
            this.inputUsernameLogin.Name = "inputUsernameLogin";
            this.inputUsernameLogin.Size = new System.Drawing.Size(272, 20);
            this.inputUsernameLogin.TabIndex = 6;
            this.inputUsernameLogin.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login";
            // 
            // logginButtonContainer
            // 
            this.logginButtonContainer.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(164)))), ((int)(((byte)(79)))));
            this.logginButtonContainer.ButtonName = "logginButton";
            this.logginButtonContainer.ButtonSize = new System.Drawing.Size(272, 39);
            this.logginButtonContainer.ButtonText = "Sign In";
            this.logginButtonContainer.Location = new System.Drawing.Point(45, 241);
            this.logginButtonContainer.Name = "logginButtonContainer";
            this.logginButtonContainer.Size = new System.Drawing.Size(272, 39);
            this.logginButtonContainer.TabIndex = 10;
            this.logginButtonContainer.ButtonClick += new System.EventHandler(this.LogginButtonContainer_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.logginButtonContainer);
            this.Controls.Add(this.showRegisterFormButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputPasswordLogin);
            this.Controls.Add(this.inputUsernameLogin);
            this.Controls.Add(this.label1);
            this.Name = "LoginPage";
            this.Size = new System.Drawing.Size(350, 300);
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel showRegisterFormButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputPasswordLogin;
        private System.Windows.Forms.TextBox inputUsernameLogin;
        private System.Windows.Forms.Label label1;
        private ButtonComponent logginButtonContainer;
    }
}
