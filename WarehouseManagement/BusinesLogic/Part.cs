using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLogic
{
    public class Part
    {
        public int Id { get; set; }
        public int Code { get; private set; }
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public string Description { get; private set; }
        public string Category { get; private set; }
        public PartLocation Location { get; private set; }

        public Part(int id, int code, string brand, string model, string description, string category, PartLocation location)
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
