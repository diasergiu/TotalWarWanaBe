using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TotalWarWanaBe.Domain.Entityes
{
    public class Faction
    {
        [Key]
        public int IdFaction { get; set; }
        [StringLength(255)]
        public string FactionName { get; set; }
        [StringLength(255)]
        public string FactionDescription { get; set; }

        public ICollection<SoldierFormation> SoldierFormations { get; set; }
    }
}
