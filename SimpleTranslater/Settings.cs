using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Synthesis.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTranslator;

public class Settings
{
    [SynthesisTooltip(@"")]
    public bool ResolveFromOrigin = false;

    [SynthesisTooltip(@"If true, all entities will be translated. If false, only entities patched by synthesis will be translated")]
    public bool PatchAllEntity = false;

    public bool WhiteListMode = false;
    [SynthesisTooltip(@"Referenced mod that translated name comes from (Only available while whitelist mode)")]
    public List<ModKey> WhiteList = new()
    {
        ModKey.FromFileName("Skyrim.esm"),
        ModKey.FromFileName("Update.esm"),
        ModKey.FromFileName("Dawnguard.esm"),
        ModKey.FromFileName("HearthFires.esm"),
        ModKey.FromFileName("Dragonborn.esm"),
        ModKey.FromFileName("Unofficial Skyrim Special Edition Patch.esp"),
        ModKey.FromFileName("ccBGSSSE001-Fish.esm")
    };
    [SynthesisTooltip(@"Referenced Mod That Will Skipped (Available while blacklist mode0")]
    public List<ModKey> BlackList = new();

    public bool IgnorePatchMods = true;
    public List<ModKey> IncludedPatchMods = new List<ModKey>()
    {
        ModKey.FromFileName("Unofficial Skyrim Special Edition Patch.esp"),
        ModKey.FromFileName("Unofficial Skyrim Modders Patch.esp")
    };

    public bool Weapon = true;
    public bool Armor = true;
    public bool Npc = true;
    public bool WorldSpace = true;
    public bool Perk = true;
    public bool Quest = true;
    public bool Container = true;
    public bool Item = true;

    public bool Verbose = true;

    public Dictionary<string, string> CustomDictionary = new()
    {
        { "Horse", "马" },
        { "Skull", "头骨" },
        { "Blackreach", "黑境" }
    };
}
