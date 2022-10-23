using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD350_W22SD_Lab1
{
    public class Admin : Client
    {
        /*Manager and Admin should have their access handlers set as new HasAccessAutomatic instances when they are constructed.*/
        public Admin()
        {
            AccessHandler = new HasAccessAutomatic();
        }
    }
}
