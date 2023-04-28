using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Synthesis.Settings;

namespace SynStringMerger;

public record Settings
{
    public Dictionary<string, string> CustomDictionary = new();

    [SynthesisSettingName("High Priority Mods")]
    [SynthesisTooltip("Usually same with your plugin load order in mod organizer")]
    public List<ModKey> HighPriorityMods = new()
    {
        ModKey.FromFileName("Unofficial Skyrim Special Edition Patch.esp"),
        ModKey.FromFileName("Vokrii - Minimalistic Perks of Skyrim.esp"),
        ModKey.FromFileName("Odin - Skyrim Magic Overhaul.esp"),
        ModKey.FromFileName("Odin - Vokrii Compatibility Patch.esp"),
    };

    [SynthesisTooltip(@"Has no effect for High Priority Mods")]
    public bool ResolveFromOrigin = true;

    [SynthesisTooltip(@"If true, entities that not changed will not included by this patch")]
    public bool SkipSameString = true;

    [SynthesisTooltip(@"Skip Names That All Characters Are English ")]
    public bool SkipEnglishString = true;

    public string LogPath = "";

    [SynthesisTooltip(@"If true, all entities will be translated. If false, only entities patched by synthesis will be translated")]
    public bool PatchAllRecords = false;

    public bool WhiteListMode = false;
    [SynthesisTooltip(@"Referenced mod that translated name comes from (Only available while whitelist mode)")]
    public List<ModKey> WhiteList = new();
    [SynthesisTooltip(@"Referenced Mod That Will Skipped (Available while blacklist mode0")]
    public List<ModKey> BlackList = new();

    public bool IgnorePatchMods = true;
    public List<ModKey> IncludedPatchMods = new()
    {
    };

    public bool Weapon = true;
    public bool Armor = true;
    public bool Npc = true;
    public bool WorldSpace = true;
    public bool Perk = true;
    public bool Quest = true;
    public bool Container = true;
    public bool Item = true;
    public bool Books = true;

    public bool Verbose = true;
}
