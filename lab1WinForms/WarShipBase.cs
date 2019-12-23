using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1WinForms
{
    public abstract class WarShipBase : ITransport
    {
        protected int posX;
        protected int posY;

        protected int picWidth;
        protected int picHeight;

        protected const int carrierWidht = 120;
        protected const int carrierHeight = 40;

        public int MaxSpeed { protected set; get; }
        public double Weight { protected set; get; }

        public Color PrimaryColor { protected set; get; }

        public abstract void DrawTransport(Graphics g);

        public abstract void MoveTransport(Direction direction);

        public void SetPosition(int x, int y, int widht, int height)
        {
            posX = x;
            posY = y;
            picWidth = widht;
            picHeight = height;
        }
    }
}
