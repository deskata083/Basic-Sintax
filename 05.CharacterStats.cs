namespace CharacterStats
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            int currentHelth = int.Parse(Console.ReadLine());
            int maxHelth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |" +
                $"{new string('|', currentHelth)}" +
                $"{new string('.', maxHelth - currentHelth)}|");
            Console.WriteLine($"Energy: |" +
                $"{new string('|', currentEnergy)}" +
                $"{new string('.', maxEnergy - currentEnergy)}|");
        }
    }
}
