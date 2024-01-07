using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WeatherApp
{
    internal static class CustomControlsProperties
    {
        public static Type[] GetControlsList
        {
            get
            {
                return new Type[]
                {
                    typeof(WelcomePage),
                    typeof(LoginPage),
                    typeof(RegisterPage),
                    typeof(HomePage),
                    typeof(HeaderComponent)
                };
            }
        }


        private static readonly Dictionary<Type, Point> _controlLocations = new Dictionary<Type, Point>
        {
            { typeof(WelcomePage), new Point(12, 393) },
            { typeof(LoginPage), new Point(77, 305) },
            { typeof(RegisterPage), new Point(77, 305) },
            { typeof(HomePage), new Point(0, 37) },
            { typeof(HeaderComponent), new Point(0, 0) },
        };

        private static readonly Dictionary<Type, Size> _controlSize = new Dictionary<Type, Size>
        {
            { typeof(WelcomePage), new Size(480, 125) },
            { typeof(LoginPage), new Size(350, 300) },
            { typeof(RegisterPage), new Size(350, 300) },
            { typeof(HomePage), new Size(505, 875) },
            { typeof(HeaderComponent), new Size(505, 31) },
        };

        public static Point GetControlLocation(Type controlType)
        {
            if (_controlLocations.ContainsKey(controlType))
            {
                return _controlLocations[controlType];
            }
            else
            {
                return new Point(0, 0);
            }
        }

        public static Size GetControlSize(Type controlType)
        {
            if (_controlSize.ContainsKey(controlType))
            {
                return _controlSize[controlType];
            }
            else
            {
                return new Size(0, 0);
            }
        }
    }
}
