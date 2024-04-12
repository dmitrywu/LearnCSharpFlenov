using TestProject;

Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkCyan;

Car vasinaMashina = new Car();
Car petinaMashina = new Car();

vasinaMashina.Width = 10;
vasinaMashina.Height = 5;

petinaMashina.Width = -9;
petinaMashina.Height = 4;

Console.WriteLine(vasinaMashina.Height);
Console.WriteLine(petinaMashina.Height);

vasinaMashina.Start();
petinaMashina.Start();

Console.WriteLine($"Size = {vasinaMashina.GetSize()}");
Console.WriteLine($"Size = {petinaMashina.GetSize()}");

Car car3 = new Car();
Console.WriteLine(car3.GetSize());