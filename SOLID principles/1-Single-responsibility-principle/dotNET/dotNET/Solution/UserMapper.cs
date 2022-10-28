using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotNET.Solution
{
    class UserMapper
    {

        public User mapJsonToUser(String userJson)
        {
            return JsonConvert.DeserializeObject<User>(userJson);
        }
    }
}
