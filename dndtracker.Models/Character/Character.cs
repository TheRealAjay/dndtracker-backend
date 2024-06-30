namespace dndtracker.Models.Character;

public class Character
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public Race? Race { get; set; }
    public Class? Class { get; set; }

    public Ability? Str { get; set; }
    public Ability? Dex { get; set; }
    public Ability? Con { get; set; }
    public Ability? Int { get; set; }
    public Ability? Wis { get; set; }
    public Ability? Cha { get; set; }
    
    public ICollection<Equipment>? Equipment { get; set; }
}