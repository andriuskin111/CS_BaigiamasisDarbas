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
            _orders[orderId].Parts.Add(part);
        }

        public void RemovePart(int orderId, int partId)
        {
            foreach (var part in _orders[orderId].Parts)
            {
                if(partId == part.Id)
                {
                    _orders[orderId].Parts.Remove(part);
                }
            } 
        }
    }
}
