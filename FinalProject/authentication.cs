using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class authentication
    {
        string nic,
               name,
               username,
               email,
               password,
               confirmPassword;

        public void setsignup(string NIC, string Name, string Username, string Email, string Password, string Confirmpassword)
        {
            nic = NIC;
            name = Name;
            username = Username;
            email = Email;
            password = Password;
            confirmPassword = Confirmpassword;
        }
    }
}
