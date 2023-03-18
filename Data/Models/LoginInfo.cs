using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class LoginInfo
    {
        public LoginInfo(string LoginUsername, string LoginPassoword)
        {
            byte[] SaltedUsername = new SHA256Managed().ComputeHash(Encoding.UTF8.GetBytes(LoginUsername).Concat(Encoding.UTF8.GetBytes(1597463007.ToString())).ToArray());
            byte[] SaltedPassword = new SHA256Managed().ComputeHash(Encoding.UTF8.GetBytes(LoginPassoword).Concat(Encoding.UTF8.GetBytes(1597463007.ToString())).ToArray());
            Username = Encoding.UTF8.GetString(SaltedUsername);
            Password = Encoding.UTF8.GetString(SaltedPassword);
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool CheckPasswordAndUsername(string EnteredPassword, string EnteredUsername)
        {
            byte[] SaltedEnteredPassword = new SHA256Managed().ComputeHash(Encoding.UTF8.GetBytes(EnteredPassword).Concat(Encoding.UTF8.GetBytes(1597463007.ToString())).ToArray());
            byte[] SaltedActualPassword = new SHA256Managed().ComputeHash(Encoding.UTF8.GetBytes(Password).Concat(Encoding.UTF8.GetBytes(1597463007.ToString())).ToArray());
            byte[] SaltedEnteredUsername = new SHA256Managed().ComputeHash(Encoding.UTF8.GetBytes(EnteredUsername).Concat(Encoding.UTF8.GetBytes(1597463007.ToString())).ToArray());
            byte[] SaltedActualUsername = new SHA256Managed().ComputeHash(Encoding.UTF8.GetBytes(Username).Concat(Encoding.UTF8.GetBytes(1597463007.ToString())).ToArray());
            return SaltedActualPassword.Equals(SaltedEnteredPassword) && SaltedActualUsername.Equals(SaltedEnteredUsername);
        }
    }
}
