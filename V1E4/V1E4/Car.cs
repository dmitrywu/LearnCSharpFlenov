using System;

namespace TestProject
{
    public class Car
    {
        private int width = 10;
        public int Width { 
            get { return width; }
            set { 
                if (value > 0) 
                    width = value; 
            }
        }
        public int Height { get; set; } = 20;
        public int Color { get; set; }

        public int Size {
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
    }
}
