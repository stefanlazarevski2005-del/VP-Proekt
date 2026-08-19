using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.VisualStyles;

namespace Balatro.Jokers
{
    public class Corruption : Joker
    {
        int effectCount = 0;

        public Corruption() : base(
        "Корупција",
        "corruption",
        5,
        "Македонцка работа",
        "После секоја рунда добиваш $20, бројот на карти во рака се намалува за 2"
        )
        {
            this.BeforeRound = true;
            this.AfterRound = true;
            effectCount = 0;
        }

        public override void Effect(Round round, Form1 form)
        {
            effectCount++;
            if (effectCount <= 2)
            {
                round.handsize -= 2;
            }
            else
            {
                form.extramoney += 20;
            }

            if (effectCount == 4)
            {
                effectCount = 0;
            }
        }
        

    }
}
