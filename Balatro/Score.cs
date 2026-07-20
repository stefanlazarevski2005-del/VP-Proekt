using System;
using System.Collections.Generic;
using System.Text;

namespace Balatro
{
    public class Score
    {
        public int chips {  get; set; }
        public int mult {  get; set; }
        public Score(int chips, int mult)
        {
            this.chips = chips;
            this.mult = mult;
        }
    }
}
