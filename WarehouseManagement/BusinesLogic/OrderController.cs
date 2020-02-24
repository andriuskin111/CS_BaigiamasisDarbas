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

        public void CreateNewOrder(Int64 id, string customer)
        {           
            _orders.Add(new Order(id, DateTime.Now, new List<Part>(), customer, "Opened"));        
        }

        public List<Part> GetAvailableParts(PartRepository partRepository)
        {
            List<Part> result = new List<Part>();

            foreach (var part in partRepository.Retrieve())
            {
                if (!CheckOrPartIsReserved(part))
                {
                    result.Add(part);
                }
            }

            return result;
        }

        public List<Part> GetReservedParts(PartRepository partRepository)
        {
            List<Part> result = new List<Part>();

            foreach (var part in partRepository.Retrieve())
            {
                if (CheckOrPartIsReserved(part))
                {
                    result.Add(part);
                }
            }

            return result;
        }

        private bool CheckOrPartIsReserved(Part part)
        {
            bool result = false;

            foreach (var order in _orders)
            {
                foreach (var item in order.Parts)
                {
                    if(part.Id == item.Id)
                    {
                        result = true;
                    }
                }
            }
            
            return result;
        }

        public void AddPart(Int64 orderId, Part part)
        {
            for (int i = 0; i < _orders.Count; i++)
            {
                if (orderId == _orders[i].Id && CheckOrPartIsReserved(part) == false)
                {
                    _orders[i].Parts.Add(part);
                }
            }         
        }

        public void RemovePart(Int64 orderId, Int64 partId)
        {
            foreach (var order in _orders)
            {
                if(orderId == order.Id)
                {
                    RemovePart(partId, order);
                }
            } 
        }

        private static void RemovePart(Int64 partId, Order order)
        {
            for (int i = 0; i < order.Parts.Count; i++)
            {
                if (partId == order.Parts[i].Id)
                {
                    order.Parts.RemoveAt(i);
                }
            }
        }

        public Order Retrieve(Int64 orderId)
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

        public void CancelOrder(Int64 orderId)
        {
            for (int i = 0; i < _orders.Count; i++)
            {
                if(orderId == _orders[i].Id)
                {
                    _orders.RemoveAt(i);
                }
            }
        }

        public void CloseOrder(Int64 orderId, PartRepository partRepository)
        {
            foreach (var order in _orders)
            {
                if (orderId == order.Id)
                {
                    foreach (var part in order.Parts)
                    {
                        partRepository.RemovePart(part.Id);
                    }

                    order.Status = "Closed";
                }
            }
        }

        public int GetOrderedPartQuantity(Int64 orderId, string partCode)
        {
            int result = 0;

            foreach (var order in _orders)
            {
                if(orderId == order.Id)
                {
                    result += GetOrderedPartQuantity(partCode, order);
                }
            }

            return result;
        }

        private static int GetOrderedPartQuantity(string partCode, Order order)
        {
            int result = 0;

            foreach (var part in order.Parts)
            {
                if (partCode == part.Code)
                {
                    result = 1;
                }
                else
                {
                    result = 0;
                }
            }

            return result;
        }
    }
}
