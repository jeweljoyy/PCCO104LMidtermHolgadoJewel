using System;

class Program
{
    public static void Main(string[] args)
    {
        int fanSpeed;
        bool oscillate;

        while (true)
        {
            Console.Write("Enter fan speed (1,2 or 3): ");
            if (int.TryParse(Console.ReadLine(), out fanSpeed) && (fanSpeed >= 1 && fanSpeed <= 3))
                break;
            Console.WriteLine("Invalid fan speed. Please try again.");
        }

        while (true)
        {
            Console.Write("Oscillate fan? (y/n): ");
            string input = Console.ReadLine().ToUpper();
            if (input == "Y")
            {
                oscillate = true;
                break;
            }
            else if (input == "N")
            {
                oscillate = false;
                break;
            }
            Console.WriteLine("Invalid input. Please try again.");
        }

        int baseFanPower = 10;
        int fanPowerOutput = baseFanPower * fanSpeed;
        if (fanPowerOutput > 30)
            fanPowerOutput = 30;

        if (oscillate)
        {
            for (int i = 1; i <= fanPowerOutput; i++)
            {
                Console.WriteLine("~".PadLeft(i, '~'));
            }
            for (int i = fanPowerOutput - 1; i >= 1; i--)
            {
                Console.WriteLine("~".PadLeft(i, '~'));
            }
        }
        else
        {
            Console.WriteLine("~".PadLeft(fanPowerOutput, '~'));
        }
    }
}