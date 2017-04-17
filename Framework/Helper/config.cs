using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Helper
{
    class config
    {
        public static string Userlogin = "tatayana1082@gmail.com";
        public static string Userpsw = "nfyz050482";
        public static class LoginPage
        {
            public static string URL = "https://www.pompdelux.com/en_GB/account";
            public static class InputData

            {
                
            }
            public static class SuccessMessages
            {
                public static string TextforAssertion = "Welcome";
            }
        }
        public static class AccountPage
        {
            public static string FirstName = "Tanya";
            public static string Country = "Belarus";
            public static class SuccessMessages
            {
                public static string TextforAssertion = "Edit";
            }

        }

    }
}
