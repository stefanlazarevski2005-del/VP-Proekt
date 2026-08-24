using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Balatro.Jokers
{
    public class Gluttony : Joker
    {
        public Gluttony() : base(
            "Потковица",
            "gluttony",
            3,
            "Среќата те следи",
            "+3 на Множител за секоја детелина во ваша рака"
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
            return round.playable[Form1.currentCard].suit == PlayingCard.znak.clubs;
        }


    }
}
