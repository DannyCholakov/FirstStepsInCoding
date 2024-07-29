namespace FoodDelivery;

class Program
{
    static void Main(string[] args)
    {
        double chickenMenu = 10.35;
        double fishMenu = 12.40;
        double vegMenu = 8.15;

        int chickenMenuNum = int.Parse(Console.ReadLine());
        int fishMenuNum = int.Parse(Console.ReadLine());
        int vegMenuNum = int.Parse(Console.ReadLine());

        double summ = (chickenMenu * chickenMenuNum + fishMenuNum*fishMenu + vegMenu * vegMenuNum)*1.20 + 2.50;
        Console.WriteLine(summ);
        
    }
}