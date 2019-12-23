using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1WinForms
{
    class Stealth : IAirplanes
    {
        public int globalPosX;
        public int globalPosY;

        public Stealth(int posX, int posY)
        {
            globalPosX = posX;
            globalPosY = posY;
        }

        public void DrawAirplanes(AirplanesCount Count, Graphics g, Color color)
        {
            for (int i = 0; i < (int)Count; i++)
            {
                Brush b = new SolidBrush(color);
                List<Point> pointsAirplane = new List<Point>(4);

                int shiftX = i * 8;
                int shiftY = i * 2;
                pointsAirplane.Add(new Point(globalPosX + 110 - shiftX, globalPosY + 8 + shiftY));
                pointsAirplane.Add(new Point(globalPosX + 105 - shiftX, globalPosY + 18 + shiftY));
                pointsAirplane.Add(new Point(globalPosX + 112 - shiftX, globalPosY + 23 + shiftY));
                pointsAirplane.Add(new Point(globalPosX + 110 - shiftX, globalPosY + 18 + shiftY));

                g.FillPolygon(b, pointsAirplane.ToArray<Point>());
                b.Dispose();
            }
        }
    }
}
