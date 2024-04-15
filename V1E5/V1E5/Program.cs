using TestProject;

Car vasinacar = new Car();
vasinacar.SetGear(2);

Car petinacar = new Car();
Console.WriteLine(petinacar.Gear);
petinacar.SetGear(3);
Console.WriteLine(petinacar.Gear);

int newheight;
int w = 9;
int h = 1;  
int newwidth = petinacar.SetSize(ref w, ref h, out newheight);
Console.WriteLine($"{newheight}x{newwidth}");
Console.WriteLine(w);

