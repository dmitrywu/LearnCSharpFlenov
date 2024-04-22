using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Purse
    {
        int Amount = 0;
        public Purse() { }

        public void Add(int amount)
        {
            this.Amount = this.Amount + amount;
        }

        public void Spend(int amount)
        {
            if ((this.Amount - amount) < 0) { return; }

            this.Amount = this.Amount - amount;
        }
    }
}
