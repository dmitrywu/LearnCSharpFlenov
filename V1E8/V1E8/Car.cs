using System;

namespace TestProject
{
    class Car : Object
    {

        public Car()
        {

        }
        public Car(int width, int height, int color)
        {
            this.Width = width;
            this.Height = height;
            this.Color = color;

        }


        public Engine Engine { get; set; } = new Engine();

        private int width;
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height { get; set; }
        public int Color { get; set; }

        public virtual int GetSize()
        {
            return Width * Height;
        }



    }

    sealed class Engine
    {
        public string? Code { get; set; }
        public int Volume { get; set; }
    }
}
