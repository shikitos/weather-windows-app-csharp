using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class MainForm : Form
    {
        private readonly DatabaseController dbController;
        public static MainForm Instance { get; private set; }
        private Auth userAuth;


        public MainForm(DatabaseController dbController)
        {
            InitializeComponent();
            this.dbController = dbController;
            Instance = this;

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            userAuth = Auth.GetInstance();
        }

        public HeaderComponent HeaderComponent
        {
            get { return headerComponent1; }
        }
        public LoginPage LoginPage
        {
            get { return loginPage1; }
        }
        public RegisterPage RegisterPage
        {
            get { return registerPage1; }
        }
        public HomePage HomePage
        {
            get { return homePage1; }
        }
        public WelcomePage WelcomePage
        {
            get { return welcomePage1; }
        }

        public DatabaseController DatabaseController
        {
            get { return dbController; }
        }

        public Auth Auth
        {
            get { return userAuth; }
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.Visible = control == welcomePage1;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                dbController?.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
