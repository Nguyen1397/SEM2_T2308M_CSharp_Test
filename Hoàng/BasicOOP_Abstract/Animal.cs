using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP_Abstract
{
    public abstract class Animal
    {
        public abstract void Sound();
        public void Eat()
        {
            Console.WriteLine("Animal eat");
        }
    }
}
