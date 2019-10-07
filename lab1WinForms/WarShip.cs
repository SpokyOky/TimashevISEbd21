using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1WinForms
{
    class WarShip : WarShipBase
    {
        public Color SecondaryColor { protected set; get; }

        public WarShip(int maxSpeed, double weight, Color primaryColor,
            Color secondaryColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            PrimaryColor = primaryColor;
            SecondaryColor = secondaryColor;
        }

        public override void MoveTransport(Direction direction)
        {
            int shift = Convert.ToInt32(MaxSpeed * 100 / Weight);
            switch (direction)
            {
                case Direction.Left:
                    if (posX - shift > 0)
                    {
                        posX -= shift;
                    }
                    break;
                case Direction.Right:
                    if (posX + shift < picWidth - carrierWidht)
                    {
                        posX += shift;
                    }
                    break;
                case Direction.Up:
                    if (posY - shift > 0)
                    {
                        posY -= shift;
                    }
                    break;
                case Direction.Down:
                    if (posY + shift < picHeight - carrierHeight)
                    {
                        posY += shift;
                    }
                    break;
                default:
                    break;
            }
        }

        public override void DrawTransport(Graphics g)
        {
            //тело
            Brush brushPrimary = new SolidBrush(PrimaryColor);
            List<Point> pointsBody = new List<Point>(12);
            pointsBody.Add(new Point(posX + 1, posY + 13));
            pointsBody.Add(new Point(posX + 20, posY + 10));
            pointsBody.Add(new Point(posX + 30, posY + 5));
            pointsBody.Add(new Point(posX + 96, posY + 5));
            pointsBody.Add(new Point(posX + 119, posY + 8));
            pointsBody.Add(new Point(posX + 119, posY + 30));

            pointsBody.Add(new Point(posX + 94, posY + 32));
            pointsBody.Add(new Point(posX + 90, posY + 36));
            pointsBody.Add(new Point(posX + 55, posY + 36));
            pointsBody.Add(new Point(posX + 40, posY + 39));
            pointsBody.Add(new Point(posX + 27, posY + 30));
            pointsBody.Add(new Point(posX + 3, posY + 27));

            g.FillPolygon(brushPrimary, pointsBody.ToArray<Point>());

            brushPrimary.Dispose();

            /*
            //ВП полоса
            Pen penSecondary = new Pen(SecondaryColor);
            g.DrawLine(penSecondary, new Point(posX + 119, posY + 8), new Point(posX + 27, posY + 30));
            g.DrawLine(penSecondary, new Point(posX + 119, posY + 20), new Point(posX + 40, posY + 38));
            penSecondary.Dispose();
            */

            /*if (GunOnBoard)
            {
                //самолёт
                Brush b = new SolidBrush(SecondaryColor);
                //List<Point> pointsAirplane = new List<Point>(4);
                //pointsAirplane.Add(new Point(posX + 110, posY + 15));
                //pointsAirplane.Add(new Point(posX + 105, posY + 20));
                //pointsAirplane.Add(new Point(posX + 112, posY + 20));
                //pointsAirplane.Add(new Point(posX + 110, posY + 18));

                //g.FillPolygon(b, pointsAirplane.ToArray<Point>());

                //пушка
                g.FillRectangle(b, posX + 65, posY + 5, 10, 8);

                Brush red = new SolidBrush(Color.Red);
                g.FillRectangle(red, posX + 60, posY + 6, 10, 2);
                g.FillRectangle(red, posX + 60, posY + 10, 10, 2);
                g.FillRectangle(red, posX + 67, posY + 6, 3, 6);

                b.Dispose();
                red.Dispose();
            }*/

           /* if (HelicoptersOnBoard)
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
            } */
            
            /*Airplanes airplanes = new Airplanes(Count,
                PrimaryColor, SecondaryColor, posX, posY);
            airplanes.DrawAirplanes(g);*/
            
        }
    }
}

