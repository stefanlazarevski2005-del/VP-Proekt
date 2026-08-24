using System;
using System.Collections.Generic;
using System.Text;

namespace Balatro.Jokers
{
    public class Attorney : Joker
    {
        public Attorney() : base(
            "Адвокат",
            "attorney",
            3,
            "OBJECTION!",
            "Секој Ас дава по +20 Поени и +4 на Множител"
            )
        {
            this.PerCard = true;
        }

        public override void Effect(Round round, Form1 form)
        {
            form.chips += 20;
            form.mult += 4;
            form.ChipBox.Text = "+20";
            form.MultBox.Text = "+4";
        }

        public override bool Condition(Round round)
        {
            return round.playable[Form1.currentCard].number == 1;
        }
    }
}
