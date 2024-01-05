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
            this.showLoginPageButton.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showLoginPageButton.Location = new System.Drawing.Point(260, 204);
            this.showLoginPageButton.Name = "showLoginPageButton";
            this.showLoginPageButton.Size = new System.Drawing.Size(53, 15);
            this.showLoginPageButton.TabIndex = 14;
            this.showLoginPageButton.TabStop = true;
            this.showLoginPageButton.Text = "Sign In";
            this.showLoginPageButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowLoginPageButton_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 14);
            this.label2.TabIndex = 13;
            this.label2.Text = "Already have an account?";
            // 
            // inputPasswordRegister
            // 
            this.inputPasswordRegister.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPasswordRegister.Location = new System.Drawing.Point(38, 144);
            this.inputPasswordRegister.Name = "inputPasswordRegister";
            this.inputPasswordRegister.Size = new System.Drawing.Size(275, 20);
            this.inputPasswordRegister.TabIndex = 12;
            this.inputPasswordRegister.Text = "Password";
            this.inputPasswordRegister.UseSystemPasswordChar = true;
            // 
            // inputUsernameRegister
            // 
            this.inputUsernameRegister.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputUsernameRegister.Location = new System.Drawing.Point(38, 96);
            this.inputUsernameRegister.Name = "inputUsernameRegister";
            this.inputUsernameRegister.Size = new System.Drawing.Size(275, 20);
            this.inputUsernameRegister.TabIndex = 11;
            this.inputUsernameRegister.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 49);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sign Up";
            // 
            // registerButtonContainer
            // 
            this.registerButtonContainer.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.registerButtonContainer.ButtonName = "registerButton";
            this.registerButtonContainer.ButtonSize = new System.Drawing.Size(275, 40);
            this.registerButtonContainer.ButtonText = "Register";
            this.registerButtonContainer.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.registerButtonContainer.ButtonTextFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.registerButtonContainer.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButtonContainer.Location = new System.Drawing.Point(38, 245);
            this.registerButtonContainer.Name = "registerButtonContainer";
            this.registerButtonContainer.Size = new System.Drawing.Size(275, 40);
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
