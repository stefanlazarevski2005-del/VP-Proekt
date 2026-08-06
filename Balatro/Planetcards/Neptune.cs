using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;

namespace Balatro.Jokers
{
    public class Neptune : Joker
    {
        public Neptune() : base(
            "Нептун",
            "neptune",
            0,
            "",
            "Ја зголемува вредноста на Straight Flush за +40 Поени и +4 Множител"
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
            Score score = Form1.handScores["Straight Flush"];
            score.chips += 40;
            score.mult += 4;
            Form1.handScores["Straight Flush"] = score;
            Form1.handScores["Royal Flush"] = score;
        }
    }
}
