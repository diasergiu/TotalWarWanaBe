using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TotalWarWanaBe.Domain.Entityes
{
    public class SoldierModel
    {
        [Key]
        public int IdSoldier { get; set; }
        public int AttackSkilll { get; set; }
        public int DefenceSkill { get; set; }
        public int Stamina { get; set; }
        public int Speed { get; set; }
        public int Acuracy { get; set; }
        [StringLength(255)]
        public string SoldierName { get; set; }

        public ICollection<SoldierFormation> SoldierFormations { get; set; }
    }
}