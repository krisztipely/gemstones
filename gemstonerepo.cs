using System;
using System.Collections.Generic;

public class GemstoneRepository
{
    private List<Gemstone> gemstones;

    public GemstoneRepository()
    {
        gemstones = new List<Gemstone>();
    }

    public void AddGemstone(Gemstone gemstone)
    {
        gemstones.Add(gemstone);
    }

    public void DisplayGemstones()
    {
        foreach (var gemstone in gemstones)
        {
            Console.WriteLine(gemstone);
        }
    }
}
