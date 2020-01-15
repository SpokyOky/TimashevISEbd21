using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1WinForms
{
    public class Docks<T>
        where T : class, ITransport
    {
        private Dictionary<int, T> places;
        public int maxPlaces { get; private set; }

        private int PicWidth;
        private int PicHeight;
        private const int placeWidth = 200;
        private const int placeHeight = 67;

        public Docks(int sizes, int countAiplanes, int picWidth, int picHeight)
        {
            maxPlaces = sizes;
            places = new Dictionary<int, T>();
            PicWidth = picWidth;
            PicHeight = picHeight;
        }

        public static int operator +(Docks<T> d, T warship)
        {
            if(d.places.Count == d.maxPlaces)
            {
                return -1;
            }
            for (int i = 0; i < d.maxPlaces / 2; i++)
            {
                if (d.CheckFreePlaces(i))
                {
                    d.places.Add(i, warship);
                    d.places[i].SetPosition(d.PicWidth / 15 + 5 + i * placeWidth,
                        d.PicHeight / 5 + 5, d.PicWidth, d.PicHeight);

                    return i;
                }
            }
            for (int i = d.maxPlaces / 2; i < d.maxPlaces; i++)
            {
                if (d.CheckFreePlaces(i))
                {
                    d.places.Add(i, warship);
                    d.places[i].SetPosition(d.PicWidth / 15 + 5 + (d.maxPlaces- 1 - i) * placeWidth,
                        d.PicHeight * 4 / 5 - placeHeight + 10, d.PicWidth, d.PicHeight);
                    return i;
                }
            }
            return -1;
        }

        public static T operator -(Docks<T> d, int index)
        {
            if (index < 0 || index > d.maxPlaces)
            {
                return null;
            }
            if (!d.CheckFreePlaces(index))
            {
                T warship = d.places[index];
                d.places.Remove(index);
                return warship;
            }
            return null;
        }

        private bool CheckFreePlaces(int index)
        {
            return !places.ContainsKey(index);
        }

        public void Draw(Graphics g)
        {
            DrawPlaces(g);
            foreach(var i in places)
            {
                i.Value.DrawTransport(g);
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
            for (int i = 0; i < maxPlaces / 2; i++)
            {
                g.DrawLine(p, new Point(PicWidth / 15 + i * placeWidth, PicHeight / 5),
                    new Point(PicWidth / 15 + i * placeWidth, PicHeight / 5 + 20));
            }
            for (int i = 0; i < maxPlaces / 2; i++)
            {
                g.DrawLine(p, new Point(PicWidth / 15 + i * placeWidth, PicHeight * 4 / 5),
                    new Point(PicWidth / 15 + i * placeWidth, PicHeight * 4 / 5 - 20));
            }
        }

        public T this[int ind]
        {
            get
            {
                if (places.ContainsKey(ind))
                {
                    return places[ind];
                }
                return null;
            }
            set
            {
                if (CheckFreePlaces(ind))
                {
                    places.Add(ind, value);
                    if (ind < 3)
                    {
                        places[ind].SetPosition(PicWidth / 15 + 5 + ind * placeWidth,
                            PicHeight / 5 + 5, PicWidth, PicHeight);
                    }
                    else
                    {
                        places[ind].SetPosition(PicWidth / 15 + 5 + (maxPlaces - 1 - ind) * placeWidth,
                        PicHeight * 4 / 5 - placeHeight + 10, PicWidth, PicHeight);
                    }
                }
            }
        }
    }
}
