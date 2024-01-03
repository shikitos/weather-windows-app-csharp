namespace WeatherApp
{
    partial class ButtonComponent
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
            this.buttonComponent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonComponent
            // 
            this.buttonComponent.Location = new System.Drawing.Point(3, 3);
            this.buttonComponent.Name = "buttonComponent";
            this.buttonComponent.Size = new System.Drawing.Size(89, 34);
            this.buttonComponent.TabIndex = 0;
            this.buttonComponent.Text = "Button";
            this.buttonComponent.UseVisualStyleBackColor = true;
            this.buttonComponent.Click += new System.EventHandler(this.buttonComponent_Click);
            // 
            // CustomButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonComponent);
            this.Name = "CustomButton";
            this.Size = new System.Drawing.Size(93, 39);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonComponent;
    }
}
