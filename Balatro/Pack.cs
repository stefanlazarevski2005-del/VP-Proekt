using System;
using System.Collections.Generic;
using System.Text;

namespace Balatro
{
    public class Pack : Card
    {
        public int height;
        public int width;
        public Image img;
        public Pack(Image img) : base() {
            this.img = img;
            this.width = 0;
            this.height = 0;
        }

        public override void DrawCard(Graphics g)
        {
            g.DrawImage(img, x, y, width, height);
        }

        public override bool ContainsPoint(Point point)
        {
            Rectangle area = new Rectangle((int)x, (int)y, 133, 217);
            return area.Contains(point);
        }
    }
}
