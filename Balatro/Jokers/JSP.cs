using System;
using System.Collections.Generic;
using System.Text;

namespace Balatro.Jokers
{
    public class JSP : Joker
    {
        public JSP() : base(
        "ЈСП",
        "jsp",
        5,
        "Е сега ли најде да дојде?",
        "На последна рака добиваш X2 на Множител"
    )
        {
            this.PerHand = true;
        }

        public override void Effect(Round round, Form1 form)
        {
            form.mult *= 2;
            form.MultBox.Text = "X2";
        }

        public override bool Condition(Round round)
        {
            return round.hands == 0;
        }

    }
}
