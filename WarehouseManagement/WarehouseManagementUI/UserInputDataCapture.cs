using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementUI
{
    public class UserInputDataCapture
    {
        public static int CaptureMenuItem()
        {
            int result = 0;
            bool dataValid = false;

            while (!dataValid)
            {
                if(!int.TryParse(Console.ReadLine(), out result))
                {
                    Console.WriteLine("Wrong input data, try again!");

                    dataValid = false;
                }
                else
                {
                    dataValid = true;
                }
            }

            return result;
        }
    }
}
