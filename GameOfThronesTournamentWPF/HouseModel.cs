using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfThronesTournamentWPF
{
    class HouseModel
    {

        public string Name { get; set; }
        public int NbUnits { get; set; }

        public HouseModel() { }

        public override string ToString()
        {
            return "Name: " + Name + " Units: " + NbUnits;
        }


    }
}
