using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLogic
{
    public class PartRepository
    {
        private List<Part> _parts;

        public PartRepository(List<Part> parts)
        {
            _parts = new List<Part>();

            _parts.Add(new Part(1, 1, "Audi", "A6", "Brake disc front", "Brakes", new PartLocation(1, "A1", "Green")));
            _parts.Add(new Part(2, 2, "BMW", "E90", "Brake pads rear", "Brakes", new PartLocation(1, "B2", "Blue")));
            _parts.Add(new Part(3, 3, "Toyota","Camry", "Wipers", "Spares", new PartLocation(1, "T3", "Yellow")));
            _parts.Add(new Part(4, 4, "VW", "Golf","Door front left", "Body", new PartLocation(1, "V4", "White")));
            _parts.Add(new Part(5, 5, "Renault", "Master", "Front Window", "Windows", new PartLocation(1, "R5", "Purple")));
            _parts.Add(new Part(6, 6, "Opel", "Astra", "Catalyst", "Exhaust", new PartLocation(1, "O6", "Red")));
        }

        public Part Retrieve(int partCode)
        {
            foreach (var part in _parts)
            {
                if(partCode == part.Code)
                {
                    return part;
                }
            }

            return null;
        }
        public List<Part> Retrieve()
        {
            return _parts;
        }
    }
}
