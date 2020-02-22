using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using BusinesLogic;

namespace WarehouseUi
{
    static class Program
    {
        public static OrderController orderController = new OrderController();
        public static PartRepository partRepository = new PartRepository();
        public static List<Part> parts = partRepository.Retrieve();
        public static ReportGenerator reportGenerator = new ReportGenerator(orderController);

        [STAThread]
        static void Main()
        {
            orderController.CreateNewOrder("UAB EAMV");
            Thread.Sleep(1000);
            orderController.CreateNewOrder("UAB EAMV");
            Thread.Sleep(1000);
            orderController.CreateNewOrder("UAB EAMV");
            Thread.Sleep(1000);
            orderController.CreateNewOrder("UAB Rasmitas");
            Thread.Sleep(1000);
            orderController.CreateNewOrder("UAB Rasmitas");
            Thread.Sleep(1000);
            orderController.CreateNewOrder("UAB Rasmitas");
            Thread.Sleep(1000);
            orderController.CreateNewOrder("UAB TRT Shop");
            Thread.Sleep(1000);
            orderController.CreateNewOrder("UAB TRT Shop");

            orderController.AddPart(1, parts[1]);
            orderController.AddPart(1, parts[2]);
            orderController.AddPart(2, parts[3]);
            orderController.AddPart(2, parts[4]);
            orderController.AddPart(3, parts[5]);
            orderController.AddPart(3, parts[0]);

            orderController.CloseOrder(2, partRepository);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormStart());
        }
    }
}
