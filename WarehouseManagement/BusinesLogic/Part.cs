using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLogic
{
    public class Part
    {
        public Int64 Id { get; set; }
        public string Code { get; private set; }
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public string Description { get; private set; }
        public PartCategory Category { get; private set; }
        public PartLocation Location { get; private set; }

        public Part(Int64 id, string code, string brand, string model, string description, PartCategory category, PartLocation location)
        {
            this.Id = id;
            this.Code = code;
            this.Brand = brand;
            this.Model = model;
            this.Description = description;
            this.Category = category;
            this.Location = location;
        }
    }
}
