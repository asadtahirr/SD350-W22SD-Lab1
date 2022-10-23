using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD350_W22SD_Lab1
{
    public class User : Client
    {
        public int Reputation { get; set; }
        public int Value { get; set; }
        public User()
        {
            AccessHandler = new HasReputation();
        }

        public override bool HandleAccess()
        {
            return AccessHandler.GetAccess(Reputation);
        }
    }
}
