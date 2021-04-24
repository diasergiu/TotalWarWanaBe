using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TotalWarWanaBe.Domain.Entityes
{
    public class Horse
    {
        [Key]
        public int IdHorse { get; set; }
        public int AttackModifier { get; set; }
        [StringLength(255)]
        public string BreedName { get; set; }
        public int DefenceModifiered { get; set; }
        public int HorseStamina { get; set; }
        public int HorseStrength { get; set; }
        public Barding Barding { get; set; }

        public ICollection<SoldierFormation> SoldierFormations { get; set; }
    }
}