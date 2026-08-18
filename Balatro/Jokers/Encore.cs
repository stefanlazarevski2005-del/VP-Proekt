using System;
using System.Collections.Generic;
using System.Text;

namespace Balatro.Jokers
{
    public class Encore : Joker
    {
        public Encore() : base(
        "Бис",
        "encore",
        5,
        "",
        "Сите карти на фаца се играат по два пати"
    )
        {
            this.PerCard = true;
        }

        public override void Effect(Round round, Form1 form)
        {
            if (!form.isRetrigger)
            {
                form.Retriggers++;
            }
        }


        public override bool Condition(Round round)
        {
            return round.playable[Form1.currentCard].isFaceCard;
        }

    }
}
