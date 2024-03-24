namespace AnimalSound
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>
            {
                new Cat(),
                new Goat(),
                new Cow()
            };

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.Type} makes sound: {animal.MakeSound()}");
            }
        }
    }
}