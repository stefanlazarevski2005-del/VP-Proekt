using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Balatro.Jokers
{
    public class Wrath : Joker
    {
        public Wrath() : base(
            "Печатар",
            "wrath",
            3,
            "Многу ефикасен против камења",
            "+3 Множител за секој лист во ваша рака"
            )
        {
            this.PerCard = true;
        }

        public override void Effect(Round round, Form1 form)
        {
            form.mult += 3;
            form.MultBox.Text = "+3";
        }


        public override bool Condition(Round round)
        {
            return round.playable[Form1.currentCard].suit == PlayingCard.znak.spades;
        }
    }
}
