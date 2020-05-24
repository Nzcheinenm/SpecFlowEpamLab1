using System;
using System.Collections.Generic;
using System.Text;

namespace WebDriverEpamLab2.business_object
{
    class Login
    {
        public string userLog;
        public string userPass;

        public Login(string userLog,string userPass)
        {
            this.userLog = userLog;
            this.userPass = userPass;
        }
    }
}
