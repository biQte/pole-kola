namespace pole_kola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liczenie pola koła");
            Console.WriteLine("Podaj promień koła: ");
            double radius = double.Parse(Console.ReadLine()); 

            double pi = Math.Round((Math.PI), 2);

            Console.WriteLine("Pole koła wynosi: " + Math.Round((pi * Math.Pow(radius, 2)), 2) + " jednostek kwadratowych");
        }
    }
}