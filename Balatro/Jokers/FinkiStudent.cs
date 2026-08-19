using System;
using System.Collections.Generic;
using System.Text;

namespace Balatro.Jokers
{
    public class FinkiStudent : Joker
    {
        public FinkiStudent() : base(
            "ФИНКИ Студент",
            "finkistudent",
            5,
            "Одма ќе најдам работа после факс, нели?",
            "X2 Множител ако си под $5"
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
            return round.money < 5;
        }
    }
}
