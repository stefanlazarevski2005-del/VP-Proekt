using System;
using System.Collections.Generic;
using System.Text;

namespace Balatro.Jokers
{
    public class Lupus : Joker
    {
        public Lupus() : base(
            "Лупус",
            "lupus",
            5,
            "Have you tried the medicine drug?",
            "Ако раката е Full House, доби $5"
            )
        {
            this.PerHand = true;
        }

        public override void Effect(Round round, Form1 form)
        {
            round.money += 5;
            form.MoneyBox.Text = "+5";
        }

        public override bool Condition(Round round)
        {
            return round.CalculateHand() == "Full House";
        }
    }
}
