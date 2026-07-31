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
        }

        public override void Effect(Round round)
        {

        }
    }
}
