namespace Builder.Didactical.Solution
{
    public interface ICarBuilder
    {
        ICarBuilder WithSeats(int seats);
        ICarBuilder WithDoors(int doors);
        ICarBuilder WithEngine(string engine);
        ICarBuilder WithKilometers(double kilometers);
        ICarBuilder WithGearBox(string gearBox);
        ICarBuilder WithColor(string color);
        ICarBuilder IncludeGPS();
        void Reset();
        Car Build();
    }
}
