using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab1WinForms
{
    class AircraftCarrier
    {
        private int posX;
        private int posY;

        private int startPosX;
        private int startPosY;

        private int picWidth;
        private int picHeight;

        private const int carrierWidht = 120;
        private const int carrierHeight = 40;

        public int MaxSpeed { private set; get; }

        public double Weight { private set; get; }

        public Color PrimaryColor { private set; get; }

        public Color SecondaryColor { private set; get; }

        public bool AirplanesOnBoard { private set; get; } //переделать в пушку

        public bool HelicoptersOnBoard { private set; get; }

        public AircraftCarrier(int maxSpeed, double weight, Color primaryColor,
            Color secondaryColor, bool airplanesOnBoard, bool helicoptersOnBoard)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            PrimaryColor = primaryColor;
            SecondaryColor = secondaryColor;
            AirplanesOnBoard = airplanesOnBoard; 
            HelicoptersOnBoard = helicoptersOnBoard;
        }

        public void SetPosition(int x, int y, int widht, int height)
        {
            posX = startPosX = x;
            posY = startPosY = y;
            picWidth = widht;
            picHeight = height;
        }

        public void MoveTransport(Direction direction)
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
                    if(posY + shift < picHeight - carrierHeight)
                    {
                        posY += shift;
                    }
                    break;
                default:
                    break;
            }
        }

        public void DrawCarrier(Graphics g)
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


            //ВП полоса
            Pen penSecondary = new Pen(SecondaryColor);
            g.DrawLine(penSecondary, new Point(posX + 119, posY + 8), new Point(posX + 27, posY + 30));
            g.DrawLine(penSecondary, new Point(posX + 119, posY + 20), new Point(posX + 40, posY + 38));

            if (AirplanesOnBoard)
            {
                //самолёт
                Brush b = new SolidBrush(SecondaryColor);
                List<Point> pointsAirplane = new List<Point>(4);
                pointsAirplane.Add(new Point(posX + 110, posY + 15));
                pointsAirplane.Add(new Point(posX + 105, posY + 20));
                pointsAirplane.Add(new Point(posX + 112, posY + 20));
                pointsAirplane.Add(new Point(posX + 110, posY + 18));

                g.FillPolygon(b, pointsAirplane.ToArray<Point>());
            }

            if (HelicoptersOnBoard)
            {
                Pen p = new Pen(SecondaryColor);
                
            }
        }
    }
}
