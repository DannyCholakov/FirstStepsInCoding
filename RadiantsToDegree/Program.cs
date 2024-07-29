namespace RadiantsToDegree;

class Program
{
    static void Main(string[] args)
    {
        double radiant = double.Parse(Console.ReadLine());
        double degree = radiant * 180 / Math.PI;
        Console.WriteLine(degree);
    }
}