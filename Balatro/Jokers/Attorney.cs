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
            "Секој Ас дава по +20 поени и +4 Множител"
            )
        {
            this.PerCard = true;
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
