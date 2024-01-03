using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class ButtonComponent : UserControl
    {
        [Browsable(true)]
        [Category("Appearance")]
        [Description("The name of the button (inside code).")]
        public new string ButtonName
        {
            get { return buttonComponent.Name; }
            set { buttonComponent.Name = value; }
        }

        [Browsable(true)]
        [Category("Layout")]
        [Description("The size of the button.")]
        public Size ButtonSize
        {
            get { return buttonComponent.Size; }
            set { buttonComponent.Size = value; }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("The text displayed on the button.")]
        public string ButtonText
        {
            get { return buttonComponent.Text; }
            set { buttonComponent.Text = value; }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("The background color of the button.")]
        public Color ButtonBackColor
        {
            get { return buttonComponent.BackColor; }
            set { buttonComponent.BackColor = value; }
        }

        public event EventHandler ButtonClick
        {
            add { buttonComponent.Click += value; }
            remove { buttonComponent.Click -= value; }
        }

        public ButtonComponent()
        {
            InitializeComponent();

            this.Resize += CustomButton_Resize;
            buttonComponent.BackColor = System.Drawing.Color.FromArgb(46, 164, 79);
            buttonComponent.FlatStyle = FlatStyle.Flat;
            buttonComponent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(27, 31, 35);
            buttonComponent.FlatAppearance.BorderSize = 1;
            buttonComponent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(27, 31, 35);
            buttonComponent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(27, 31, 35);
            buttonComponent.ForeColor = System.Drawing.Color.White;
            buttonComponent.Cursor = Cursors.Hand;
            buttonComponent.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            buttonComponent.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void buttonComponent_Click(object sender, EventArgs e)
        {

        }

        private void CustomButton_Resize(object sender, EventArgs e)
        {
            buttonComponent.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
        }
    }
}
