using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinesLogic;

namespace WarehouseManagementUI
{
    class Program
    {
        static void Main(string[] args)
        {
            InfoDisplay infoDisplay = new InfoDisplay();
            OrderController orderController = new OrderController();
            PartRepository partRepository = new PartRepository();
            List<Part> parts = partRepository.Retrieve();
            ReportGenerator reportGenerator = new ReportGenerator(orderController);

            orderController.CreateNewOrder("UAB EAMV");
            orderController.CreateNewOrder("UAB Rasmitas");
            orderController.CreateNewOrder("UAB TRT Shop");

            infoDisplay.ShowPartsInStock(partRepository);

            orderController.AddPart(1, parts[1]);
            orderController.AddPart(1, parts[2]);
            orderController.AddPart(2, parts[3]);
            orderController.AddPart(2, parts[4]);
            orderController.AddPart(3, parts[5]);
            orderController.AddPart(3, parts[0]);

            infoDisplay.ShowAvailablePartsInStock(orderController, partRepository);

            orderController.CloseOrder(3, partRepository);

            infoDisplay.ShowAllOrders(reportGenerator);

            infoDisplay.ShowPartsInStock(partRepository);

            Console.ReadLine();
        }
    }
}
