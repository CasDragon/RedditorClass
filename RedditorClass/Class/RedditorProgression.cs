using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using BlueprintCore.Blueprints.References;
using BlueprintCore.Utils.Types;
using Kingmaker.Blueprints.Classes;
using RedditorClass.Utils;
using RedditorClass.Features;
using Kingmaker.Blueprints;

namespace RedditorClass.Class
{
    internal class RedditorProgression
    {
        private const string progressionname = "Redditor Progression";
        public static BlueprintProgression Configure()
        {
            LevelEntryBuilder entries = new LevelEntryBuilder()
                .AddEntry(0,
                    FeatureRefs.FighterProficiencies.Reference.Get(),
                    FeatureSelectionRefs.FighterFeatSelection.Reference.Get())
                .AddEntry(1,
                    CHAtoStat.ConfigureAC(),
                    FeatureRefs.Bravery.Reference.Get(),
                    FeatureSelectionRefs.FighterFeatSelection.Reference.Get())
                .AddEntry(2,
                    CHAtoStat.ConfigureINT(),
                    CHAtoStat.ConfigureDR(),
                    FeatureRefs.ArmorTraining.Reference.Get())
                .AddEntry(3,
                    CHAtoStat.ConfigureSTR(),
                    FeatureSelectionRefs.FighterFeatSelection.Reference.Get())
                .AddEntry(4,
                    CHAtoStat.ConfigureDEX(),
                    FeatureSelectionRefs.WeaponTrainingSelection.Reference.Get())
                .AddEntry(5,
                    CHAtoStat.ConfigureCON(),
                    FeatureRefs.Bravery.Reference.Get(),
                    FeatureSelectionRefs.FighterFeatSelection.Reference.Get())
                .AddEntry(6,
                    CHAtoStat.ConfigureWIS(),
                    FeatureRefs.ArmorTraining.Reference.Get())
                .AddEntry(7,
                    CHAtoStat.ConfigureCHA(),
                    FeatureSelectionRefs.FighterFeatSelection.Reference.Get())
                .AddEntry(8,
                    CHAtoStat.ConfigureSAVES(),
                    FeatureSelectionRefs.WeaponTrainingRankUpSelection.Reference.Get(),
                    FeatureSelectionRefs.WeaponTrainingSelection.Reference.Get())
                .AddEntry(9,
                    CHAtoStat.ConfigureINIT(),
                    FeatureRefs.Bravery.Reference.Get(),
                    FeatureSelectionRefs.FighterFeatSelection.Reference.Get())
                .AddEntry(10,
                    CHAtoStat.ConfigureSPEED(),
                    FeatureRefs.ArmorTraining.Reference.Get())
                .AddEntry(11,
                    CHAtoStat.ConfigureBAB(),
                    FeatureSelectionRefs.FighterFeatSelection.Reference.Get())
                .AddEntry(12,
                    CHAtoStat.ConfigureDAM(),
                    FeatureSelectionRefs.WeaponTrainingRankUpSelection.Reference.Get(),
                    FeatureSelectionRefs.WeaponTrainingSelection.Reference.Get())
                .AddEntry(13,
                    CHAtoStat.ConfigureSKILLS(),
                    FeatureRefs.Bravery.Reference.Get(),
                    FeatureSelectionRefs.FighterFeatSelection.Reference.Get())
                .AddEntry(14,
                    CHAtoStat.ConfigureCRIT(),
                    FeatureRefs.ArmorTraining.Reference.Get())
                .AddEntry(15,
                    CHAtoStat.ConfigureSR(),
                    FeatureSelectionRefs.FighterFeatSelection.Reference.Get())
                .AddEntry(16,
                    //CHAtoStat.ConfigureDR(),
                    FeatureSelectionRefs.WeaponTrainingRankUpSelection.Reference.Get(),
                    FeatureSelectionRefs.WeaponTrainingSelection.Reference.Get())
                .AddEntry(17,
                    FeatureRefs.Bravery.Reference.Get(),
                    FeatureSelectionRefs.FighterFeatSelection.Reference.Get())
                .AddEntry(18,
                    FeatureRefs.ArmorMastery.Reference.Get())
                .AddEntry(19,
                    FeatureSelectionRefs.WeaponMasterySelection.Reference.Get(),
                    FeatureSelectionRefs.FighterFeatSelection.Reference.Get());

            BlueprintProgression prog = ProgressionConfigurator.New(progressionname, Guids.redditorprogression)
                .SetClasses(Guids.redditorcharacterclass)
                .SetIsClassFeature(true)
                .SetLevelEntries(entries)
                .Configure();
            return prog;
        }
    }
}
