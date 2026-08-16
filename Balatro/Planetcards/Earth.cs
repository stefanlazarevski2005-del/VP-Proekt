using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;

namespace Balatro.Jokers
{
    public class Earth : Joker
    {
        public Earth() : base(
            "Земја",
            "earth",
            0,
            "",
            "Ја зголемува вредноста на Full House за +25 Поени и +2 Множител"
            )
        {
        }
        public override void Effect()
        {
            Score score = Form1.handScores["Full House"];
            score.chips += 25;
            score.mult += 2;
            Form1.handScores["Full House"] = score;
        }
    }
}
