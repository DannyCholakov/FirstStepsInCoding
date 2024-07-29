namespace Repainting;

class Program
{
    static void Main(string[] args)
    {
        double nailonPrice = 1.50;
        double paintPrice = 14.50;
        double paintBusterPrice = 5.00;
        
        int nailon = int.Parse(Console.ReadLine());
        int paint = int.Parse(Console.ReadLine());
        int paintBuster = int.Parse(Console.ReadLine());
        int workingHours = int.Parse(Console.ReadLine());

        double summ = paintPrice * (paint * 1.10) + (nailon + 2) * nailonPrice + paintBuster * paintBusterPrice + 0.40;
        double workersPrice = workingHours*(summ * 0.3);
        Console.WriteLine(summ+workersPrice);
    }
}