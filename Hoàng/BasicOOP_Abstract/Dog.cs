using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP_Abstract
{
    public class Dog : Animal, IAnimal
    {
        public Dog() { }
        public void Run()
        {
            Console.WriteLine("Run");
        }

        public override void Sound()
        {
            Console.WriteLine("go go");
        }
    }
}
