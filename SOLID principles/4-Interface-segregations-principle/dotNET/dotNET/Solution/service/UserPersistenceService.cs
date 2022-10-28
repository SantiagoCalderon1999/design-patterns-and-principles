using System;
using System.Collections.Generic;
using System.Text;

namespace dotNET.Solution.service
{
    class UserPersistenceService : PersistenceService<User>
    {
        private Dictionary<long, User> USERS = new Dictionary<long, User>();

        public void delete(User entity)
        {
            USERS.Remove(entity.Id);
        }

        public User findById(long id)
        {
            User user;
            USERS.TryGetValue(id, out user);
            return user;
        }

        public List<User> findByName(string name)
        {
            List<User> list = new List<User>();
            list.AddRange(USERS.Values);
            return list.FindAll(user => user.Name == name);
        }

        public void save(User entity)
        {
            USERS.Add(entity.Id, entity);
        }
    }
}
