namespace CalculatorDeposit;

class Program
{
    static void Main(string[] args)
    {
       double depositedSumm = double.Parse(Console.ReadLine());
       int timeOfDeposit = int.Parse(Console.ReadLine());
       double lihvenProcent = double.Parse(Console.ReadLine());

       double summ = Math.Round(depositedSumm + timeOfDeposit * ((depositedSumm * lihvenProcent/100) / 12), 2);
       Console.WriteLine(summ);
    }
}