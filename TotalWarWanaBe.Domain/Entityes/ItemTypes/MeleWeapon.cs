using System;
using System.Collections.Generic;
using System.Text;

namespace TotalWarWanaBe.Domain.Entityes.ItemTypes
{
    public class MeleWeapon : Item
    {
        public int Damage { get; set; }
        public int BonusAttackSkill { get; set; }
        public int BonusAttackSkillFormation { get; set; }
        public int ChargeBonus { get; set; }
        public int BonusDefenceSkillFormation { get; set; }
        public int BonusDefenceSkill { get; set; }
        public bool IsSideArm { get; set; }
        public bool IsTowHanded { get; set; }
    }
}
