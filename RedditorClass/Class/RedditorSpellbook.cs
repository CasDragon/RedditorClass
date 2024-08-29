using BlueprintCore.Blueprints.Configurators.Classes.Spells;
using BlueprintCore.Blueprints.References;
using Kingmaker.Blueprints.Classes.Spells;
using RedditorClass.Utils;
using Kingmaker.EntitySystem.Stats;
using BlueprintCore.Blueprints.Configurators.Classes;

namespace RedditorClass.Class
{
    internal class RedditorSpellbook
    {
        private const string spellbookname = "RedditSpellbook";
        private const string displayname = "RedditSpellbook.Name";
        private const string SpellsPerDay = "RedditSpellsPerDay";

        public static BlueprintSpellbook Configure()
        {
            BlueprintSpellbook x = SpellbookConfigurator.New(spellbookname, Guids.redditorspellbook)
                .SetName(displayname)
                .SetSpellsPerDay(GetSpellSlots())
                .SetSpellsKnown(SpellsTableRefs.SorcererSpellsKnownTable.Reference.Get())
                .SetSpellList(SpellListRefs.WizardSpellList.Reference.Get())
                .SetCastingAttribute(StatType.Charisma)
                .SetSpontaneous(true)
                .SetIsArcane(true)
                .SetAllSpellsKnown(true)
                .Configure();

            FeatureSelectMythicSpellbookConfigurator.For(FeatureSelectMythicSpellbookRefs.AngelIncorporateSpellbook)
                .AddToAllowedSpellbooks(x)
                .Configure();

            FeatureSelectMythicSpellbookConfigurator.For(FeatureSelectMythicSpellbookRefs.LichIncorporateSpellbookFeature)
                .AddToAllowedSpellbooks(x)
                .Configure();

            return x;
        }
        public static BlueprintSpellsTable GetSpellSlots()
        {
            var wizardSpellSlots = SpellsTableRefs.WizardSpellLevels.Reference.Get();
            return SpellsTableConfigurator.New(SpellsPerDay, Guids.redditorspellsperday)
                .SetLevels(wizardSpellSlots.Levels)
                .Configure();
        }
    }
}
