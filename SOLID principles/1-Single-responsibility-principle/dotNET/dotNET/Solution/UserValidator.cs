using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace dotNET.Solution
{
    class UserValidator
    {
        public bool ValidateUser(User user)
        {
            return IsValidUser(user);
        }

        private bool IsValidUser(User user)
        {
            if (!IsPresent(user.Name))
            {
                return false;
            }
            user.Name = user.Name.Trim();

            if (!IsValidAlphaNumeric(user.Name))
            {
                return false;
            }

            if (user.Email == null || user.Email.Trim().Length == 0)
            {
                return false;
            }
            user.Email = user.Email.Trim();

            if (!IsValidEmail(user.Email))
            {
                return false;
            }

            return true;
        }

        private bool IsPresent(string value)
        {
            return value != null && value.Trim().Length > 0;
        }

        private bool IsValidAlphaNumeric(string value)
        {
            return Regex.Match(value, "[^A-Za-z0-9]*$").Success;
        }

        private bool IsValidEmail(string value)
        {
            return Regex.Match(value, "^[_A-Za-z0-9-\\+]+(\\.[_A-Za-z0-9-]+)*@[A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})$").Success;
        }
    }
}
