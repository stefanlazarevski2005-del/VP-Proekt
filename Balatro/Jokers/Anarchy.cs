using System;
using System.Collections.Generic;
using System.Text;

namespace Balatro.Jokers
{
    public class Anarchy : Joker
    {
        public Anarchy() : base(
        "Анархија",
        "anarchy",
        5,
        "Смрт на фашизмот, Слобода на картите",
        "Сите нумерирани карти вредат 10 поени, сите карти со фаца вредат 0 поени"
    )
        {
            this.BeforeRound = true;
        }

        public override void Effect(Round round, Form1 form)
        {
            foreach (PlayingCard karta in round.deck)
            {
                if (karta.isFaceCard)
                {
                    karta.points = 0;
                }
                else
                {
                    karta.points = 10;
                }
            }
        }
    }
}
