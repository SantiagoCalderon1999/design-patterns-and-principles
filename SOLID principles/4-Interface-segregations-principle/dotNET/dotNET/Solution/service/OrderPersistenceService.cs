using System;
using System.Collections.Generic;
using System.Text;

namespace dotNET.Solution.service
{
    class OrderPersistenceService : PersistenceService<Order>
    {
        private Dictionary<long, Order> ORDER = new Dictionary<long, Order>();

        public void delete(Order entity)
        {
            ORDER.Remove(entity.Id);
        }

        public Order findById(long id)
        {
            Order Order;
            ORDER.TryGetValue(id, out Order);
            return Order;
        }

        public void save(Order entity)
        {
            ORDER.Add(entity.Id, entity);
        }
    }
}
