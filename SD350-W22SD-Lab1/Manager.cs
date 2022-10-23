using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD350_W22SD_Lab1
{
    public class Manager : Client
    {
        public Manager()
        {
            AccessHandler = new HasAccessAutomatic();
        }
    }
}
