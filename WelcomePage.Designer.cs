namespace WeatherApp
{
    partial class WelcomePage
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.registerLink = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStartContainer = new WeatherApp.ButtonComponent();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "OR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = ", to be able to see history";
            // 
            // registerLink
            // 
            this.registerLink.AutoSize = true;
            this.registerLink.Location = new System.Drawing.Point(225, 22);
            this.registerLink.Name = "registerLink";
            this.registerLink.Size = new System.Drawing.Size(41, 13);
            this.registerLink.TabIndex = 11;
            this.registerLink.TabStop = true;
            this.registerLink.Text = "register";
            this.registerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLink_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "To start using Weather application, you can ";
            // 
            // buttonStartContainer
            // 
            this.buttonStartContainer.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(164)))), ((int)(((byte)(79)))));
            this.buttonStartContainer.ButtonName = "buttonStart";
            this.buttonStartContainer.ButtonSize = new System.Drawing.Size(370, 39);
            this.buttonStartContainer.ButtonText = "Start without loginning in";
            this.buttonStartContainer.Location = new System.Drawing.Point(18, 71);
            this.buttonStartContainer.Name = "buttonStartContainer";
            this.buttonStartContainer.Size = new System.Drawing.Size(370, 39);
            this.buttonStartContainer.TabIndex = 14;
            this.buttonStartContainer.ButtonClick += new System.EventHandler(this.ButtonStart_Click);
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonStartContainer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.registerLink);
            this.Controls.Add(this.label1);
            this.Name = "WelcomePage";
            this.Size = new System.Drawing.Size(400, 125);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonComponent buttonComponent1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel registerLink;
        private System.Windows.Forms.Label label1;
        private ButtonComponent buttonStartContainer;
    }
}
