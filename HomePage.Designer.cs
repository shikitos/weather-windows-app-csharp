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
            this.input = new System.Windows.Forms.TextBox();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.labelsGroupPanel = new System.Windows.Forms.Panel();
            this.mottoLabel = new System.Windows.Forms.Label();
            this.outputField = new System.Windows.Forms.Label();
            this.buttonComponent1 = new WeatherApp.ButtonComponent();
            this.labelsGroupPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.Location = new System.Drawing.Point(6, 105);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(269, 30);
            this.input.TabIndex = 1;
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.BackColor = System.Drawing.Color.Transparent;
            this.temperatureLabel.Font = new System.Drawing.Font("Algerian", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatureLabel.ForeColor = System.Drawing.Color.White;
            this.temperatureLabel.Location = new System.Drawing.Point(-1, 41);
            this.temperatureLabel.MinimumSize = new System.Drawing.Size(490, 0);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(490, 56);
            this.temperatureLabel.TabIndex = 3;
            this.temperatureLabel.Text = "5 C";
            this.temperatureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // conditionLabel
            // 
            this.conditionLabel.AutoSize = true;
            this.conditionLabel.BackColor = System.Drawing.Color.Transparent;
            this.conditionLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionLabel.ForeColor = System.Drawing.Color.White;
            this.conditionLabel.Location = new System.Drawing.Point(-1, 237);
            this.conditionLabel.MinimumSize = new System.Drawing.Size(490, 0);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(490, 18);
            this.conditionLabel.TabIndex = 4;
            this.conditionLabel.Text = "Conditions";
            this.conditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cityLabel
            // 
            this.cityLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cityLabel.AutoEllipsis = true;
            this.cityLabel.AutoSize = true;
            this.cityLabel.BackColor = System.Drawing.Color.Transparent;
            this.cityLabel.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.ForeColor = System.Drawing.Color.White;
            this.cityLabel.Location = new System.Drawing.Point(-5, 1);
            this.cityLabel.MinimumSize = new System.Drawing.Size(500, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(500, 23);
            this.cityLabel.TabIndex = 5;
            this.cityLabel.Text = "City";
            this.cityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelsGroupPanel
            // 
            this.labelsGroupPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelsGroupPanel.BackColor = System.Drawing.Color.Transparent;
            this.labelsGroupPanel.Controls.Add(this.mottoLabel);
            this.labelsGroupPanel.Controls.Add(this.temperatureLabel);
            this.labelsGroupPanel.Controls.Add(this.cityLabel);
            this.labelsGroupPanel.Controls.Add(this.conditionLabel);
            this.labelsGroupPanel.Location = new System.Drawing.Point(6, 189);
            this.labelsGroupPanel.Name = "labelsGroupPanel";
            this.labelsGroupPanel.Size = new System.Drawing.Size(490, 608);
            this.labelsGroupPanel.TabIndex = 6;
            // 
            // mottoLabel
            // 
            this.mottoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mottoLabel.AutoEllipsis = true;
            this.mottoLabel.AutoSize = true;
            this.mottoLabel.BackColor = System.Drawing.Color.Gray;
            this.mottoLabel.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mottoLabel.ForeColor = System.Drawing.Color.White;
            this.mottoLabel.Location = new System.Drawing.Point(1, 588);
            this.mottoLabel.MinimumSize = new System.Drawing.Size(490, 20);
            this.mottoLabel.Name = "mottoLabel";
            this.mottoLabel.Size = new System.Drawing.Size(490, 20);
            this.mottoLabel.TabIndex = 6;
            this.mottoLabel.Text = "Motto";
            this.mottoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputField
            // 
            this.outputField.AutoEllipsis = true;
            this.outputField.AutoSize = true;
            this.outputField.BackColor = System.Drawing.Color.Transparent;
            this.outputField.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputField.ForeColor = System.Drawing.Color.Red;
            this.outputField.Location = new System.Drawing.Point(3, 138);
            this.outputField.MaximumSize = new System.Drawing.Size(500, 0);
            this.outputField.Name = "outputField";
            this.outputField.Size = new System.Drawing.Size(50, 17);
            this.outputField.TabIndex = 8;
            this.outputField.Text = "label1";
            // 
            // buttonComponent1
            // 
            this.buttonComponent1.BackColor = System.Drawing.Color.Transparent;
            this.buttonComponent1.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.buttonComponent1.ButtonName = "buttonComponent";
            this.buttonComponent1.ButtonSize = new System.Drawing.Size(204, 30);
            this.buttonComponent1.ButtonText = "Search";
            this.buttonComponent1.ButtonTextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonComponent1.ButtonTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonComponent1.Location = new System.Drawing.Point(293, 105);
            this.buttonComponent1.Name = "buttonComponent1";
            this.buttonComponent1.Size = new System.Drawing.Size(204, 30);
            this.buttonComponent1.TabIndex = 7;
            this.buttonComponent1.ButtonClick += new System.EventHandler(this.SubmitButton_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.outputField);
            this.Controls.Add(this.buttonComponent1);
            this.Controls.Add(this.labelsGroupPanel);
            this.Controls.Add(this.input);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(500, 800);
            this.labelsGroupPanel.ResumeLayout(false);
            this.labelsGroupPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Panel labelsGroupPanel;
        private ButtonComponent buttonComponent1;
        private System.Windows.Forms.Label outputField;
        private System.Windows.Forms.Label mottoLabel;
    }
}
