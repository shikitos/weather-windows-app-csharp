using System;
using System.Linq;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class MainForm : Form
    {
        public static MainForm Instance { get; private set; }
        private readonly Auth _userAuth;

        public MainForm()
        {
            InitializeComponent();

            AddControls();

            Instance = this;
            ModifyFormContainer();

            _userAuth = Auth.GetInstance();
        }

        private void AddControls()
        {
            Type[] controlsList = CustomControlsProperties.GetControlsList;

            foreach (Type controlType in controlsList)
            {
                if (typeof(Control).IsAssignableFrom(controlType))
                {
                    Control controlInstance = (Control)Activator.CreateInstance(controlType, new[] { this });

                    Controls.Add(controlInstance);
                    controlInstance.Location = CustomControlsProperties.GetControlLocation(controlType);
                    controlInstance.Size = CustomControlsProperties.GetControlSize(controlType);
                }
            }
        }

        private void ModifyFormContainer()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }

        public HeaderComponent HeaderComponent
        {
            get { return Controls.OfType<HeaderComponent>().FirstOrDefault(); }
        }
        public LoginPage LoginPage
        {
            get { return Controls.OfType<LoginPage>().FirstOrDefault(); }
        }
        public RegisterPage RegisterPage
        {
            get { return Controls.OfType<RegisterPage>().FirstOrDefault(); }
        }
        public HomePage HomePage
        {
            get { return Controls.OfType<HomePage>().FirstOrDefault(); }
        }
        public WelcomePage WelcomePage
        {
            get { return Controls.OfType<WelcomePage>().FirstOrDefault(); }
        }

        public Auth Auth
        {
            get { return _userAuth; }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            foreach (Control control in Controls)
            {
                control.Visible = control == WelcomePage;
            }
        }

    }
}