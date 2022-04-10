using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions
{
    public class Player
    {
        public int PlayerId { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        public int? TeamId { get; set; }

        public virtual Team Team { get; set; }

        public override string ToString()
        { 
            return Team != null ? $"{Name} ({Team})" : $"{Name} (Null)";
        }
    }
}
