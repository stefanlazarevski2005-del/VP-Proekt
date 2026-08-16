using System;
using System.Collections.Generic;
using System.Text;

namespace Balatro.Jokers
{
    public class VIS : Joker
    {
        public VIS() : base(
            "ВИС",
            "vis",
            3,
            "Која е веројатноста дека ќе го положиш овој предмет?",
            "30% шанса дека ќе добиеш +30 множител"
            )
        {
            this.PerHand = true;
        }

        public override void Effect(Round round, Form1 form)
        {
            form.mult += 30;
            form.MultBox.Text = "+30";
        }

        public override bool Condition(Round round)
        {
            int number = rnd.Next(0, 5);
            return number == 0 || number == 1;
        }
        public override void Effect()
        {
            throw new NotImplementedException();
        }
    }
}
