using System;
using System.Collections.Generic;
using System.Text;

namespace Balatro.Jokers
{
    public class Venus : Joker
    {
        public Venus() : base(
            "Венера",
            "venus",
            0,
            "",
            "Ја зголемува вредноста на Three of a Kind за +20 Поени и +2 Множител"
            )
        {
        }

        public override void Effect(Round round)
        {
            throw new NotImplementedException();
        }

        public override void Effect()
        {
            Score score = Form1.handScores["Three of a Kind"];
            score.chips += 20;
            score.mult += 2;
            Form1.handScores["Three of a Kind"] = score;
        }
    }
}
