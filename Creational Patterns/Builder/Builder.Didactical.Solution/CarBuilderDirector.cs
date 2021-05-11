using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Didactical.Solution
{
    public class CarBuilderDirector
    {
        public Car ConstructSportCar(ICarBuilder builder)
        {
            builder.Reset();
            return builder
                    .WithColor("RED")
                    .WithEngine("V8 Turbo")
                    .WithKilometers(50.5)
                    .WithDoors(2)
                    .WithSeats(2)
                    .Build();
        }

        public Car ConstructSUVCar(ICarBuilder builder)
        {
            builder.Reset();
            return builder
                    .WithColor("BLUE")
                    .WithGearBox("AUTOMATIC")
                    .WithEngine("V8")
                    .WithKilometers(160)
                    .WithDoors(5)
                    .WithSeats(7)
                    .IncludeGPS()
                    .Build();
        }
    }
}
