using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;

namespace Balatro.Jokers
{
    public class Saturn : Joker
    {
        public Saturn() : base(
            "Сатурн",
            "saturn",
            0,
            "",
            "Ја зголемува вредноста на Straight за +30 Поени и +3 Множител"
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
            Score score = Form1.handScores["Straight "];
            score.chips += 30;
            score.mult += 3;
            Form1.handScores["Straight "] = score;
        }
    }
}
