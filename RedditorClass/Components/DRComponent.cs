using Kingmaker.Blueprints.Facts;
using Kingmaker.Blueprints.JsonSystem;
using Kingmaker.Blueprints;
using Kingmaker.RuleSystem.Rules.Damage;
using Kingmaker.UnitLogic;
using Kingmaker.EntitySystem.Stats;
using Kingmaker.EntitySystem;
using Kingmaker.UnitLogic.FactLogic;
using Kingmaker.Items;
using Kingmaker.Enums.Damage;
using Kingmaker.PubSubSystem;

namespace RedditorClass.Components
{
    [AllowedOn(typeof(BlueprintUnitFact), true)]
    [AllowedOn(typeof(BlueprintUnit), true)]
    [AllowMultipleComponents]
    [TypeId("A9675332-F963-4F5F-AA97-7E6E85E0D8D1")]
    internal class DRComponent :  AddDamageResistanceBase
    {
        public StatType Stat = StatType.Charisma;
        public bool UsePool = false;

        public DamageEnergyTypeFlag m_ExcludedTypes;
        public override bool Bypassed(DRComponent.ComponentRuntime runtime, BaseDamage damage, ItemEntityWeapon weapon)
        {
            return false;
        }
        public override int CalculateValue(ComponentRuntime runtime)
        {
            return runtime.Owner.Stats.GetStat(this.Stat).CalculatePermanentValue() / 2 - 5;
        }
    }
}
