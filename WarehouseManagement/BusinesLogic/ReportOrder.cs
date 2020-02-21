using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLogic
{
    public class ReportOrder
    {
        public string OrderDate { get; private set; }
        public string Customer { get; private set; }
        public string OrderId { get; private set; }
        public string Parts { get; private set; }

        public ReportOrder(string orderDate, string customer, string orderId, List<Part> parts)
        {
            OrderDate = orderDate;
            Customer = customer;
            OrderId = orderId;

            foreach (var part in parts)
            {
                Parts += $"Id: {part.Id}" +
                    $", Code: {part.Code}" +
                    $", Brand: {part.Brand}" +
                    $", Model: {part.Model}" +
                    $", Description: {part.Description}" +
                    $", Location: {part.Location}";

                Parts += Environment.NewLine;
            }
        }
    }
}
