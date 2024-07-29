namespace SuppliesForSchool;

class Program
{
    static void Main(string[] args)
    {
        double packPensPrice = 5.80;
        double packMarkersPrice = 7.20;
        double literDetergentPrice = 1.20;

        int packPens = int.Parse(Console.ReadLine());
        int packMarkers = int.Parse(Console.ReadLine());
        int litersDetergent = int.Parse(Console.ReadLine());
        int sale = int.Parse(Console.ReadLine());

        double summ = (packPens * packPensPrice) + (packMarkers * packMarkersPrice) +
                       (litersDetergent * literDetergentPrice);
        double saleProcent = sale * 0.01;
        double summAfterSale = summ - (summ * saleProcent);
        
        Console.WriteLine(summAfterSale);
    }
}