using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD350_W22SD_Lab1
{
    public class HasAccessAutomatic : IAccessHandler
    {
        //HasAccessAutomatic will return true as long as their accessDisabled property is false.
        public bool GetAccess(int? reputation = 0, bool accessDisabled = false)
        {
            if (accessDisabled)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
