using System;
using System.Collections.Generic;
using System.Text;

namespace dotNET.Problem
{
    class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public User()
        {

        }

        public User(string name, string email, string address)
        {
            Name = name;
            Email = email;
            Address = address;
        }
    }
}
