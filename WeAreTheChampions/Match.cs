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
        public int MatchId { get; set; }
        public DateTime MatchTime { get; set; }
        public int HomeTeamId { get; set; }
        public int GuestTeamId { get; set; }
        public int? Score1 { get; set; }
        public int? Score2 { get; set; }

        private ResultEnum? result;
        public ResultEnum? Result
        {
            get { return result; }
            set
            {
                //result = value;
                if (Score1 == null || Score2 == null)
                    result = null;
                else if (Score1 > Score2)
                    result = ResultEnum.team1wins;
                else if (Score1 < Score2)
                    result = ResultEnum.team2wins;
                else
                    result = ResultEnum.equality;
            }
        }


        public virtual Team HomeTeam { get; set; }
        public virtual Team GuestTeam { get; set; }
    }

}
