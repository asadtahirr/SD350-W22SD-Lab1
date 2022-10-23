using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD350_W22SD_Lab1
{
    internal class HasReputation : IAccessHandler
    {
        public bool GetAccess(int? reputation = 0, bool accessDisabled = false)
        {
            if (reputation > 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
