using System;
using System.Collections.Generic;
using System.Text;

namespace TotalWarWanaBe.Domain.Entityes.ItemTypes
{
    public class RangedWeapon : Item
    {
        public int Damage { get; set; }
        public int EfectiveRange { get; set; }
        public int BonusAcuracy { get; set; }
    }
}
