using System;
using System.Collections.Generic;
using System.Text;

namespace Balatro.Jokers
{
    public class Pessimist : Joker
    {
        public Pessimist() : base(
        "Песимист",
        "pessimist",
        3,
        "Чашата е полу празна",
        "+1 отфрлување за играње"
    )
        {
            this.BeforeRound = true;
        }

        public override void Effect(Round round, Form1 form)
        {
            round.discards++;
        }


    }
}
