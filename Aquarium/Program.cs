namespace Aquarium;

class Program
{
    static void Main(string[] args)
    {
        int lenght = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
        double procentNonWater = double.Parse(Console.ReadLine());

        double volume = (lenght * width * height) * 0.001;
        double procent = procentNonWater * 0.01;
        double summ = volume * (1 - procent);
        
        Console.WriteLine(summ);
    }
}