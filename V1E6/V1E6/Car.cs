using System;

namespace TestProject
{
    public class Car
    {
        // Конструктор, чтобы обязать пользователя передавать параметры
        // Отличие конструктора от метода - он НЕ возвращает значения и имя конструктора такое же, как у класса
        // конструктор просто инициализируется, когда мы создаём новый класс
        // Можно задавать несколько конструкторов
        // Можно перенаправлять с одного конструктора на другой

        //public Car() : this(10, 1, 0)
        //{ }

        public Car(int width, int height, int color)
        {
            this.width = width;
            this.Height = height;
            this.Color = color;
        }

        //синглтон
        private static Car? car = null;
        public static Car GetPresidentsCar()
        {
            if (car == null) car = new Car(10, 2, 0);
            return car;

        }

        // О статичных методах
        public static Car CreateCar()
        {
            //Car c = new Car(10, 2, 0);
            //return c;
            return new Car(10, 2, 0);
        }

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

        public int SetSize(int width, int height = 10)
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

        public int Fact(int f)
        {
            if (f == 1) return 1;
            return Fact(f - 1) * f;
        }
    }
}
