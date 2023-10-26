using System;

class Program
{
    static void Main()
    {
        GemstoneRepository gemstoneRepository = new GemstoneRepository();

        //Adding gemstones
        gemstoneRepository.AddGemstone(new Gemstone { Id = 1, Name = "Diamond", Weight = 2.5, Color = "Clear" });
        gemstoneRepository.AddGemstone(new Gemstone { Id = 2, Name = "Ruby", Weight = 1.8, Color = "Red" });
        gemstoneRepository.AddGemstone(new Gemstone { Id = 3, Name = "Sapphire", Weight = 2.2, Color = "Blue" });

        //Displaying gemstones
        Console.WriteLine("List of Gemstones:");
        gemstoneRepository.DisplayGemstones();


        Console.ReadLine(); 
}
