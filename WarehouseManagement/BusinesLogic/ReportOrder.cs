using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLogic
{
    public class ReportOrder
    {
        public string OrderId { get; private set; }
        public string OrderDate { get; private set; }
        public string Customer { get; private set; }        
        public string OrderStatus { get; private set; }
        public string Parts { get; private set; }

        public ReportOrder(int orderId, DateTime orderDate, string customer, string orderStatus, List<Part> parts)
        {
            OrderId = orderId.ToString();
            OrderDate = orderDate.ToString();
            Customer = customer;           
            OrderStatus = orderStatus;

            foreach (var part in parts)
            {
                Parts += $"Id: {part.Id}" +
                    $", Code: {part.Code}" +
                    $", Brand: {part.Brand}" +
                    $", Model: {part.Model}" +
                    $", Description: {part.Description}" +
                    $", Location: {part.Location.Code} {part.Location.Description}\n";
            }
        }
    }
}
