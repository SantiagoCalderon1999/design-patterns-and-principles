using System;
using System.Collections.Generic;
using System.Text;

namespace dotNET.Solution
{
    class UserController
    {

        private UserPersistenceService persistenceService = new UserPersistenceService();

        public string CreateUser(string userJson)
        {
            UserMapper mapper = new UserMapper();
            User user = mapper.mapJsonToUser(userJson);

            UserValidator validator = new UserValidator();
            if (!validator.ValidateUser(user))
            {
                return "Error";
            }

            return "Success";
        }
    }
}
