using System;
using System.Collections.Generic;
using System.Text;

namespace Balatro.Jokers
{
    public class Casino : Joker
    {
        public Casino() : base(
            "Казино",
            "casino",
            3,
            "Само уште еден удар, ќе го фатам",
            "Доби помеѓу 0-150 поени"
            )
        {
            this.PerHand = true;
        }

        public override void Effect(Round round, Form1 form)
        {

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
