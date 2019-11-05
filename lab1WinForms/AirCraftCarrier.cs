using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab1WinForms
{
    public class AircraftCarrier: WarShip
    {
        public Color SecondaryColor { private set; get; }

        public bool GunOnBoard { private set; get; }
        public bool HelicoptersOnBoard { private set; get; }
        public AirplanesCount Count { private set; get; }
        
        private int AirplaneType;

        public AircraftCarrier(int maxSpeed, double weight, Color primaryColor,
            Color secondaryColor, AirplanesCount airplanesCount,
            bool gunOnBoard = false, bool helicoptersOnBoard = false) : base (maxSpeed, weight, primaryColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            PrimaryColor = primaryColor;
            SecondaryColor = secondaryColor;
            GunOnBoard = gunOnBoard; 
            HelicoptersOnBoard = helicoptersOnBoard;
            Count = airplanesCount;

            AirplaneType = new Random().Next(3);
        }

        public void SetSecondaryColor(Color color)
        {
            SecondaryColor = color;
        }

        public override void DrawTransport(Graphics g)
        {
            base.DrawTransport(g);
            //ВП полоса
            Pen penSecondary = new Pen(SecondaryColor);
            g.DrawLine(penSecondary, new Point(posX + 119, posY + 8), new Point(posX + 27, posY + 30));
            g.DrawLine(penSecondary, new Point(posX + 119, posY + 20), new Point(posX + 40, posY + 38));
            penSecondary.Dispose();

            if (GunOnBoard)
            {
                Brush b = new SolidBrush(SecondaryColor);
                //пушка
                g.FillRectangle(b, posX + 65, posY + 5, 10, 8);

                Brush red = new SolidBrush(Color.Red);
                g.FillRectangle(red, posX + 60, posY + 6, 10, 2);
                g.FillRectangle(red, posX + 60, posY + 10, 10, 2);
                g.FillRectangle(red, posX + 67, posY + 6, 3, 6);

                b.Dispose();
                red.Dispose();
            }

            if (HelicoptersOnBoard)
            {
                //вертолёт
                //тело
                Brush b = new SolidBrush(SecondaryColor);
                List<Point> pointsHelicopter = new List<Point>(3);
                pointsHelicopter.Add(new Point(posX + 40, posY + 10));
                pointsHelicopter.Add(new Point(posX + 44, posY + 10));
                pointsHelicopter.Add(new Point(posX + 42, posY + 18));

                g.FillPolygon(b, pointsHelicopter.ToArray<Point>());
                b.Dispose();

                //винты
                Pen p = new Pen(Color.Black);
                g.DrawLine(p, posX + 42, posY + 12, posX + 45, posY + 15);
                g.DrawLine(p, posX + 42, posY + 12, posX + 39, posY + 15);
                g.DrawLine(p, posX + 42, posY + 12, posX + 39, posY + 9);
                g.DrawLine(p, posX + 42, posY + 12, posX + 45, posY + 9);
                p.Dispose();
            }

            IAirplanes airplane;
            switch (AirplaneType)
            {
                case 0:
                    airplane = new Fighter(posX, posY);
                    break;
                case 1:
                    airplane = new SimpleAirplane(posX, posY);
                    break;
                case 2:
                    airplane = new Stealth(posX, posY);
                    break;
                default:
                    airplane = new Stealth(posX, posY);
                    break;
            }
            airplane.DrawAirplanes(Count, g, SecondaryColor);
        }
    }
}
