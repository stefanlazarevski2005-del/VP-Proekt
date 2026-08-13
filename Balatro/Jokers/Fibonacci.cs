using System;
using System.Collections.Generic;
using System.Text;

namespace Balatro.Jokers
{
    public class Fibonacci : Joker
    {
        public Fibonacci() : base(
            "Фибоначо",
            "fibonacci",
            5,
            "Омилениот џокер на TOOL",
            "Секој Ас, 2, 3, 5 и 8 даваат +8 множител"
            )
        {
            this.PerCard = true;
        }

        public override void Effect(Round round, Form1 form)
        {
            form.mult += 8;
            form.MultBox.Text = "+8";
        }

        public override bool Condition(Round round)
        {
            return round.playable[Form1.currentCard].number == 1 ||
                   round.playable[Form1.currentCard].number == 2 ||
                   round.playable[Form1.currentCard].number == 3 ||
                   round.playable[Form1.currentCard].number == 5 ||
                   round.playable[Form1.currentCard].number == 8;
        }
        public override void Effect()
        {
            throw new NotImplementedException();
        }
    }
}
