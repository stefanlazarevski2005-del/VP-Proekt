using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;

namespace Balatro.Jokers
{
    public class Uranus : Joker
    {
        public Uranus() : base(
            "Уранус",
            "mercury",
            0,
            "",
            "Ја зголемува вредноста на Two Pair за +20 Поени и +1 Множител"
            )
        {
        }

        public override void Effect(Round round)
        {
            throw new NotImplementedException();
        }

        public override void Effect()
        {
            Score score = Form1.handScores["Two Pair"];
            score.chips += 20;
            score.mult++;
            Form1.handScores["Two Pair"] = score;
        }
    }
}
