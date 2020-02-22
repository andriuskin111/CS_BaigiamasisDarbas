using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLogic
{
    public class Order
    {
        public Int64 Id { get; private set; }
        public DateTime Date { get; private set; }
        public List<Part> Parts { get; private set; }
        public string Customer { get; private set; }
        public string Status { get; set; }

        public Order(Int64 id, DateTime date, List<Part> parts, string customer, string status)
        {
            Id = id;
            Date = date;
            Parts = parts;
            Customer = customer;
            Status = status;
        }
    }
}
