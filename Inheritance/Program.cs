namespace Inheritance
{
    class Animal
    {
        public string Species { get; set; }
        public int Age { get; set; }
        public string Habitat { get; set; }
        public string Sound { get; set; }
    }

    class Bird : Animal
    {
        public string FeatherColor { get; set; }
        public int WingSpan { get; set; }
        public bool CanFly { get; set; }
        public string BeakShape { get; set; }
    }

    class Reptile : Animal
    {
        public string ScaleType { get; set; }
        public bool HasLegs { get; set; }
        public bool CanSwim { get; set; }
        public bool IsColdBlooded { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bird myBird = new Bird
            {
                Species = "Eagle",
                Age = 5,
                Habitat = "Mountains",
                Sound = "Screech",
                FeatherColor = "Brown",
                WingSpan = 6,
                CanFly = true,
                BeakShape = "Hooked"
            };

            Console.WriteLine("Bird:");
            Console.WriteLine($"Species: {myBird.Species}");
            Console.WriteLine($"Age: {myBird.Age}");
            Console.WriteLine($"Habitat: {myBird.Habitat}");
            Console.WriteLine($"Sound: {myBird.Sound}");
            Console.WriteLine($"Feather Color: {myBird.FeatherColor}");
            Console.WriteLine($"Wing Span: {myBird.WingSpan} feet");
            Console.WriteLine($"Can Fly: {myBird.CanFly}");
            Console.WriteLine($"Beak Shape: {myBird.BeakShape}");
            Console.WriteLine();

            Reptile myReptile = new Reptile
            {
                Species = "Crocodile",
                Age = 10,
                Habitat = "Swamp",
                Sound = "Roar",
                ScaleType = "Scutes",
                HasLegs = true,
                CanSwim = true,
                IsColdBlooded = true
            };

            Console.WriteLine("Reptile:");
            Console.WriteLine($"Species: {myReptile.Species}");
            Console.WriteLine($"Age: {myReptile.Age}");
            Console.WriteLine($"Habitat: {myReptile.Habitat}");
            Console.WriteLine($"Sound: {myReptile.Sound}");
            Console.WriteLine($"Scale Type: {myReptile.ScaleType}");
            Console.WriteLine($"Has Legs: {myReptile.HasLegs}");
            Console.WriteLine($"Can Swim: {myReptile.CanSwim}");
            Console.WriteLine($"Is Cold-Blooded: {myReptile.IsColdBlooded}");
        }
    }
}
