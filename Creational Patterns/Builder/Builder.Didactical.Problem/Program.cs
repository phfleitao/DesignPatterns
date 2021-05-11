using System;

namespace Builder.Didactical.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Problems: 
                -   Its difficult to read the constructor's parameters;
                -   If we have optional parameters in the constructor we need to follow the order and pass null to the cases that we dont need;
                -   the logical part that differentiates the creation of a sports car or a suv car is here in the client.
             */

            var suvCar = new Car(7, 5, "V8", 160, "AUTOMATIC", "BLUE", true);
            Console.WriteLine("SUV CAR\n----------");
            Console.WriteLine(suvCar.ToString() + "\n");

            var sportCar = new Car(2, 2, "V8 Turbo", 50.5, "MANUAL", "RED", false);
            Console.WriteLine("SPORT CAR\n----------");
            Console.WriteLine(sportCar.ToString() + "\n");            
        }
    }
}
