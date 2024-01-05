using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class Auth
    {
        private static Auth instance;
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public static Auth GetInstance()
        {
            if (instance == null)
            {
                instance = new Auth();
            }
            return instance;
        }
    }
}
