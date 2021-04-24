using System;
using System.Collections.Generic;
using System.Text;

namespace TotalWarWanaBe.Domain.Entityes.ItemTypes
{
    public class Shield : Item
    {
        public int ShildDefence { get; set; }
        public int FormationDefenceBonus { get; set; }
        public int FormationAttackBonus { get; set; }
    }
}
