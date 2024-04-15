using System;

namespace TestProject
{
    public class Car
    {
        private int gear = 0;

        public int Gear
        {
            get { return gear; }
        }

        private int width = 10;
        public int Width
        {
            get { return width; }
            set
            {
                if (value > 0)
                    width = value;
            }
        }
        public int Height { get; set; } = 2;
        public int Color { get; set; }

        public int Size
        {
            get { return Width * Height; }
        }

        public int GetSize()
        {
            return Width * Height;
        }

        public void Start()
        {
            Console.WriteLine("Start");
        }

        public void SetGear(int gear)
        {
            this.gear = gear;
        }

        public int SetSize(int width)
        {
            return width;

        }

        public int SetSize(ref int width, ref int height, out int newheight)
        {
            this.width = width;
            this.Height = height;
            newheight = height;
            width = 20;
            return this.width;
        }
    }
}
