using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TotalWarWanaBe.Domain.Entityes
{
    public class Barding
    {
        [Key]
        public int IdBarding { get; set; }
        public int ArmorValue { get; set; }
        public string BardingName { get; set; }
        
        public ICollection<Horse> Horses { get; set; }
    }
}