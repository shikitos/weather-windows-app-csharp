namespace WeatherApp
{
    partial class HeaderComponent
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
            this.logoutButton = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.authButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.logoutButton.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(425, 1);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 30);
            this.logoutButton.TabIndex = 17;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Visible = false;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(325, 7);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(0, 17);
            this.userNameLabel.MaximumSize = new System.Drawing.Size(100, 17);
            this.userNameLabel.TabIndex = 16;
            this.userNameLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // authButton
            // 
            this.authButton.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authButton.Location = new System.Drawing.Point(425, 1);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(75, 30);
            this.authButton.TabIndex = 15;
            this.authButton.Text = "Sign In";
            this.authButton.UseVisualStyleBackColor = true;
            this.authButton.Click += new System.EventHandler(this.authButton_Click_1);
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.LinkColor = System.Drawing.Color.Black;
            this.backButton.Location = new System.Drawing.Point(3, 9);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(48, 16);
            this.backButton.TabIndex = 18;
            this.backButton.TabStop = true;
            this.backButton.Text = "< Back";
            this.backButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Back_Clicked);
            // 
            // HeaderComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.authButton);
            this.Name = "HeaderComponent";
            this.Size = new System.Drawing.Size(500, 34);
            this.Load += new System.EventHandler(this.HeaderComponent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Button authButton;
        private System.Windows.Forms.LinkLabel backButton;
    }
}
