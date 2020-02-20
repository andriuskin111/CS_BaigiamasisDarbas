using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLogic
{
    public class OrderController
    {
        private List<Order> _orders;

        public OrderController()
        {
            _orders = new List<Order>();
        }

        public void CreateNewOrder(int orderId, string customer)
        {
            _orders.Add(new Order(orderId, DateTime.Now, new List<Part>(), customer, "Opened"));
        }

        public void AddPart(int orderId, Part part)
        {
            for (int i = 0; i < _orders.Count; i++)
            {
                if (orderId == _orders[i].Id)
                {
                    _orders[i].Parts.Add(part);
                }
            }         
        }

        public void RemovePart(int orderId, int partId)
        {
            foreach (var order in _orders)
            {
                if(orderId == order.Id)
                {
                    RemovePart(partId, order);
                }
            } 
        }

        private static void RemovePart(int partId, Order order)
        {
            for (int i = 0; i < order.Parts.Count; i++)
            {
                if (partId == order.Parts[i].Id)
                {
                    order.Parts.RemoveAt(i);
                }
            }
        }

        public Order Retrieve(int orderId)
        {
            foreach (var order in _orders)
            {
                if(orderId == order.Id)
                {
                    return order;
                }
            }

            return null;
        }

        public List<Order> Retrieve()
        {
            return _orders;
        }
    }
}
