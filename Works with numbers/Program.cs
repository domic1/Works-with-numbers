namespace Done_is_better_than_good
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;

            Console.WriteLine("Podaj pierwszą cyfrę");
            number1 =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Podaj drugą cyfrę");
            number2 =Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Wynik:" + (number1 + number2));

        }
    }
}
