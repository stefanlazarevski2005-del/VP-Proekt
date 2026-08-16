using System;
using System.Collections.Generic;
using System.Text;

namespace Balatro.Jokers
{
    public class Aristocracy : Joker
    {
        public Aristocracy() : base(
            "Аристократија",
            "aristocracy",
            3,
            "Некои карти се поеднакви од други",
            "+30 poeni за секоја карта со фаца во ваша рака"
            )
        {
            this.PerCard = true;
        }

        public override void Effect(Round round, Form1 form)
        {
            form.chips += 30;
            form.ChipBox.Text = "+30";
        }


        public override bool Condition(Round round)
        {
            return round.playable[Form1.currentCard].isFaceCard;
        }
    }
}
