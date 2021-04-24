using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TotalWarWanaBe.Domain.Entityes
{
    public class SoldierFormation
    {
        [Key]
        public int IdFormation { get; set; }
        public int NumberSoldiers { get; set; }
        public int StartingFormationValue { get; set; }
        [MaxLength(255)]
        public string FormationName { get; set; }
        public SoldierModel SoldierModel { get; set; }
        public Horse Horse { get; set; }

        public ICollection<Trait> Traits { get; set; }
        public ICollection<Faction> Factions { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
