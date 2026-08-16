using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.VisualStyles;

namespace Balatro.Jokers
{
    public class FinkiZgrada : Joker
    {

        Joker neighbor;
        public FinkiZgrada() : base(
        "ФИНКИ Зграда",
        "finkizgrada",
        8,
        "TMF - ToMorrow Finki",
        "Го позајмува ефектот на џокерот што се наоѓа десно од овој џокер"
        )
        {
        }


        private Joker GetNeighbor()
        {
            int index = Market.JokersInUse.IndexOf(this);
            if (index == -1 || index + 1 >= Market.JokersInUse.Count)
            {
                return null;
            }
            return Market.JokersInUse[index+1];
        }

        public override void Effect(Round round, Form1 form)
        {
            if (neighbor != null)
            {
                neighbor.Effect(round, form);
            }
        }

        public override bool Condition(Round round)
        {
            if (neighbor != null)
            {
                return neighbor.Condition(round);
            }
            return false;
        }

        public override void UpdateCopyBehavior()
        {
            neighbor = GetNeighbor();

            if (neighbor != null)
            {
                BeforeRound = neighbor.BeforeRound;
                PerCard = neighbor.PerCard;
                PerHand = neighbor.PerHand;
                AfterRound = neighbor.AfterRound;
            }
        }
    }
}
