using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject;

namespace TestProject
{
    class Bmw320d : Bmw320i
    {
        public Bmw320d(int width, int height, int color, int length) : base(width, height, color, length)
        {
            Engine = new Engine();
            //Engine.Volume = 10;
            //Engine.Code = "XXX";
        }

        public override int GetSize()
        {
            return Width * Height * Length;
        }
    }
}
