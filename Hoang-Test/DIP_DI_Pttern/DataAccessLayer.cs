using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_DI_Pttern
{
    internal class DataAccessLayer
    {
        private readonly ILogger logger;

        public DataAccessLayer(ILogger logger)
        {
            this.logger = logger;
        }
        public void AddCustomer(string name)
        {
            Console.WriteLine($"name: {name}");
            logger.Log($"name: {name}");
        }
    }

}
