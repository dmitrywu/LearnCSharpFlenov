using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    partial class Car : Object
    {
        public Car()
        {

        }

        private int width;
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

    }


}
