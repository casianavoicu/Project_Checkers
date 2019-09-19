using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.Classes
{
   public class Side
    {
      public Team type;
        public enum Team
        {   
            Red,
            Black
        };
        public Side()
        {

        }
        public Side(Team team)
        {
            type = team;
        }
        public Team team
        {
            get { return type; }
            set { type = value; }
        }
        public bool isBlack()
        {
            return (this.team == Team.Black);
        }
        public bool isRed()
        {
            return (this.team == Team.Red);
        }
    }
}
