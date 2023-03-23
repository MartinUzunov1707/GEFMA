using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    /// <summary>
    /// Model for the LoginInfo class. This is NOT used in a database. Previous logins are stored locally.
    /// </summary>
    public class LoginInfo
    {
        /// <summary>
        /// Constructor for LoginInfo class. This constructor fills every field in the class and uses an extra variable to determine if the password should be salted and encrypted ot not.
        /// </summary>
        /// <param name="LoginUsername"></param>
        /// <param name="LoginPassword"></param>
        /// <param name="Salted"></param>
        public LoginInfo(string LoginUsername, string LoginPassword, bool Salted = false)
        {
            if (Salted)
            {
                //No encryption.
                Username = LoginUsername;
                Password = LoginPassword;
            }
            else
            {
                //Encryption logic.
                byte[] SaltedUsername = new SHA256Managed().ComputeHash(Encoding.UTF8.GetBytes(LoginUsername).Concat(Encoding.UTF8.GetBytes(1597463007.ToString())).ToArray());
                byte[] SaltedPassword = new SHA256Managed().ComputeHash(Encoding.UTF8.GetBytes(LoginPassword).Concat(Encoding.UTF8.GetBytes(1597463007.ToString())).ToArray());
                Username = string.Join("", Encoding.UTF8.GetString(SaltedUsername).ToCharArray().Select(x => (int)x).ToList());
                Password = string.Join("", Encoding.UTF8.GetString(SaltedPassword).ToCharArray().Select(x => (int)x).ToList());
            }
        }
        /// <summary>
        /// Public fields that the class contains. These are usually encrypted
        /// </summary>
        public string Username { get; set; }
        public string Password { get; set; }
        /// <summary>
        /// Public method that checks if the entered LoginInfo matches the stored LoginInfo.
        /// </summary>
        /// <param name="EnteredPassword"></param>
        /// <param name="EnteredUsername"></param>
        /// <returns></returns>
        public bool CheckPasswordAndUsername(string EnteredPassword, string EnteredUsername)
        {
            string SaltedEnteredPassword = string.Join("", Encoding.UTF8.GetString(new SHA256Managed().ComputeHash(Encoding.UTF8.GetBytes(EnteredPassword).Concat(Encoding.UTF8.GetBytes(1597463007.ToString())).ToArray())).ToCharArray().Select(x => (int)x).ToList());
            string SaltedEnteredUsername = string.Join("", Encoding.UTF8.GetString(new SHA256Managed().ComputeHash(Encoding.UTF8.GetBytes(EnteredUsername).Concat(Encoding.UTF8.GetBytes(1597463007.ToString())).ToArray())).ToCharArray().Select(x => (int)x).ToList());
            return string.Join("", Username).Equals(SaltedEnteredUsername) && string.Join("", Password).Equals(SaltedEnteredPassword);
        }
    }
}
