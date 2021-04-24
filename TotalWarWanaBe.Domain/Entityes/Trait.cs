using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TotalWarWanaBe.Domain.Entityes
{
    public class Trait
    {
        [Key]
        public int IdTrait { get; set; }
        [MaxLength(255)]
        public string TraitDescription { get; set; }
        [MaxLength(255)]
        public string TraitName { get; set; }
        

        public ICollection<SoldierFormation> SoldierFormation { get; set; }
    }
}