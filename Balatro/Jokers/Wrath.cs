using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Balatro.Jokers
{
    public class Wrath : Joker
    {
        public Wrath() : base(
            "Печатар",
            "wrath",
            3,
            "Многу ефикасен против камења",
            "+3 Множител за секој лист во ваша рака"
            )
        {
        }

        public override void Effect(Round round)
        {

        }
    }
}
