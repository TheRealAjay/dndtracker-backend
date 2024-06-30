using System.Text.Json.Serialization;

namespace dndtracker.Models.Character;

public class Class
{
    public int Id { get; set; }
    
    public ClassTypeEnum ClassType { get; set; } //TODO: make customisable

    public enum ClassTypeEnum
    {
        Barbarian,
        Bard,
        Cleric,
        Druid,
        Fighter,
        Monk,
        Paladin,
        Ranger,
        Rogue,
        Sorcerer,
        Warlock,
        Wizard,
        Custom
    }
}