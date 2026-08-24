using System;
using System.Collections.Generic;
using System.Text;

namespace Balatro.Jokers
{
    public class Scholarship : Joker
    {
        public Scholarship() : base(
            "Стипендија",
            "scholarship",
            3,
            "Мора просек да бркаш",
            "Секој 8, 9 и 10 даваат по +30 Поени и +3 на Множител"
            )
        {
            this.PerCard = true;
        }

        public override void Effect(Round round, Form1 form)
        {
            form.chips += 30;
            form.mult += 3;
            form.ChipBox.Text = "+30";
            form.MultBox.Text = "+5";
        }


        public override bool Condition(Round round)
        {
            return round.playable[Form1.currentCard].number == 8 || round.playable[Form1.currentCard].number == 9 || round.playable[Form1.currentCard].number == 10;
        }
    }
}
