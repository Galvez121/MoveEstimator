using System;

class Program
{
    public static void Main(string[] args)
    {
        // Module 2 Exercise 2.2

        //  Malcolm Movers charges a base rate of $200 per move plus $150 per hour and $2 per mile.

        const int BaseRate = 200;

        Console.WriteLine("Enter the number of hours worked: ");
        double hours = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the number of miles driven: ");
        double miles = Convert.ToDouble(Console.ReadLine());

        //  Calculate the total cost of the move.
        double total = BaseRate + (hours * 150) + (miles * 2);

        Console.WriteLine($"The total cost of the move is ${total}");
    }
}