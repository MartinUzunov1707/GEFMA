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
                Username = string.Join("", Encoding.UTF8.GetString(SaltedUsername).ToCharArray().Select(x => (int)x).ToList());
                Password = string.Join("", Encoding.UTF8.GetString(SaltedPassword).ToCharArray().Select(x => (int)x).ToList());
            }
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool CheckPasswordAndUsername(string EnteredPassword, string EnteredUsername)
        {
            string SaltedEnteredPassword = string.Join("", Encoding.UTF8.GetString(new SHA256Managed().ComputeHash(Encoding.UTF8.GetBytes(EnteredPassword).Concat(Encoding.UTF8.GetBytes(1597463007.ToString())).ToArray())).ToCharArray().Select(x => (int)x).ToList());
            string SaltedEnteredUsername = string.Join("", Encoding.UTF8.GetString(new SHA256Managed().ComputeHash(Encoding.UTF8.GetBytes(EnteredUsername).Concat(Encoding.UTF8.GetBytes(1597463007.ToString())).ToArray())).ToCharArray().Select(x => (int)x).ToList());
            return string.Join("", Username).Equals(SaltedEnteredUsername) && string.Join("", Password).Equals(SaltedEnteredPassword);
        }
    }
}
