using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjGru2
{
    public static class ZmienneGlobalne
    {
        static string _Login;
        static string _pwd;
        public static string Login
        {
            get
            {
                return _Login;
            }
            set
            {
                _Login = value;
            }
        }

        public static string Password {
            get
            {
                return _pwd;
            }
            set
            {
                _pwd = value;
            }
        }
    }
}
