using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;

namespace Balatro.Jokers
{
    public class Mars : Joker
    {
        public Mars() : base(
            "Марс",
            "mars",
            0,
            "",
            "Ја зголемува вредноста на Four of a Kind за +30 Поени и +3 Множител"
            )
        {
        }
        public override void Effect()
        {
            Score score = Form1.handScores["Four of a Kind"];
            score.chips += 30;
            score.mult += 3;
            Form1.handScores["Four of a Kind"] = score;
        }
    }
}
