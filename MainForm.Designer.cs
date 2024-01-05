namespace WeatherApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.registerPage1 = new WeatherApp.RegisterPage();
            this.loginPage1 = new WeatherApp.LoginPage();
            this.homePage1 = new WeatherApp.HomePage();
            this.headerComponent1 = new WeatherApp.HeaderComponent();
            this.welcomePage1 = new WeatherApp.WelcomePage();
            this.SuspendLayout();
            // 
            // registerPage1
            // 
            this.registerPage1.Location = new System.Drawing.Point(77, 305);
            this.registerPage1.Name = "registerPage1";
            this.registerPage1.Size = new System.Drawing.Size(350, 300);
            this.registerPage1.TabIndex = 3;
            this.registerPage1.Visible = false;
            // 
            // loginPage1
            // 
            this.loginPage1.Location = new System.Drawing.Point(77, 305);
            this.loginPage1.Name = "loginPage1";
            this.loginPage1.Size = new System.Drawing.Size(350, 300);
            this.loginPage1.TabIndex = 2;
            this.loginPage1.Visible = false;
            // 
            // homePage1
            // 
            this.homePage1.Location = new System.Drawing.Point(0, 37);
            this.homePage1.Name = "homePage1";
            this.homePage1.Size = new System.Drawing.Size(505, 875);
            this.homePage1.TabIndex = 5;
            this.homePage1.Visible = false;
            // 
            // headerComponent1
            // 
            this.headerComponent1.AutoSize = true;
            this.headerComponent1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.headerComponent1.Location = new System.Drawing.Point(0, 0);
            this.headerComponent1.Name = "headerComponent1";
            this.headerComponent1.Size = new System.Drawing.Size(505, 31);
            this.headerComponent1.TabIndex = 6;
            // 
            // welcomePage1
            // 
            this.welcomePage1.Location = new System.Drawing.Point(12, 393);
            this.welcomePage1.Name = "welcomePage1";
            this.welcomePage1.Size = new System.Drawing.Size(480, 125);
            this.welcomePage1.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 911);
            this.Controls.Add(this.welcomePage1);
            this.Controls.Add(this.headerComponent1);
            this.Controls.Add(this.registerPage1);
            this.Controls.Add(this.loginPage1);
            this.Controls.Add(this.homePage1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RegisterPage registerPage1;
        private LoginPage loginPage1;
        private HomePage homePage1;
        private HeaderComponent headerComponent1;
        private WelcomePage welcomePage1;
    }
}