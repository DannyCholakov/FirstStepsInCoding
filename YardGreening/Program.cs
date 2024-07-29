namespace YardGreening;

class Program
{
    static void Main(string[] args)
    {
        double greenSpace = double.Parse(Console.ReadLine());
        double priceOfJobBeforeSale = greenSpace * 7.61;
        double priceOfJob = priceOfJobBeforeSale * 0.82;
        double sale = priceOfJobBeforeSale * 0.18;
        
        Console.WriteLine($"The final price is: {Math.Round(priceOfJob, 2)} lv.");
        Console.WriteLine($"The discount is: {Math.Round(sale, 2)} lv.");
    }
}