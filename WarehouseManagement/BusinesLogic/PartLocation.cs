using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLogic
{
    public class PartLocation
    {
        public int Id { get; private set; }
        public string Code { get; private set; }
        public string Description { get; private set; }

        public PartLocation(int id, string code, string description)
        {
            Id = id;
            Code = code;
            Description = description;
        }
    }
}
