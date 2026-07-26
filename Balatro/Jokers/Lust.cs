using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Balatro.Jokers
{
    public class Lust : Joker
    {
        public Lust() : base(
            "lust",
            3,
            "Срце није камен",
            "+3 Множител за секое срце во ваша рака"
            )
        {
        }

        public override void Effect(Round round)
        {

        }
    }
}
