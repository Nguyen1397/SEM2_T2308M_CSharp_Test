using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP_Abstract
{
    public class Cat : Animal, IAnimal
    {
        public Cat() { }

        public  void Run()
        {
            Console.WriteLine("Run ");
        }

        public override void Sound()
        {
            Console.WriteLine("meo meo ");
        }
    }
}
