namespace Builder.Didactical.Problem
{
    public class Car
    {
        public int Seats { get; set; }
        public int Doors { get; set; }
        public string Engine { get; set; }
        public double Kilometers { get; set; }
        public string GearBox { get; set; }
        public string Color { get; set; }
        public bool HasGPS { get; set; }

        public Car(){ }
        public Car(int seats, int doors, string engine, double kilometers, string gearBox, string color, bool hasGPS)
        {
            Seats = seats;
            Doors = doors;
            Engine = engine;
            Kilometers = kilometers;
            GearBox = gearBox;
            Color = color;
            HasGPS = hasGPS;
        }

        public override string ToString()
        {
            return $"Number of Seats: {Seats}\n" +
                   $"Number of Doors: {Doors}\n" +
                   $"Engine: {Engine}\n" +
                   $"Kilometers: {Kilometers}\n" +
                   $"GearBox: {GearBox}\n" +
                   $"Color: {Color}\n" +
                   $"GPS Included: { HasGPS }";
        }
    }
}
