using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class ButtonComponent : UserControl
    {
        private readonly Button button;
        public ButtonComponent()
        {
            InitializeComponent();

            button = new Button();
            button.Resize += CustomButton_Resize;
            button.BackColor = Color.FromArgb(0, 91, 150);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 31, 75);
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 31, 75);
            button.ForeColor = Color.White;
            button.Cursor = Cursors.Hand;
            button.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            button.TextAlign = ContentAlignment.MiddleCenter;

            Controls.Add(button);
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("The name of the button (inside code).")]
        public new string ButtonName
        {
            get { return button.Name; }
            set { button.Name = value; }
        }

        [Browsable(true)]
        [Category("Layout")]
        [Description("The size of the button.")]
        public Size ButtonSize
        {
            get { return button.Size; }
            set { button.Size = value; }
        }

        [Browsable(true)]
        [Category("Layout")]
        [Description("The font of the button text.")]
        public Font ButtonTextFont
        {
            get { return button.Font; }
            set { button.Font = value; }
        }

        [Browsable(true)]
        [Category("Layout")]
        [Description("The text alignment of the button.")]
        public ContentAlignment ButtonTextAlign
        {
            get { return button.TextAlign; }
            set { button.TextAlign = value; }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("The text displayed on the button.")]
        public string ButtonText
        {
            get { return button.Text; }
            set { button.Text = value; }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("The background color of the button.")]
        public Color ButtonBackColor
        {
            get { return button.BackColor; }
            set { button.BackColor = value; }
        }

        public event EventHandler ButtonClick
        {
            add { button.Click += value; }
            remove { button.Click -= value; }
        }

        private void CustomButton_Resize(object sender, EventArgs e)
        {
            button.Size = new Size(ClientSize.Width, ClientSize.Height);
        }
    }
}
