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

        private int? result;
        
        public int? Result
        {
            get { return result; }
            private set
            {
                SetResult();
            }
        }

        public void SetResult()
        {
            if (Score1 == null || Score2 == null)
                result = null;
            else if (Score1 > Score2)
                result = (int)ResultEnum.team1wins;
            else if (Score1 < Score2)
                result = (int)ResultEnum.team2wins;
            else
                result = (int)ResultEnum.equality;
        }

        public virtual Team HomeTeam { get; set; }
        public virtual Team GuestTeam { get; set; }
    }

}
