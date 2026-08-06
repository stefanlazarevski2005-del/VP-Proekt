using System;
using System.Collections.Generic;
using System.Text;

namespace Balatro.Jokers
{
    public class Obrok : Joker
    {
        public Obrok() : base(
        "Студентски оброк",
        "obrok",
        3,
        "Буџет за цигари и алкохол",
        "После секоја рунда, добиваш екстра $2"
        )
        {
            this.AfterRound = true;
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
