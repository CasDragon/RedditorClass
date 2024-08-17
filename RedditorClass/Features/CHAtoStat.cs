﻿using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using Kingmaker.Blueprints.Classes;
using RedditorClass.Utils;
using Kingmaker.EntitySystem.Stats;
using RedditorClass.Components;

namespace RedditorClass.Features
{
    internal class CHAtoStat
    {
        private const string featurenamecha = "ChaToCha";
        private const string displaynamecha = "ChaToCha.Name";
        private const string displaydescriptioncha = "ChaToCha.Description";
        public static BlueprintFeature ConfigureCHA()
        {
            BlueprintFeature feature = FeatureConfigurator.New(featurenamecha, Guids.chatocha)
                .SetDisplayName(displaynamecha)
                .SetDescription(displaydescriptioncha)
                .AddDerivativeStatBonus(baseStat: StatType.Charisma,
                    descriptor: Kingmaker.Enums.ModifierDescriptor.Inherent,
                    derivativeStat: StatType.Charisma)
                .AddRecalculateOnStatChange(stat: StatType.Charisma)
                .Configure();
            return feature;
        }
        private const string featurenameac = "ChaToAC";
        private const string displaynameac = "ChaToAC.Name";
        private const string displaydescriptionac = "ChaToAC.Description";
        public static BlueprintFeature ConfigureAC()
        {
            BlueprintFeature feature = FeatureConfigurator.New(featurenameac, Guids.chatoac)
                .SetDisplayName(displaynameac)
                .SetDescription(displaydescriptionac)
                .AddDerivativeStatBonus(baseStat: StatType.Charisma,
                    descriptor: Kingmaker.Enums.ModifierDescriptor.Inherent,
                    derivativeStat: StatType.AC)
                .AddRecalculateOnStatChange(stat: StatType.Charisma)
                .Configure();
            return feature;
        }
        private const string featurenamestr = "ChaToStr";
        private const string displaynamestr = "ChaToStr.Name";
        private const string displaydescriptionstr = "ChaToStr.Description";
        public static BlueprintFeature ConfigureSTR()
        {
            BlueprintFeature feature = FeatureConfigurator.New(featurenamestr, Guids.chatostr)
                .SetDisplayName(displaynamestr)
                .SetDescription(displaydescriptionstr)
                .AddDerivativeStatBonus(baseStat: StatType.Charisma,
                    descriptor: Kingmaker.Enums.ModifierDescriptor.Inherent,
                    derivativeStat: StatType.Strength)
                .AddRecalculateOnStatChange(stat: StatType.Charisma)
                .Configure();
            return feature;
        }
        private const string featurenamedex = "ChaToDex";
        private const string displaynamedex = "ChaToDex.Name";
        private const string displaydescriptiondex = "ChaToDex.Description";
        public static BlueprintFeature ConfigureDEX()
        {
            BlueprintFeature feature = FeatureConfigurator.New(featurenamedex, Guids.chatodex)
                .SetDisplayName(displaynamedex)
                .SetDescription(displaydescriptiondex)
                .AddDerivativeStatBonus(baseStat: StatType.Charisma,
                    descriptor: Kingmaker.Enums.ModifierDescriptor.Inherent,
                    derivativeStat: StatType.Dexterity)
                .AddRecalculateOnStatChange(stat: StatType.Charisma)
                .Configure();
            return feature;
        }
        private const string featurenamecon = "ChaToCon";
        private const string displaynamecon = "ChaToCon.Name";
        private const string displaydescriptioncon = "ChaToCon.Description";
        public static BlueprintFeature ConfigureCON()
        {
            BlueprintFeature feature = FeatureConfigurator.New(featurenamecon, Guids.chatocon)
                .SetDisplayName(displaynamecon)
                .SetDescription(displaydescriptioncon)
                .AddDerivativeStatBonus(baseStat: StatType.Charisma,
                    descriptor: Kingmaker.Enums.ModifierDescriptor.Inherent,
                    derivativeStat: StatType.Constitution)
                .AddRecalculateOnStatChange(stat: StatType.Charisma)
                .Configure();
            return feature;
        }
        private const string featurenameint = "ChaToInt";
        private const string displaynameint = "ChaToInt.Name";
        private const string displaydescriptionint = "ChaToInt.Description";
        public static BlueprintFeature ConfigureINT()
        {
            BlueprintFeature feature = FeatureConfigurator.New(featurenameint, Guids.chatoint)
                .SetDisplayName(displaynameint)
                .SetDescription(displaydescriptionint)
                .AddDerivativeStatBonus(baseStat: StatType.Charisma,
                    descriptor: Kingmaker.Enums.ModifierDescriptor.Inherent,
                    derivativeStat: StatType.Intelligence)
                .AddRecalculateOnStatChange(stat: StatType.Charisma)
                .Configure();
            return feature;
        }
        private const string featurenamewis = "ChaToWis";
        private const string displaynamewis = "ChaToWis.Name";
        private const string displaydescriptionwis = "ChaToWis.Description";
        public static BlueprintFeature ConfigureWIS()
        {
            BlueprintFeature feature = FeatureConfigurator.New(featurenamewis, Guids.chatowis)
                .SetDisplayName(displaynamewis)
                .SetDescription(displaydescriptionwis)
                .AddDerivativeStatBonus(baseStat: StatType.Charisma,
                    descriptor: Kingmaker.Enums.ModifierDescriptor.Inherent,
                    derivativeStat: StatType.Wisdom)
                .AddRecalculateOnStatChange(stat: StatType.Charisma)
                .Configure();
            return feature;
        }
        private const string featurenamesaves = "ChaToSaves";
        private const string displaynamesaves = "ChaToSaves.Name";
        private const string displaydescriptionsaves = "ChaToSaves.Description";
        public static BlueprintFeature ConfigureSAVES()
        {
            BlueprintFeature feature = FeatureConfigurator.New(featurenamesaves, Guids.chatosaves)
                .SetDisplayName(displaynamesaves)
                .SetDescription(displaydescriptionsaves)
                .AddDerivativeStatBonus(baseStat: StatType.Charisma,
                    descriptor: Kingmaker.Enums.ModifierDescriptor.Inherent,
                    derivativeStat: StatType.SaveFortitude)
                .AddDerivativeStatBonus(baseStat: StatType.Charisma,
                    descriptor: Kingmaker.Enums.ModifierDescriptor.Inherent,
                    derivativeStat: StatType.SaveReflex)
                .AddDerivativeStatBonus(baseStat: StatType.Charisma,
                    descriptor: Kingmaker.Enums.ModifierDescriptor.Inherent,
                    derivativeStat: StatType.SaveWill)
                .AddRecalculateOnStatChange(stat: StatType.Charisma)
                .Configure();
            return feature;
        }
        private const string featurenameinit = "ChaToInit";
        private const string displaynameinit = "ChaToInit.Name";
        private const string displaydescriptioninit = "ChaToInit.Description";
        public static BlueprintFeature ConfigureINIT()
        {
            BlueprintFeature feature = FeatureConfigurator.New(featurenameinit, Guids.chatoinit)
                .SetDisplayName(displaynameinit)
                .SetDescription(displaydescriptioninit)
                .AddDerivativeStatBonus(baseStat: StatType.Charisma,
                    descriptor: Kingmaker.Enums.ModifierDescriptor.Inherent,
                    derivativeStat: StatType.Initiative)
                .AddRecalculateOnStatChange(stat: StatType.Charisma)
                .Configure();
            return feature;
        }
        private const string featurenamebab = "ChaToBAB";
        private const string displaynamebab = "ChaToBAB.Name";
        private const string displaydescriptionbab = "ChaToBAB.Description";
        public static BlueprintFeature ConfigureBAB()
        {
            BlueprintFeature feature = FeatureConfigurator.New(featurenamebab, Guids.chatobab)
                .SetDisplayName(displaynamebab)
                .SetDescription(displaydescriptionbab)
                .AddDerivativeStatBonus(baseStat: StatType.Charisma,
                    descriptor: Kingmaker.Enums.ModifierDescriptor.Inherent,
                    derivativeStat: StatType.BaseAttackBonus)
                .AddRecalculateOnStatChange(stat: StatType.Charisma)
                .Configure();
            return feature;
        }
        private const string featurenamedam = "ChaToDamage";
        private const string displaynamedam = "ChaToDamage.Name";
        private const string displaydescriptiondam = "ChaToDamage.Description";
        public static BlueprintFeature ConfigureDAM()
        {
            BlueprintFeature feature = FeatureConfigurator.New(featurenamedam, Guids.chatodam)
                .SetDisplayName(displaynamedam)
                .SetDescription(displaydescriptiondam)
                .AddDerivativeStatBonus(baseStat: StatType.Charisma,
                    descriptor: Kingmaker.Enums.ModifierDescriptor.Inherent,
                    derivativeStat: StatType.AdditionalDamage)
                .AddRecalculateOnStatChange(stat: StatType.Charisma)
                .Configure();
            return feature;
        }
        private const string featurenamepspeed = "ChaToSpeed";
        private const string displaynamespeed = "ChaToSpeed.Name";
        private const string displaydescriptionspeed = "ChaToSpeed.Description";
        public static BlueprintFeature ConfigureSPEED()
        {
            BlueprintFeature feature = FeatureConfigurator.New(featurenamepspeed, Guids.chatospeed)
                .SetDisplayName(displaynamespeed)
                .SetDescription(displaydescriptionspeed)
                .AddDerivativeStatBonus(baseStat: StatType.Charisma,
                    descriptor: Kingmaker.Enums.ModifierDescriptor.Inherent,
                    derivativeStat: StatType.Speed)
                .AddRecalculateOnStatChange(stat: StatType.Charisma)
                .Configure();
            return feature;
        }
        private const string featurenamecrit = "ChaToCrit";
        private const string displaynamecrit = "ChaToCrit.Name";
        private const string displaydescriptioncrit = "ChaToCrit.Description";
        public static BlueprintFeature ConfigureCRIT()
        {

            BlueprintFeature feature = FeatureConfigurator.New(featurenamecrit, Guids.chatocrit)
                .SetDisplayName(displaynamecrit)
                .SetDescription(displaydescriptioncrit)
                .AddComponent<CritComponent>()
                .AddRecalculateOnStatChange(stat: StatType.Charisma)
                .Configure();
            return feature;
        }
        private const string featurenamedr = "ChaToDR";
        private const string displaynamedr = "ChaToDR.Name";
        private const string displaydescriptiondr = "ChaToChaToDR.Description";
        public static BlueprintFeature ConfigureDR()
        {
            BlueprintFeature feature = FeatureConfigurator.New(featurenamedr, Guids.chatodr)
                .SetDisplayName(displaynamedr)
                .SetDescription(displaydescriptiondr)
                .AddComponent<DRComponent>()
                .AddRecalculateOnStatChange(stat: StatType.Charisma)
                .Configure();
            return feature;
        }
        private const string featurenamesr = "ChaToSR";
        private const string displaynamesr = "ChaToSR.Name";
        private const string displaydescriptionsr = "ChaToSR.Description";
        public static BlueprintFeature ConfigureSR()
        {

            BlueprintFeature feature = FeatureConfigurator.New(featurenamesr, Guids.chatosr)
                .SetDisplayName(displaynamesr)
                .SetDescription(displaydescriptionsr)
                .AddComponent<SRComponent>()
                .AddRecalculateOnStatChange(stat: StatType.Charisma)
                .Configure();
            return feature;
        }
        private const string featurenameskill = "ChaToSkills";
        private const string displaynameskill = "ChaToSkills.Name";
        private const string displaydescriptionskill = "ChaToSkills.Description";
        public static BlueprintFeature ConfigureSKILLS()
        {
            BlueprintFeature feature = FeatureConfigurator.New(featurenameskill, Guids.chatoskills)
                .SetDisplayName(displaynameskill)
                .SetDescription(displaydescriptionskill)
                .AddDerivativeStatBonus(baseStat: StatType.Charisma,
                    descriptor: Kingmaker.Enums.ModifierDescriptor.Inherent,
                    derivativeStat: StatType.SkillAthletics)
                .AddDerivativeStatBonus(baseStat: StatType.Charisma,
                    descriptor: Kingmaker.Enums.ModifierDescriptor.Inherent,
                    derivativeStat: StatType.SkillKnowledgeArcana)
                .AddDerivativeStatBonus(baseStat: StatType.Charisma,
                    descriptor: Kingmaker.Enums.ModifierDescriptor.Inherent,
                    derivativeStat: StatType.SkillKnowledgeWorld)
                .AddDerivativeStatBonus(baseStat: StatType.Charisma,
                    descriptor: Kingmaker.Enums.ModifierDescriptor.Inherent,
                    derivativeStat: StatType.SkillLoreNature)
                .AddDerivativeStatBonus(baseStat: StatType.Charisma,
                    descriptor: Kingmaker.Enums.ModifierDescriptor.Inherent,
                    derivativeStat: StatType.SkillLoreReligion)
                .AddDerivativeStatBonus(baseStat: StatType.Charisma,
                    descriptor: Kingmaker.Enums.ModifierDescriptor.Inherent,
                    derivativeStat: StatType.SkillMobility)
                .AddDerivativeStatBonus(baseStat: StatType.Charisma,
                    descriptor: Kingmaker.Enums.ModifierDescriptor.Inherent,
                    derivativeStat: StatType.SkillPerception)
                .AddDerivativeStatBonus(baseStat: StatType.Charisma,
                    descriptor: Kingmaker.Enums.ModifierDescriptor.Inherent,
                    derivativeStat: StatType.SkillPersuasion)
                .AddDerivativeStatBonus(baseStat: StatType.Charisma,
                    descriptor: Kingmaker.Enums.ModifierDescriptor.Inherent,
                    derivativeStat: StatType.SkillStealth)
                .AddDerivativeStatBonus(baseStat: StatType.Charisma,
                    descriptor: Kingmaker.Enums.ModifierDescriptor.Inherent,
                    derivativeStat: StatType.SkillThievery)
                .AddDerivativeStatBonus(baseStat: StatType.Charisma,
                    descriptor: Kingmaker.Enums.ModifierDescriptor.Inherent,
                    derivativeStat: StatType.SkillUseMagicDevice)
                .AddRecalculateOnStatChange(stat: StatType.Charisma)
                .Configure();
            return feature;
        }
    }
}
