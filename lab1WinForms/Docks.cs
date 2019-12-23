using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1WinForms
{
    class Docks<T> where T : class, ITransport
    {
        private T[] places;
        private int PicWidth;
        private int PicHeight;
        private const int placeWidth = 200;
        private const int placeHeight = 67;

        public Docks(int sizes, int picWidth, int picHeight)
        {
            places = new T[sizes];
            PicWidth = picWidth;
            PicHeight = picHeight;
        }

        public static int operator +(Docks<T> d, T warship)
        {
            for (int i = 0; i < d.places.Length / 2; i++)
            {
                if (d.CheckFreePlaces(i))
                {
                    d.places[i] = warship;
                    d.places[i].SetPosition(d.PicWidth / 15 + 5 + i * placeWidth,
                        d.PicHeight / 5 + 5, d.PicWidth, d.PicHeight);
                    return i;
                }
            }
            for (int i = d.places.Length / 2; i < d.places.Length; i++)
            {
                if (d.CheckFreePlaces(i))
                {
                    d.places[i] = warship;
                    d.places[i].SetPosition(d.PicWidth / 15 + 5 + (d.places.Length - 1 - i) * placeWidth,
                        d.PicHeight * 4 / 5 - placeHeight + 10, d.PicWidth, d.PicHeight);
                    return i;
                }
            }
            return -1;
        }

        public static T operator -(Docks<T> d, int index)
        {
            if (index < 0 || index > d.places.Length)
            {
                return null;
            }
            if (!d.CheckFreePlaces(index))
            {
                T warship = d.places[index];
                d.places[index] = null;
                return warship;
            }
            return null;
        }

        private bool CheckFreePlaces(int index)
        {
            return places[index] == null;
        }

        public void Draw(Graphics g)
        {
            DrawPlaces(g);
            for (int i = 0; i < places.Length; i++)
            {
                if (!CheckFreePlaces(i))
                {
                    places[i].DrawTransport(g);
                }
            }
        }

        private void DrawPlaces(Graphics g)
        {
            Brush water = new SolidBrush(Color.DodgerBlue);
            g.FillRectangle(water, 0, 0, PicWidth, PicHeight);
            water.Dispose();

            Brush b = new SolidBrush(Color.Black);
            g.FillRectangle(b, 0, 0, PicWidth, PicHeight / 5);
            g.FillRectangle(b, 0, PicHeight * 4 / 5, PicWidth, PicHeight);
            g.FillRectangle(b, 0, 0, PicWidth / 15, PicHeight);
            b.Dispose();

            Pen p = new Pen(Color.Black, 3);
            for (int i = 0; i < places.Length / 2; i++)
            {
                g.DrawLine(p, new Point(PicWidth / 15 + i * placeWidth, PicHeight / 5),
                    new Point(PicWidth / 15 + i * placeWidth, PicHeight / 5 + 20));
            }
            for (int i = 0; i < places.Length / 2; i++)
            {
                g.DrawLine(p, new Point(PicWidth / 15 + i * placeWidth, PicHeight * 4 / 5),
                    new Point(PicWidth / 15 + i * placeWidth, PicHeight * 4 / 5 - 20));
            }
        }
    }
}
