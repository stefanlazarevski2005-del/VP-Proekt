using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Balatro.Jokers
{
    public class Psycho : Joker
    {
        public Psycho() : base(
            "Психо",
            "psycho",
            3,
            "I have to return some videotapes",
            "+10 на Множител ако имаш 0 отфрлувања"
            )
        {
            this.PerHand = true;
        }

        public override void Effect(Round round, Form1 form)
        {
            form.mult += 10;
            form.MultBox.Text = "+10";
        }

        public override bool Condition(Round round)
        {
            return round.discards == 0;
        }

    }
}
