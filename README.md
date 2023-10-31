# gemstones
This C# code defines a simple gemstone management system with the ability to add gemstones to a repository and display the list of gemstones with their details.

## Gemstone Repository Class
The GemstoneRepository class manages a list of gemstones and provides methods for adding gemstones (AddGemstone) and displaying all gemstones (DisplayGemstones).

## Gemstone Class
The Gemstone class represents an individual gemstone with properties such as ID, Name, Weight, and Color. The ToString method is overridden to provide a formatted string representation of a gemstone.

## Example Usage
```
class Program
{
    static void Main()
    {
        GemstoneRepository gemstoneRepository = new GemstoneRepository();

        // Adding gemstones
        gemstoneRepository.AddGemstone(new Gemstone { Id = 1, Name = "Diamond", Weight = 2.5, Color = "Clear" });
        gemstoneRepository.AddGemstone(new Gemstone { Id = 2, Name = "Ruby", Weight = 1.8, Color = "Red" });
        gemstoneRepository.AddGemstone(new Gemstone { Id = 3, Name = "Sapphire", Weight = 2.2, Color = "Blue" });

        // Displaying gemstones
        Console.WriteLine("List of Gemstones:");
        gemstoneRepository.DisplayGemstones();

        Console.ReadLine();
    }
}
```
## How to Use

**Clone the repository to your local machine:**
```
git clone https://github.com/krisztipely/gemstones.git
```
Open the project in your preferred C# development environment.

Run the program.cs file to see the example usage.

## License
MIT 2023, Krisztina-Ronkainen Lakner
