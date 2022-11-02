using System;
namespace dataTypes
{
    class Program
    {
        Int32 polyhedral(Int32 sides)
        {
            Random rnd = new Random();
            return rnd.Next(0, sides + 1);
        }
        Int32 clamp(double input, Int32 maximum)
        {
            if (input > maximum)
            {
                return maximum;
            }
            else
            {
                return Convert.ToInt32(input);
            }
        }
        bool leapYear(Int32 year)
        {
            if (year % 4 == 0 && year % 100 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        Int32 hourToDay(double hours)
        {
            return Convert.ToInt32(Math.Floor(hours / 24));
        }
        Int32 diceGame(Int32 d1, Int32 d2, Int32 d3)
        {
            if (d1 == d2 && d2 == d3)
            {
                return d1 + d2 + d3;
            }
            else if (d1 == d2)
            {
                return (d1 + d2) - d3;
            }
            else if (d2 == d3)
            {
                return (d2 + d3) - d1;
            }
            else if (d1 == d3)
            {
                return (d1 + d3) - d2;
            }
            else
            {
                return 0;
            }
        }
        bool divisible(double n1, double n2)
        {
            if (n2 == 0)
            {
                return false;
            }
            else if (n1 % n2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        double dogYears(double years)
        {
            if (years <= 2)
            {
                return 12 * years;
            }
            else
            {
                return (24 + 6 * years) - 2;
            }
        }
        static string charging(double minutes)
        {
            if (minutes < 15){
                return "Cost: £4.00 \nPoints: 22";
            }
            else
            {
                string Cost = Convert.ToString(Math.Round(1 + 0.2 * minutes, 2));
                string Points = Convert.ToString(Math.Floor(1.5 * minutes));
                string screen = $"Cost: £{Cost}\nPoints: {Points}";
                return screen;
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(charging(30));
        }

    }
}