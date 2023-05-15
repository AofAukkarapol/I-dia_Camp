using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter(Vmax):");
        double Vmax = double.Parse(Console.ReadLine());

        Console.Write("Enter(Vdrink):");
        double Vdrink = double.Parse(Console.ReadLine());

        Console.Write("Enter(Vfill):");
        double Vfill = double.Parse(Console.ReadLine());

        Console.Write("Enter(Tdrink):");
        int Tdrink = int.Parse(Console.ReadLine());

        Console.Write("Enter(Tfill):");
        int Tfill = int.Parse(Console.ReadLine());

        Console.Write("Enter(Tday):");
        int Tday = int.Parse(Console.ReadLine());

        if (Vdrink <= Vmax && Tday >= Tdrink && Tday >= Tfill)
        {
            
            double remainingWater = Vmax - Vfill;
            if (remainingWater >= Vdrink)
            {
                Console.WriteLine("Enough Water, {0} left", remainingWater);
            }
            else if (remainingWater > 0)
            {
                Console.WriteLine("Not Enough Water");
            }
            else
            {
                Console.WriteLine("Overflow Water");
            }
        }
        else
        {
            Console.WriteLine("Invalid input values.");
        }
    }
}
