using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    internal class DataAccessLayer
    {
        private readonly ILogger logger;
        public DataAccessLayer(ILogger logger)
        {
            this.logger = logger;
        }
        public void Addcustomer(String message)
        {
        logger.log(message);
        }
    }
}
