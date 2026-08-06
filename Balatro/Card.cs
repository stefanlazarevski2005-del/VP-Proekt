using System;
using System.Collections.Generic;
using System.Text;

namespace Balatro
{

  
    public abstract class Card
    { 
  
        public float x { get; set; }
        public float y { get; set; }
        public float targetx { get; set; }
        public float targety { get; set; }

        public bool moveUp {  get; set; }
        public Card ()
        {
            
            this.x = 0;
            this.y = 0;
            this.targetx = 0;
            this.targety = 0;
            moveUp = true;
        }


        public abstract void DrawCard(Graphics g);

        public abstract bool ContainsPoint(Point point);
    }
}
