using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TotalWarWanaBe.Domain.Entityes
{
    public class Item
    {
        [Key]
        public int IdItem { get; set; }
        public int StaminaCost { get; set; }
        public int SpeedCost { get; set; }
        [MaxLength(255)]
        public string ItemName { get; set; }

        public ICollection<SoldierFormation> SoldierFormations { get; set; }

    }
}
