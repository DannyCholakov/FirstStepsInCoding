namespace ProjectCreation;

class Program
{
    static void Main(string[] args)
    {
        string architectName = Console.ReadLine();
        double numberOfProjects = double.Parse(Console.ReadLine());
        double hoursNeeded = numberOfProjects * 3;
        Console.WriteLine($"The architect {architectName} will need {hoursNeeded} hours to complete {numberOfProjects} project/s.");
    }
}