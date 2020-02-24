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
            orderController.CreateNewOrder(1, "UAB EAMV");
            orderController.CreateNewOrder(2, "UAB EAMV");
            orderController.CreateNewOrder(3, "UAB EAMV");
            orderController.CreateNewOrder(4, "UAB Rasmitas");
            orderController.CreateNewOrder(5, "UAB Rasmitas");
            orderController.CreateNewOrder(6, "UAB Rasmitas");
            orderController.CreateNewOrder(7, "UAB TRT Shop");
            orderController.CreateNewOrder(8, "UAB TRT Shop");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormStart());
        }
    }
}
