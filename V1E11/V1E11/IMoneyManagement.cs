using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public interface IMoneyManagement
    {
        public int Amount { get; set; }
        public void Add(int amount)
        {
            Amount += amount;
            SendSMS();
        }

        private void SendSMS()
        {
        }
        public void Spend(int amount);
    }
}
