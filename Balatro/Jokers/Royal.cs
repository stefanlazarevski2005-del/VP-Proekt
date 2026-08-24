using System;
using System.Collections.Generic;
using System.Text;

namespace Balatro.Jokers
{
    public class Royal : Joker
    {
        public Royal() : base(
            "Кралско семејство",
            "royal",
            3,
            "Keep it in the Family",
            "+5 на Множител за секоја карта со фаца во ваша рака"
            )
        {
            this.PerCard = true;
        }

        public override void Effect(Round round, Form1 form)
        {
            form.mult += 5;
            form.MultBox.Text = "+5";
        }


        public override bool Condition(Round round)
        {
            return round.playable[Form1.currentCard].isFaceCard;
        }
    }
}
