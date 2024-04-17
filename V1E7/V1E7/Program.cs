using TestProject;

Car vasinacar = new Car(10, 10, 1);
Car petinacar = new Car(9,9,0);

Bmw320i bmwy = new Bmw320i(10,20,0,15);
Car bmwyc = new Bmw320i(10, 20, 0, 15);
//((Bmw320d)bmwyc).Length = 0; -> crash
//(bmwyc as Bmw320d).Length = 0; -> null
Console.WriteLine("Width "+ bmwy.Width);
Console.WriteLine("Size " + bmwy.GetSize());
Console.WriteLine("Size " + bmwyc.GetSize());