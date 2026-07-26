using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Balatro.Jokers
{
    public class Gluttony : Joker
    {
        public Gluttony() : base(
            "gluttony",
            3,
            "Среќата те следи",
            "+3 Множител за секоја детелина во ваша рака"
            )
        {
        }

        public override void Effect(Round round)
        {

        }
    }
}
