namespace WeatherApp
{
    partial class HomePage
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
            this.buttonComponent1 = new WeatherApp.ButtonComponent();
            this.input = new System.Windows.Forms.TextBox();
            this.outputField = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonComponent1
            // 
            this.buttonComponent1.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(164)))), ((int)(((byte)(79)))));
            this.buttonComponent1.ButtonName = "buttonComponent";
            this.buttonComponent1.ButtonSize = new System.Drawing.Size(89, 34);
            this.buttonComponent1.ButtonText = "Button";
            this.buttonComponent1.Location = new System.Drawing.Point(268, 96);
            this.buttonComponent1.Name = "buttonComponent1";
            this.buttonComponent1.Size = new System.Drawing.Size(93, 39);
            this.buttonComponent1.TabIndex = 0;
            this.buttonComponent1.ButtonClick += new System.EventHandler(this.SubmitButton_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(89, 105);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(157, 20);
            this.input.TabIndex = 1;
            // 
            // outputField
            // 
            this.outputField.AutoSize = true;
            this.outputField.Location = new System.Drawing.Point(89, 158);
            this.outputField.Name = "outputField";
            this.outputField.Size = new System.Drawing.Size(43, 13);
            this.outputField.TabIndex = 2;
            this.outputField.Text = "Result: ";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.outputField);
            this.Controls.Add(this.input);
            this.Controls.Add(this.buttonComponent1);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(450, 800);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonComponent buttonComponent1;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label outputField;
    }
}
