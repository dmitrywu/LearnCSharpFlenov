using System;

namespace TestProject
{
    struct CarStruct
    {
        public CarStruct(int w, int h)
        {
            Height = h;
            width = w;
        }
        private int width;
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public int Height { get; set; }

        public int GetSize()
        {
            return Width * Height;
        }


    }

}
