using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeGame
{
    public class Pion
    {
        private float x, y;
        private float speedX, speedY;
        private float sizeX, sizeY;
        private Brush brush;


        public Pion(float x, float y, float sizeX, float sizeY, float speedX, float speedY)
        {
            
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            this.speedX = speedX;
            this.speedY = speedY;
            brush = Brushes.Black;
            this.x = (this.sizeX/ 2 + x);
            this.y = (this.sizeY/ 2 + y);
        }

        public void move(int gameWidth, int gameHeight)
        {
            if (x - sizeX/2 < 0)
            {
                speedX = -speedX;
            }
            if (x + sizeX / 2 > gameWidth)
            {
                speedX = -speedX;
            }
            this.x += speedX;
            this.y += speedY;
        }


        public void draw(Graphics g)
        {
            g.FillEllipse(brush,new RectangleF(x - sizeX/2,y-sizeY/2,sizeX,sizeY));
        }
    }
}
