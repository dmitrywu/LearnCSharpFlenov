using TestProject;

Car vasinacar = new Car() { Width = 10, Height = 20 };
Car petinacar = new Car(9, 9, 0);

Bmw320i c = new Bmw320i(10, 20, 0, 15) { Height = 100 };
Car bmwyc = new Bmw320i(10, 20, 0, 15);
//((Bmw320d)bmwyc).Length = 0; -> crash
//(bmwyc as Bmw320d).Length = 0; -> null
Console.WriteLine("Width " + c.Width);
Console.WriteLine("Size " + c.GetSize());
Console.WriteLine("Size " + bmwyc.GetSize());

vasinacar.Engine.Volume = 10;

if (c is  Bmw320i) (c as Bmw320i)!.Length = 10;

//Object petinacar = new Car(9, 9, 0);
//if (petinacar is Car) Console.WriteLine("Petina Car");
//petinacar = 10;
//if (petinacar is Int32) Console.WriteLine("Petina Int32");
//petinacar = "X3";
//if(petinacar is String) Console.WriteLine("Petina String");