namespace VacationBookList;

class Program
{
    static void Main(string[] args)
    {
        int numberOfPages = int.Parse(Console.ReadLine());
        int pagesReadPerHour = int.Parse(Console.ReadLine());
        int daysToRead = int.Parse(Console.ReadLine());

        int hoursPerDayNeeded = (numberOfPages / pagesReadPerHour) / daysToRead;
        Console.WriteLine(hoursPerDayNeeded);
    }
}