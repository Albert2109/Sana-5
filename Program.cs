using Sana05;
using System.Dynamic;

internal class Program
{
    private static void Main(string[] args)
    {
    
        MyDate startDate2 = new MyDate(2023, 11, 23, 11, 00); 

        MyDate finishDate = new MyDate(2023, 11, 24, 16, 00);

   
        Airplane flightToWashington = new Airplane("Інше", startDate2, "Вашингтон", finishDate);

       
        int totalTime2 = flightToWashington.GetTotalTime();

        Console.WriteLine("Час поїздки  " + totalTime2 + " хвилин");
        bool today = flightToWashington.IsArrivingToday();
            Console.WriteLine(today);
    }
}