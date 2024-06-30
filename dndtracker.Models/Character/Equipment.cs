namespace dndtracker.Models.Character;

public class Equipment
{
    public int Id { get; set; }

    public string? Name { get; set; }
    public int Quantity { get; set; }
    public int Weight { get; set; } // weight is stored in gram
}