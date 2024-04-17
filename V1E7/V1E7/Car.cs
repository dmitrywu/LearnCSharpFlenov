using System;

namespace TestProject
{
    public class Car : Object
    {
        public Car(int width, int height, int color)
        {
            this.Width = width;
            this.Height = height;
            this.Color = color;
        }

        public int Width { get; set; }
        public int Height { get; set; }
        public int Color { get; set; }

        public virtual int GetSize()
        {
            return Width * Height;
        }


    }
}
