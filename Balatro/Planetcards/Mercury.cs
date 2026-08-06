using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;

namespace Balatro.Jokers
{
    public class Mercury : Joker
    {
        public Mercury() : base(
            "Меркур",
            "mercury",
            0,
            "",
            "Ја зголемува вредноста на Pair за +15 Поени и +1 Множител"
            )
        {
        }

        public override void Effect(Round round, Form1 form)
        {
            throw new NotImplementedException();
        }

        public override bool Condition(Round round)
        {
            throw new NotImplementedException();
        }

        public override void Effect()
        {
            Score score = Form1.handScores["Pair"];
            score.chips += 15;
            score.mult++;
            Form1.handScores["Pair"] = score;
        }
    }
}
