using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    internal class MusicalInstrument : CommonInfomation, SpeciaInformation
    {
        public void InstrumentName(string name)
        {
            Console.WriteLine($"Instrucment name: {name}");
        }

        public void PlayAnInstrument(string name)
        {
            Console.WriteLine($"Play the {name}");
        }

        public void Special(string info)
        {
            Console.WriteLine($"Special information: {info}");
        }

        public void YearOfManufacture(string year)
        {
            Console.WriteLine($"Production year: {year}");
        }
    }
}
