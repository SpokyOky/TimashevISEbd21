using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1WinForms
{
    public class Airplanes
    {
        public AirplanesCount Count { private set; get; }
        public Color PrimaryColor { private set; get; }
        public Color SecondaryColor { private set; get; }
        public int globalPosX;
        public int globalPosY;

        public Airplanes(AirplanesCount airplanesCount, Color primaryColor, Color secondaryColor,
            int posX, int posY)
        {
            PrimaryColor = primaryColor;
            SecondaryColor = secondaryColor;
            Count = airplanesCount;
            globalPosX = posX;
            globalPosY = posY;
        }

        public enum AirplanesCount
        {
            THREE,
            FOUR,
            FIVE,
            SIX
        }

        private int CountToInt(AirplanesCount airplanesCount)
        {
            return (int)airplanesCount + 3;
        }

        public void DrawAirplanes(Graphics g)
        {
            for (int i = 0; i < CountToInt(Count); i++)
            {
                Brush b = new SolidBrush(SecondaryColor);
                List<Point> pointsAirplane = new List<Point>(4);

                int shiftX = i * 8;
                int shiftY = i * 2;
                pointsAirplane.Add(new Point(globalPosX + 110 - shiftX, globalPosY + 15 + shiftY));
                pointsAirplane.Add(new Point(globalPosX + 105 - shiftX, globalPosY + 20 + shiftY));
                pointsAirplane.Add(new Point(globalPosX + 112 - shiftX, globalPosY + 20 + shiftY));
                pointsAirplane.Add(new Point(globalPosX + 110 - shiftX, globalPosY + 18 + shiftY));

                g.FillPolygon(b, pointsAirplane.ToArray<Point>());
                b.Dispose();
            }
        }
    }
}
