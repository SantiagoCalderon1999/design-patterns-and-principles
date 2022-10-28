using System;
using System.Collections.Generic;
using System.Text;

namespace dotNET.Solution.service
{
    interface PersistenceService<T> where T : Entity
    {
        public void save(T entity);

        public void delete(T entity);

        public T findById(long id);
    }
}
