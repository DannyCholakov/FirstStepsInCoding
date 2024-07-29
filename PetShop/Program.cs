namespace PetShop;

class Program
{
    static void Main(string[] args)
    {
        int dogFoodKG = int.Parse(Console.ReadLine());
        int catFoodKG = int.Parse(Console.ReadLine());
        double dogFoodSumm = dogFoodKG * 2.50;
        double catFoodSumm = catFoodKG * 4;
        double summ = dogFoodSumm + catFoodSumm;
        Console.WriteLine($"{summ} lv.");
    }
}