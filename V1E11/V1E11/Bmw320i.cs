using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Bmw320i : Car, IMoneyManagement, IDisposable
    {
        public int Amount { get; set; } = 0;

        public Bmw320i() { }
        public Bmw320i(int width, int height, int color, int length) : base(width, height, color)
        {
            this.Length = length;
            Engine = new Engine()
            {
                Code = "XXX",
                Volume = 10
            };
        }
        public int Length { get; set; }
        public override int GetSize()
        {
            return Width * Height * Length;
        }
        private void BlowEngine() { }


        public void Add(int amount)
        {
            this.Amount = this.Amount + amount;
        }

        public void Spend(int amount)
        {
            if ((this.Amount - amount) < 0) { BlowEngine();  return; }

            this.Amount = this.Amount - amount;
        }

        public void Dispose()
        {
        }
    }
}
