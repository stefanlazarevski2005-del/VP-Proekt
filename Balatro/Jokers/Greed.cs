using System;
using System.Collections.Generic;
using System.Text;

namespace Balatro.Jokers
{
    public class Greed : Joker
    {
        public Greed() : base(
            "Алчноста",
            "greed",
            3,
            "Најдобар десерт",
            "+3 Множител за секоја баклава во ваша рака"
            )
        {
        }

        public override void Effect(Round round)
        {

        }

        public override void Effect()
        {
            throw new NotImplementedException();
        }
    }
}
