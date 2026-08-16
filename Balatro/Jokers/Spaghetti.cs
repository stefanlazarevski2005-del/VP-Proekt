using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Balatro.Jokers
{
    public class Spaghetti : Joker
    {
        public Spaghetti() : base(
            "Шпаѓети",
            "spaghetti",
            3,
            "Инспирирано од кодот на оваа игра",
            "+50 Поени за секој џокер што го поседуваш"
            )
        {
            this.PerHand = true;
        }

        public override void Effect(Round round, Form1 form)
        {
            int chips = 50 * Market.JokersInUse.Count;
            form.chips += chips;
            form.ChipBox.Text = $"+{chips}";
        }

        public override bool Condition(Round round)
        {
            return true;
        }

        public override void Effect()
        {
            throw new NotImplementedException();
        }
    }
}
