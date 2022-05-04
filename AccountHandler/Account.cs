using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSoft.AccountHandler
{
    enum AccountPermission
    {
        Student,
        Teacher,
        Director
    }

    class Account
    {
        private string _login;
        private string _password;
        private AccountPermission _permission;
    }
}
