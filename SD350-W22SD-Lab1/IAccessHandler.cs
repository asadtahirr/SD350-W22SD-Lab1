using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD350_W22SD_Lab1
{
    public interface IAccessHandler
    {
        //It has one method, bool getAccess(int? Reputation = 0, bool accessDisabled = false).
        bool GetAccess(int? reputation = 0, bool accessDisabled = false);
    }
}
