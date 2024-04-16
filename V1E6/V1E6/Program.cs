using TestProject;

Car vasinacar = new Car(10, 2, 0);
Car petinacar = new Car(12, 1, 0);

Car presidentscar1 = Car.GetPresidentsCar();
Car presidentscar2 = Car.GetPresidentsCar();

if (vasinacar == petinacar)
{
    Console.WriteLine($"одинаковы");
}
else
{
    Console.WriteLine($"разные");
}

Console.WriteLine(petinacar.Fact(4));