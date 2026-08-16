using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.VisualStyles;

namespace Balatro.Jokers
{
    public class Corruption : Joker
    {
        public Corruption() : base(
        "Корупција",
        "corruption",
        5,
        "",
        "После секоја рунда добиваш $20, бројот на карти во рака се намалува на 6"
        )
        {
            this.BeforeRound = true;
            this.AfterRound = true;
        }

        public override void Effect(Round round, Form1 form)
        {
            round.handsize = 6;
            form.extramoney += 20;
        }

        public override bool Condition(Round round)
        {
            return true;
        }
        public override void Effect()
        {
            throw new NotImplementedException();
        }
    }
}
