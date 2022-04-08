using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions
{
    public class Team
    {
        public Team()
        {
            Players = new List<Player>();
            Colors = new List<Color>();
            HomeMatches = new List<Match>();
            AwayMatches = new List<Match>();
        }
        public int TeamId { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Player> Players { get; set; }
        public virtual ICollection<Color> Colors { get; set; }
        public virtual ICollection<Match> HomeMatches { get; set; }
        public virtual ICollection<Match> AwayMatches { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
