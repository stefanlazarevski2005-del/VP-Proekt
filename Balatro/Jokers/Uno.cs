using System;
using System.Collections.Generic;
using System.Text;

namespace Balatro.Jokers
{
    public class Uno : Joker
    {
        public Uno() : base(
        "УНО",
        "uno",
        8,
        "",
        "Ако раката има само 1 карта, добивај X4 на множител"
    )
        {
            this.PerHand = true;
        }

        public override void Effect(Round round, Form1 form)
        {
            form.mult *= 4;
            form.MultBox.Text = "X4";
        }

        public override bool Condition(Round round)
        {
            return round.selected.Count == 1;
        }
        public override void Effect()
        {
            throw new NotImplementedException();
        }

    }
}
