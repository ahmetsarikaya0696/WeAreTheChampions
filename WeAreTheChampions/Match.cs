using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions
{
    public class Match
    {
        public Match()
        {
            if (Score1 == null || Score2 == null)
                Result = null;
            else if (Score1 > Score2)
                Result = ResultEnum.team1wins;
            else if (Score1 < Score2)
                Result = ResultEnum.team2wins;
            else
                Result = ResultEnum.equality;
        }
        public int MatchId { get; set; }
        public DateTime MatchTime { get; set; }
        public int HomeTeamId { get; set; }
        public int GuestTeamId { get; set; }
        public int? Score1 { get; set; }
        public int? Score2 { get; set; }
        public ResultEnum? Result { get; set; }

        public virtual Team HomeTeam{ get; set; }
        public virtual Team GuestTeam{ get; set; }
    }

}
