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

        public PartRepository()
        {
            _parts = new List<Part>();

            _parts.Add(new Part(1, "111", "Audi", "A6", "Brake disc front", new PartCategory(1, "1", "Brakes"), new PartLocation(1, "A1", "Green")));            
            _parts.Add(new Part(2, "222", "BMW", "E90", "Brake pads rear", new PartCategory(1, "1", "Brakes"), new PartLocation(1, "B2", "Blue")));
            _parts.Add(new Part(3, "333", "Toyota","Camry", "Wipers", new PartCategory(2, "2", "Spares"), new PartLocation(1, "T3", "Yellow")));
            _parts.Add(new Part(4, "444", "VW", "Golf","Door front left", new PartCategory(3, "3", "Body"), new PartLocation(1, "V4", "White")));
            _parts.Add(new Part(5, "555", "Renault", "Master", "Front Window", new PartCategory(4, "4", "Widows"), new PartLocation(1, "R5", "Purple")));
            _parts.Add(new Part(6, "666", "Opel", "Astra", "Catalyst", new PartCategory(5, "5", "Exhaust"), new PartLocation(1, "O6", "Red")));
            _parts.Add(new Part(7, "111", "Audi", "A6", "Brake disc front", new PartCategory(1, "1", "Brakes"), new PartLocation(1, "A1", "Green")));
            _parts.Add(new Part(8, "111", "Audi", "A6", "Brake disc front", new PartCategory(1, "1", "Brakes"), new PartLocation(1, "A1", "Green")));
        }

        public void AddNewPart(Part part)
        {
            _parts.Add(part);
        }

        public void RemovePart(int partId)
        {
            for (int i = 0; i < _parts.Count; i++)
            {
                if (partId == _parts[i].Id)
                {
                    _parts.RemoveAt(i);
                }
            }
        }

        public Part Retrieve(string partCode)
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
