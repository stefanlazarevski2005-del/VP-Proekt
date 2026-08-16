using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;

namespace Balatro.Jokers
{
    public class Jupiter : Joker
    {
        public Jupiter() : base(
            "Јупитер",
            "jupiter",
            0,
            "",
            "Ја зголемува вредноста на Flush за +15 Поени и +2 Множител"
            )
        {
        }

        public override void Effect()
        {
            Score score = Form1.handScores["Flush"];
            score.chips += 15;
            score.mult += 2;
            Form1.handScores["Flush"] = score;
        }
    }
}
