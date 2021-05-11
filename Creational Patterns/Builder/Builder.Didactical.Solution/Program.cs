using System;

namespace Builder.Didactical.Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new CarBuilder();
            var director = new CarBuilderDirector();

            var suvCar = director.ConstructSUVCar(builder);
            Console.WriteLine("SUV CAR\n----------");
            Console.WriteLine(suvCar.ToString() + "\n");

            var sportCar = director.ConstructSportCar(builder);
            Console.WriteLine("SPORT CAR\n----------");
            Console.WriteLine(sportCar.ToString() + "\n");          

            //Without Director
            var customCarBuilder = new CarBuilder();
            var customCar = customCarBuilder
                                .WithColor("YELLOW")
                                .WithDoors(3)
                                .WithSeats(3)
                                .Build();

            Console.WriteLine("CUSTOM CAR\n----------");
            Console.WriteLine(customCar.ToString() + "\n");
        }
    }
}
