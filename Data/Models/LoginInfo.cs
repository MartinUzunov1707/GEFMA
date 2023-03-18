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
        public LoginInfo(string LoginUsername, string LoginPassword, bool Salted)
        {
            if (Salted)
            {
                Username = LoginUsername;
                Password = LoginPassword;
            }
            else
            {
                byte[] SaltedUsername = new SHA256Managed().ComputeHash(Encoding.UTF8.GetBytes(LoginUsername).Concat(Encoding.UTF8.GetBytes(1597463007.ToString())).ToArray());
                byte[] SaltedPassword = new SHA256Managed().ComputeHash(Encoding.UTF8.GetBytes(LoginPassword).Concat(Encoding.UTF8.GetBytes(1597463007.ToString())).ToArray());
                Username = Encoding.UTF8.GetString(SaltedUsername);
                Password = Encoding.UTF8.GetString(SaltedPassword);
            }
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool CheckPasswordAndUsername(string EnteredPassword, string EnteredUsername)
        {
            string SaltedEnteredPassword = Encoding.UTF8.GetString(new SHA256Managed().ComputeHash(Encoding.UTF8.GetBytes(EnteredPassword).Concat(Encoding.UTF8.GetBytes(1597463007.ToString())).ToArray()));
            string SaltedEnteredUsername = Encoding.UTF8.GetString(new SHA256Managed().ComputeHash(Encoding.UTF8.GetBytes(EnteredUsername).Concat(Encoding.UTF8.GetBytes(1597463007.ToString())).ToArray()));
  
            return Password.Equals(SaltedEnteredPassword) && Username.Equals(SaltedEnteredUsername);
        }
    }
}
