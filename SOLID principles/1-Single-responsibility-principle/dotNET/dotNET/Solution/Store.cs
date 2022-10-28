using System;
using System.Collections.Generic;
using System.Text;

namespace dotNET.Solution
{
    class Store
    {
        private Dictionary<string, User> STORAGE = new Dictionary<string, User>();

        public void StoreUser(User user)
        {
            STORAGE.Add(user.Name, user);
        }

       public User GetUser(string name)
        {
            User fetchedUser;
            STORAGE.TryGetValue(name, out fetchedUser);
            return fetchedUser;
        }
    }
}
