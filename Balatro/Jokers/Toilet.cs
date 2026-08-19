using System;
using System.Collections.Generic;
using System.Text;

namespace Balatro.Jokers
{
    public class Toilet : Joker
    {
        public Toilet() : base(
            "Тоалет",
            "toilet",
            3,
            "Не заборавај да пушташ вода",
            "Ако раката содржи Flush, доби +80 поени и +10 множител"
            )
        {
            this.PerHand = true;
        }

        public override void Effect(Round round, Form1 form)
        {
            form.chips += 80;
            form.mult += 10;
            form.ChipBox.Text = "+80";
            form.MultBox.Text = "+10";
        }

        public override bool Condition(Round round)
        {
            return round.CalculateHand() == "Flush" || round.CalculateHand() == "Straight Flush" || round.CalculateHand() == "Royal Flush";
        }
    }
}
