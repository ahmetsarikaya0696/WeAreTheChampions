using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions
{
    public class Color
    {
        public Color()
        {
            Teams = new List<Team>();
        }
        public int ColorId { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }
        
        private int red;
        private int green;
        private int blue;

        public int Red
        {
            get { return red; }
            set
            {
                if (!(value < 0 || value > 255))
                    red = value;
                else
                    throw new Exception("This value has to be between 0-255!");
            }
        }
        public int Green
        {
            get { return green; }
            set
            {
                if (!(value < 0 || value > 255))
                    green = value;
                else
                    throw new Exception("This value has to be between 0-255!");
            }
        }
        public int Blue
        {
            get { return blue; }
            set
            {
                if (!(value < 0 || value > 255))
                    blue = value;
                else
                    throw new Exception("This value has to be between 0-255!");
            }
        }

        public virtual ICollection<Team> Teams { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
