using System;
using System.Collections.Generic;
using System.Text;

namespace Balatro.Jokers
{
    public class Jackpot : Joker
    {
        public Jackpot() : base(
            "Јекпот",
            "jackpot",
            3,
            "Не е кладење ако добиеш",
            "Ако раката содржи Three of a Kind, доби +200 поени"
            )
        {
            this.PerHand = true;
        }

        public override void Effect(Round round, Form1 form)
        {
            form.chips += 200;
            form.ChipBox.Text = $"+200";
        }

        public override bool Condition(Round round)
        {
            return round.CalculateHand() == "Three of a Kind" || round.CalculateHand() == "Full House" || round.CalculateHand() == "Four of a Kind";
        }
    }
}
