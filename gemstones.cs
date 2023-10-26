public class Gemstone
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Weight { get; set; }
    public string Color { get; set; }

    public override string ToString()
    {
        return $"{Id}. {Name} - {Weight} carats, Color: {Color}";
    }
}
