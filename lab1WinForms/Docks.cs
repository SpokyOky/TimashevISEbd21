using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1WinForms
{
    public class Docks<T, A> : IEnumerator<T>, IEnumerable<T>, IComparable<Docks<T, A>>
        where T : class, ITransport
        where A : class, IAirplanes
    {
        private Dictionary<int, T> places;
        private int maxPlaces;
        private A[] airplanes;
        private Queue<T> removedTransport;

        private int currentIndex;

        private int PicWidth;
        private int PicHeight;
        private const int placeWidth = 200;
        private const int placeHeight = 67;
        
        public Docks(int sizes, int countAiplanes, int picWidth, int picHeight)
        {
            currentIndex = -1;
            maxPlaces = sizes;
            places = new Dictionary<int, T>();
            airplanes = new A[countAiplanes];
            removedTransport = new Queue<T>();
            PicWidth = picWidth;
            PicHeight = picHeight;
        }

        public static int operator +(Docks<T, A> d, T warship)
        {
            if (d.places.Count == d.maxPlaces)
            {
                throw new DocksOverflowException();
            }
            if (d.places.ContainsValue(warship))
            {
                throw new DocksAlreadyHaveException();
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

        public static T operator -(Docks<T, A> d, int index)
        {
            if (!d.CheckFreePlaces(index))
            {
                T warship = d.places[index];
                d.removedTransport.Enqueue(warship);
                d.places.Remove(index);
                return warship;
            }

            throw new DocksNotFoundException(index);
        }

        public static bool operator <(Docks<T, A> d, int compareWith)
        {
            int freePlaces = 0;
            for (int i = 0; i < d.maxPlaces; i++)
            {
                if (d.CheckFreePlaces(i))
                {
                    freePlaces++;
                }
            }
            return freePlaces < compareWith;
        }

        public static bool operator >(Docks<T, A> d, int compareWith)
        {
            int freePlaces = 0;
            for (int i = 0; i < d.maxPlaces; i++)
            {
                if (d.CheckFreePlaces(i))
                {
                    freePlaces++;
                }
            }
            return freePlaces > compareWith;
        }

        public void AddAirplanes(A airplane)
        {
            for (int i = 0; i < airplanes.Length; i++)
            {
                if (airplanes[i] == null)
                {
                    airplanes[i] = airplane;
                    break;
                }
            }
        }

        public T Current
        {
            get
            {
                return places[places.Keys.ToList()[currentIndex]];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Clear()
        {
            places.Clear();
        }

        public void Draw(Graphics g)
        {
            DrawPlaces(g);
            foreach(var i in places)
            {
                i.Value.DrawTransport(g);
            }

            for (int i = 0; i < airplanes.Length; i++)
            {
                if (airplanes[i] != null)
                {
                    airplanes[i].DrawAirplanes(AirplanesCount.THREE, g, Color.White);
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

        public int GetKey
        {
            get
            {
                return places.Keys.ToList()[currentIndex];
            }
        }

        public T GetTransportByKey(int key)
        {
            return places.ContainsKey(key) ? places[key] : null;
        }

        private bool CheckFreePlaces(int index)
        {
            return !places.ContainsKey(index);
        }

        public void Dispose()
        {
            places.Clear();
        }

        public bool MoveNext()
        {
            if (currentIndex + 1 >= places.Count)
            {
                Reset();
                return false;
            }
            currentIndex++;
            return true;
        }

        public void Reset()
        {
            currentIndex = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int CompareTo(Docks<T, A> other)
        {
            if (places.Count > other.places.Count)
            {
                return -1;
            }
            else if (places.Count < other.places.Count)
            {
                return 1;
            }
            else if (places.Count > 0)
            {
                var thisKeys = places.Keys.ToList();
                var otherKeys = other.places.Keys.ToList();
                for (int i = 0; i < places.Count; ++i)
                {
                    if (places[thisKeys[i]] is WarShip && other.places[thisKeys[i]] is
                   AircraftCarrier)
                    {
                        return 1;
                    }
                    if (places[thisKeys[i]] is AircraftCarrier && other.places[thisKeys[i]]
                    is WarShip)
                    {
                        return -1;
                    }
                    if (places[thisKeys[i]] is WarShip && other.places[thisKeys[i]] is
                    WarShip)
                    {
                        return (places[thisKeys[i]] is
                       WarShip).CompareTo(other.places[thisKeys[i]] is WarShip);
                    }
                    if (places[thisKeys[i]] is AircraftCarrier && other.places[thisKeys[i]]
                    is AircraftCarrier)
                    {
                        return (places[thisKeys[i]] is
                       AircraftCarrier).CompareTo(other.places[thisKeys[i]] is AircraftCarrier);
                    }
                }
            }
            return 0;
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
                else
                {
                    throw new DocksOccupiedPlaceException(ind);
                }
            }
        }
    }
}
