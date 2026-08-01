using System;
using System.Collections.Generic;
using System.Text;

namespace Balatro.Jokers
{
    public class Pluto : Joker
    {
        public Pluto() : base(
            "Плутон",
            "pluto",
            0,
            "",
            "Ја зголемува вредноста на High Card за +10 Поени и +1 Множител"
            )
        {
        }

        public override void Effect(Round round)
        {
            throw new NotImplementedException();
        }


        public override void Effect()
        {
            Score score = Form1.handScores["High Card"];
            score.chips += 10;
            score.mult++;
            Form1.handScores["High Card"] = score;
        }
    }
}
