using System;
using System.Collections.Generic;
using System.Text;

namespace Balatro.Jokers
{
    public class Hitman : Joker
    {
        public Hitman() : base(
            "Хитмен",
            "hitman",
            8,
            "Без сведоци",
            "Првото отфлување ги бриши картите од шпилот, доби $1 за секоја карта отфрлана"
            )
        {
            BeforeRound = true;
        }

        public override void Effect(Round round, Form1 form)
        {
            round.deck.RemoveAll(karta =>
                Form1.HitmanTargets.Any(target =>
                    target.suit == karta.suit &&
                    target.number == karta.number
                )
            );
        }


        public override bool Condition(Round round)
        {
            throw new NotImplementedException();
        }
        public override void Effect()
        {
            throw new NotImplementedException();
        }
    }
}
