using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLogic
{
    public class PartCategory
    {
        public int Id { get; private set; }
        public string Code { get; private set; }
        public string Decription { get; private set; }

        public PartCategory(int id, string code, string decription)
        {
            Id = id;
            Code = code;
            Decription = decription;
        }
    }
}
