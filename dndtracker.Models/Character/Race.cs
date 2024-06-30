using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace dndtracker.Models.Character;

public class Race
{
    public int Id { get; set; }

    public RaceTypeEnum RaceType { get; set; } //TODO: rewrite to manual get and set like Draconian
    public string? CustomRaceType { get; set; }

    public SubRaceTypeEnum SubRaceType { get; set; } //TODO: rewrite to manual get and set like Draconian
    public string? CustomSubRaceType { get; set; }

    private DraconianAncestryEnum _draconianAncestry;
    private string? _customDraconianAncestry;

    public int Age { get; set; }
    public int Size { get; set; } // height is stored in mm
    public int Speed { get; set; }

    public enum RaceTypeEnum
    {
        Dwarf,
        Elf,
        Halfling,
        Human,
        Dragonborn,
        Gnome,
        HalfElf,
        HalfOrc,
        Tiefling,
        Custom
    }

    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum SubRaceTypeEnum
    {
        Dwarf_HillDwarf,
        Dwarf_MountainDwarf,
        Elf_HighElf,
        Elf_WoodElf,
        Elf_DarkElf,
        Halfling_Lightfoot,
        Halfling_Stout,
        Custom
    }

    public enum DraconianAncestryEnum
    {
        Black,
        Blue,
        Brass,
        Bronze,
        Copper,
        Gold,
        Green,
        Red,
        Silver,
        White,
        Custom
    }


    public string GetDraconianAncestry()
    {
        if (_draconianAncestry == DraconianAncestryEnum.Custom)
        {
            return _customDraconianAncestry ?? "No Draconian Ancestry";
        }

        return _draconianAncestry.ToString();
    }

    public bool SetDraconianAncestry(DraconianAncestryEnum ancestry, string? customAncestry = null)
    {
        if (RaceType == RaceTypeEnum.Dragonborn)
        {
            if (ancestry != DraconianAncestryEnum.Custom)
            {
                _draconianAncestry = ancestry;
            }
            else if (customAncestry != null)
            {
                _draconianAncestry = DraconianAncestryEnum.Custom;
                _customDraconianAncestry = customAncestry;
            }
            else
            {
                return false;
            }

            return true;
        }

        return false;
    }
}