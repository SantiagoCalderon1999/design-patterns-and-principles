using System;
using System.Collections.Generic;
using System.Text;

namespace dotNET.Solution
{
    class UserPersistenceService
    {
        private Store _store = new Store();

        public void saveUser(User user)
        {
            _store.StoreUser(user);
        }
    }
}
