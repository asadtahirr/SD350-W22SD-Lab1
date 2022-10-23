using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD350_W22SD_Lab1
{
    public abstract class Client
    {
        //(Name, Email, ?Age, bool accessDisabled)
        //Client will now require an AccessHandler property, and a virtual HandleAccess Method. HandleAccess should invoke AccessHandler’s getAccess method.
        public string Name { get; set; }
        public string Email { get; set; }
        public int? Age { get; set; }
        public bool AccessDisabled { get; set; }
        public IAccessHandler AccessHandler { get; set; }
        
        public virtual bool HandleAccess()
        {
            return AccessHandler.GetAccess();
        }
    }
}
