using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLogic
{
    public class ReportGenerator
    {
        private OrderController _orderController;

        public ReportGenerator(OrderController orderController)
        {
            _orderController = orderController;
        }

        public List<ReportOrder> GenerateReport()
        {
            List<ReportOrder> reportOrders = new List<ReportOrder>();

            foreach (var order in _orderController.Retrieve())
            {
                reportOrders.Add(new ReportOrder(order.Id, order.Date, order.Customer, order.Status, order.Parts));
            }


            return reportOrders;
        }

        public List<ReportOrder> GenerateReport(int orderId)
        {
            List<ReportOrder> reportOrders = new List<ReportOrder>();

            foreach (var order in _orderController.Retrieve())
            {
                if(orderId == order.Id)
                {
                    reportOrders.Add(new ReportOrder(order.Id, order.Date, order.Customer, order.Status, order.Parts));
                }                
            }

            return reportOrders;
        }

        public List<ReportOrder> GenerateReport(DateTime date)
        {
            List<ReportOrder> reportOrders = new List<ReportOrder>();

            foreach (var order in _orderController.Retrieve())
            {
                if (date.ToShortDateString() == order.Date.ToShortDateString())
                {
                    reportOrders.Add(new ReportOrder(order.Id, order.Date, order.Customer, order.Status, order.Parts));
                }
            }

            return reportOrders;
        }

        public List<ReportOrder> GenerateReport(string customer)
        {
            List<ReportOrder> reportOrders = new List<ReportOrder>();

            foreach (var order in _orderController.Retrieve())
            {
                if (customer == order.Customer)
                {
                    reportOrders.Add(new ReportOrder(order.Id, order.Date, order.Customer, order.Status, order.Parts));
                }
            }

            return reportOrders;
        }
    }
}
