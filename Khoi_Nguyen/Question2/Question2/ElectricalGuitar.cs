using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    internal class ElectricalGuitar : Instrumental
    {
        public override void GetInfo()
        {
            Console.WriteLine("_Electrical Guitar_");
            Console.WriteLine("This type of guitar has 6 strings and use electricity\n");
        }
    }
}
