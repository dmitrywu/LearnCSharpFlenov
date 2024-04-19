using TestProject;

Car vasinacar = new Car(9, 9, 0);
Car petinacar = new Car(9, 9, 0);

Console.WriteLine(vasinacar==petinacar);
Console.WriteLine(vasinacar.Equals(petinacar));

CarStruct cs1 = new CarStruct(10, 10);
CarStruct cs2 = new CarStruct(10, 10);

Console.WriteLine(cs1.Equals(cs2));

Console.WriteLine("Size = " + cs1.GetSize());


Engine e = new Engine();
e.Code = "12";
e.Volume = 10;

Console.WriteLine("Code = " + e.Code);