using System;
using System.Collections.Generic;
using System.Text;

namespace Balatro.Jokers
{
    public class Greed : Joker
    {
        public Greed() : base(
            "Алчноста",
            "greed",
            3,
            "Најдобар десерт",
            "+3 Множител за секоја баклава во ваша рака"
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
            return round.playable[Form1.currentCard].suit == PlayingCard.znak.diamonds;
        }
        public override void Effect()
        {
            throw new NotImplementedException();
        }
    }
}
