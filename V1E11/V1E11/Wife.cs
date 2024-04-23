using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Wife : IMoneyManagement
    {
        public int Amount { get; set; } = 0;
        public Wife() { }

        public void Add(int amount)
        {
            this.Amount += amount;
        }

        public void Spend(int amount)
        {
            
            this.Amount -= amount;
        }
    }

}
