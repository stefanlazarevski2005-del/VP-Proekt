using System;
using System.Collections.Generic;
using System.Text;

namespace Balatro.Jokers
{
    public class Exam : Joker
    {
        public Exam() : base(
        "Испитна",
        "exam",
        5,
        "Се гледаме следна година,",
        "Секој Ас, 2, 3, 4 и 5 се играат по два пати"
    )
        {
            this.PerCard = true;
        }

        public override void Effect(Round round, Form1 form)
        {
            if (form.Retrigger)
            {
                form.Retrigger = false;
            }
            else
            {
                form.Retrigger = true;
            }
        }


        public override bool Condition(Round round)
        {
            return round.playable[Form1.currentCard].number == 1 ||
                   round.playable[Form1.currentCard].number == 2 ||
                   round.playable[Form1.currentCard].number == 3 ||
                   round.playable[Form1.currentCard].number == 4 ||
                   round.playable[Form1.currentCard].number == 5;

        }

    }
}
