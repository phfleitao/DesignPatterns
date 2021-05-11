namespace Builder.Didactical.Solution
{
    public class CarBuilder : ICarBuilder
    {
        private Car _car;

        public CarBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _car = new Car();
            _car.GearBox = "MANUAL";
            _car.HasGPS = false;
        }

        public ICarBuilder IncludeGPS()
        {
            _car.HasGPS = true;
            return this;
        }

        public ICarBuilder WithColor(string color)
        {
            _car.Color = color;
            return this;
        }

        public ICarBuilder WithDoors(int doors)
        {
            _car.Doors = doors;
            return this;
        }

        public ICarBuilder WithEngine(string engine)
        {
            _car.Engine = engine;
            return this;
        }

        public ICarBuilder WithGearBox(string gearBox)
        {
            _car.GearBox = gearBox;
            return this;
        }

        public ICarBuilder WithKilometers(double kilometers)
        {
            _car.Kilometers = kilometers;
            return this;
        }

        public ICarBuilder WithSeats(int seats)
        {
            _car.Seats = seats;
            return this;
        }

        public Car Build()
        {
            return this._car;
        }
    }
}
