using System;
using System.Collections.Generic;
using System.Text;

namespace Balatro.Jokers
{
    public class Optimist : Joker
    {
        public Optimist() : base(
        "Оптимист",
        "optimist",
        3,
        "Чашата е полу полна",
        "+1 рака за играње"
    )
        {
            this.BeforeRound = true;
        }

        public override void Effect(Round round, Form1 form)
        {
            round.hands++;
        }


        public override bool Condition(Round round)
        {
            throw new NotImplementedException();
        }
        public override void Effect()
        {
            throw new NotImplementedException();
        }

    }
}
