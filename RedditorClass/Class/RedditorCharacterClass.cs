using BlueprintCore.Blueprints.Configurators.Classes;
using BlueprintCore.Blueprints.References;
using BlueprintCore.Utils;
using Kingmaker.Blueprints.Classes;
using Kingmaker.Blueprints.Root;
using Kingmaker.Blueprints;
using Kingmaker.RuleSystem;
using RedditorClass.Utils;
using Kingmaker.EntitySystem.Stats;
using RedditorClass.Features;

namespace RedditorClass.Class
{
    internal class RedditorCharacterClass
    {
        private const string classname = "Redditor";
        private const string displayname = "Redditor.Name";
        private const string displaydescription = "Redditor.Description";
        private const string displayshortdescription = "Redditor.ShortDescription";
        public static void Configure()
        {
            BlueprintCharacterClass magicclass = CharacterClassConfigurator.New(classname, Guids.redditorcharacterclass)
            .SetLocalizedName(displayname)
            .SetLocalizedDescription(displaydescription)
            .SetLocalizedDescriptionShort(displayshortdescription)
            .SetIsMythic(false)
            .SetPrestigeClass(false)
            .SetHitDie(DiceType.D8)
            .SetHideIfRestricted(false)
            .SetIsDivineCaster(true)
            .SetIsArcaneCaster(false)
            .SetBaseAttackBonus(StatProgressionRefs.BABFull.Reference.Get())
            .SetFortitudeSave(StatProgressionRefs.SavesHigh.Reference.Get())
            .SetReflexSave(StatProgressionRefs.SavesHigh.Reference.Get())
            .SetWillSave(StatProgressionRefs.SavesHigh.Reference.Get())
            .SetStartingGold(500)
            .SetStartingItems(
                ItemWeaponRefs.ColdIronMasterworkHeavyCrossbow.Reference.Get(),
                ItemArmorRefs.LeatherStandard.Reference.Get(),
                ItemEquipmentUsableRefs.PotionOfCureLightWounds.Reference.Get(),
                ItemEquipmentUsableRefs.ScrollOfMageArmor.Reference.Get(),
                ItemEquipmentUsableRefs.ScrollOfMageShield.Reference.Get())
            .SetPrimaryColor(0)
            .SetSecondaryColor(0)
            .SetDifficulty(1)
            .AddPrerequisiteNoClassLevel(CharacterClassRefs.AnimalClass.Reference.Get())
            .AddToMaleEquipmentEntities("65e7ae8b40be4d64ba07d50871719259", "04244d527b8a1f14db79374bc802aaaa")
            .AddToFemaleEquipmentEntities("11266d19b35cb714d96f4c9de08df48e", "64abd9c4d6565de419f394f71a2d496f")
            .SetSpellbook(SpellbookRefs.SorcererSpellbook.Reference.Get())
            .SetProgression(RedditorProgression.Configure())
            .SetSkillPoints(2)
            .AddToClassSkills(
                StatType.SkillMobility,
                StatType.SkillKnowledgeWorld,
                StatType.SkillKnowledgeArcana,
                StatType.SkillUseMagicDevice,
                StatType.SkillAthletics,
                StatType.SkillLoreNature,
                StatType.SkillLoreReligion,
                StatType.SkillPerception,
                StatType.SkillPersuasion,
                StatType.SkillStealth,
                StatType.SkillThievery)
            .AddToRecommendedAttributes(StatType.Charisma)
            .AddToSignatureAbilities(Guids.chatocha)
            .Configure();


            BlueprintCharacterClassReference classref = magicclass.ToReference<BlueprintCharacterClassReference>();
            BlueprintRoot root = BlueprintTool.Get<BlueprintRoot>("2d77316c72b9ed44f888ceefc2a131f6");
            root.Progression.m_CharacterClasses = CommonTool.Append(root.Progression.m_CharacterClasses, classref);
        }
    }
}
