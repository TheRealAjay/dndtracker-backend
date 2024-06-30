using System.Text.Json.Serialization;

namespace dndtracker.Models.Character;

public class Ability
{
    public int Id { get; set; }

    public int Score { get; set; }
    public int Modifier { get; set; }
}