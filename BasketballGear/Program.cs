namespace BasketballGear;

class Program
{
    static void Main(string[] args)
    {
        int yearTax = int.Parse(Console.ReadLine());
        double shoes = yearTax * 0.60;
        double ekip = shoes * 0.80;
        double ball = ekip * 0.25;
        double accessories = ball * 0.20;
        double summ = yearTax + shoes + ekip + ball + accessories;
        Console.WriteLine(summ);
    }
}