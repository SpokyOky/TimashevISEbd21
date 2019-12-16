using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab1WinForms
{
    public class AircraftCarrier: WarShip, IComparable<AircraftCarrier>,
        IEquatable<AircraftCarrier>
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

            AirplaneType = 0;
        }

        public AircraftCarrier(string info) : base(info)
        {
            var strs = info.Split(';');
            if(strs.Length == 8)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                PrimaryColor = Color.FromName(strs[2]);
                SecondaryColor = Color.FromName(strs[3]);
                Count = (AirplanesCount) Convert.ToInt32(strs[4]);
                GunOnBoard = Convert.ToBoolean(strs[5]);
                HelicoptersOnBoard = Convert.ToBoolean(strs[6]);
                AirplaneType = Convert.ToInt32(strs[7]);
            }
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

        public void SetAirplaneType(int type)
        {
            AirplaneType = type;
        }

        public override string ToString()
        {
            return base.ToString() + ";" + SecondaryColor.Name + ";" +
                (int)Count + ";" + GunOnBoard + ";" + HelicoptersOnBoard + ";"
                + AirplaneType;
        }

        public int CompareTo(AircraftCarrier other)
        {
            var res = (this is WarShip).CompareTo(other is WarShip);
            if (res != 0)
            {
                return res;
            }
            if (SecondaryColor != other.SecondaryColor)
            {
                SecondaryColor.Name.CompareTo(other.SecondaryColor.Name);
            }
            if (GunOnBoard != other.GunOnBoard)
            {
                return GunOnBoard.CompareTo(other.GunOnBoard);
            }
            if (HelicoptersOnBoard != other.HelicoptersOnBoard)
            {
                return  HelicoptersOnBoard.CompareTo(other.HelicoptersOnBoard);
            }
            if (Count != other.Count)
            {
                return Count.CompareTo(other.Count);
            }
            return 0;
        }

        public bool Equals(AircraftCarrier other)
        {
            var res = (this as WarShip).Equals(other as WarShip);
            if (!res)
            {
                return res;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (SecondaryColor!= other.SecondaryColor)
            {
                return false;
            }
            if (GunOnBoard != other.GunOnBoard)
            {
                return false;
            }
            if (HelicoptersOnBoard != other.HelicoptersOnBoard)
            {
                return false;
            }
            if (Count != other.Count)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is AircraftCarrier warshipObj))
            {
                return false;
            }
            else
            {
                return Equals(warshipObj);
            }
        }
    }
}
