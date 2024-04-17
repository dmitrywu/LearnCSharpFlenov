using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Bmw320i : Car
    {
        public Bmw320i(int width, int height, int color, int length) : base(width, height, color)
        {
            this.Length = length;
        }
        public int Length { get; set; }
        public override int GetSize()
        {
            return Width * Height * Length;
        }
    }
}
