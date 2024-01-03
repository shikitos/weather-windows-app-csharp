namespace WeatherApp
{
    partial class RegisterPage
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
            this.showLoginPageButton = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.inputPasswordRegister = new System.Windows.Forms.TextBox();
            this.inputUsernameRegister = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.registerButtonContainer = new WeatherApp.ButtonComponent();
            this.SuspendLayout();
            // 
            // showLoginPageButton
            // 
            this.showLoginPageButton.AutoSize = true;
            this.showLoginPageButton.Location = new System.Drawing.Point(215, 204);
            this.showLoginPageButton.Name = "showLoginPageButton";
            this.showLoginPageButton.Size = new System.Drawing.Size(40, 13);
            this.showLoginPageButton.TabIndex = 14;
            this.showLoginPageButton.TabStop = true;
            this.showLoginPageButton.Text = "Sign In";
            this.showLoginPageButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowLoginPageButton_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Already have an account?";
            // 
            // inputPasswordRegister
            // 
            this.inputPasswordRegister.Location = new System.Drawing.Point(42, 144);
            this.inputPasswordRegister.Name = "inputPasswordRegister";
            this.inputPasswordRegister.Size = new System.Drawing.Size(272, 20);
            this.inputPasswordRegister.TabIndex = 12;
            this.inputPasswordRegister.Text = "Password";
            this.inputPasswordRegister.UseSystemPasswordChar = true;
            // 
            // inputUsernameRegister
            // 
            this.inputUsernameRegister.Location = new System.Drawing.Point(42, 96);
            this.inputUsernameRegister.Name = "inputUsernameRegister";
            this.inputUsernameRegister.Size = new System.Drawing.Size(272, 20);
            this.inputUsernameRegister.TabIndex = 11;
            this.inputUsernameRegister.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sign Up";
            // 
            // registerButtonContainer
            // 
            this.registerButtonContainer.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(164)))), ((int)(((byte)(79)))));
            this.registerButtonContainer.ButtonName = "registerButton";
            this.registerButtonContainer.ButtonSize = new System.Drawing.Size(272, 43);
            this.registerButtonContainer.ButtonText = "Register";
            this.registerButtonContainer.Location = new System.Drawing.Point(42, 238);
            this.registerButtonContainer.Name = "registerButtonContainer";
            this.registerButtonContainer.Size = new System.Drawing.Size(272, 43);
            this.registerButtonContainer.TabIndex = 15;
            this.registerButtonContainer.ButtonClick += new System.EventHandler(this.RegisterButton_Click);
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.registerButtonContainer);
            this.Controls.Add(this.showLoginPageButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputPasswordRegister);
            this.Controls.Add(this.inputUsernameRegister);
            this.Controls.Add(this.label1);
            this.Name = "RegisterPage";
            this.Size = new System.Drawing.Size(350, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel showLoginPageButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputPasswordRegister;
        private System.Windows.Forms.TextBox inputUsernameRegister;
        private System.Windows.Forms.Label label1;
        private ButtonComponent registerButtonContainer;
    }
}
