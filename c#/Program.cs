namespace program
{
    internal class Program
    {
        public static void Main()
        {
            Trojkat trojkat = new Trojkat("zielony", new Punkt(1, 1), new Punkt(2, 5), new Punkt(3, 4));
            Console.WriteLine(trojkat);

            Czworokat czworokat = new Czworokat("czerwony", new Punkt(2, 2), new Punkt(3, 5), new Punkt(1, 3),  new Punkt(8, 1));
            Console.WriteLine(czworokat);

            Prostokat prostokat = new Prostokat("fioletowy", new Punkt(1, 1), new Punkt(5, 5));
            Console.WriteLine(prostokat);

            Kwadrat kwadrat = new Kwadrat("zolty", new Punkt(5, 5), 2);
            Console.WriteLine(kwadrat);
        }
    }
}