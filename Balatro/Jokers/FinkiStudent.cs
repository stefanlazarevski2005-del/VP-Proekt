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
            "X2 Множител ако си под $3"
            )
        {
            this.PerHand = true;
        }

        public override void Effect(Round round, Form1 form)
        {

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
