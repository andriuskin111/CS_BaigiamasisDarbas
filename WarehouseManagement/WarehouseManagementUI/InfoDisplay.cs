using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinesLogic;

namespace WarehouseManagementUI
{
    public class InfoDisplay
    {
        public void ShowAllOrders(ReportGenerator reportGenerator)
        {
            foreach (var report in reportGenerator.GenerateReport())
            {
                Console.WriteLine($"Order Id: {report.OrderId}\n" +
                    $"Date: {report.OrderDate}\n" +
                    $"Customer: {report.Customer}\n" +
                    $"Status: {report.OrderStatus}\n" +
                    $"Parts:\n{report.Parts}");
            }
        }

        public void ShowPartsInStock(PartRepository partRepository)
        {
            Console.WriteLine($"Parts in stock({partRepository.Retrieve().Count}):");

            foreach (var part in partRepository.Retrieve())
            {
                Console.WriteLine($"Part Id: {part.Id}" +
                    $", Code: {part.Code}" +
                    $", Brand: {part.Brand}" +
                    $", Model: {part.Model}" +
                    $", Description: {part.Description}" +
                    $", Location: {part.Location.Code} {part.Location.Description}");
            }

            Console.WriteLine();
        }
    }
}
