using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1WinForms
{
    public class MultiLevelDocks
    {
        List<Docks<ITransport, IAirplanes>> docksStages;
        private int countPlaces = 6;

        private int pictureWidth;
        private int pictureHeight;

        public MultiLevelDocks(int countStages, int picWidth, int picHeight)
        {
            docksStages = new List<Docks<ITransport, IAirplanes>>();
            pictureHeight = picHeight;
            pictureWidth = picWidth;
            for (int i = 0; i < countStages; ++i)
            {
                docksStages.Add(new Docks<ITransport, IAirplanes>(
                    countPlaces, 6, picWidth, picHeight));
            }
        }

        public Docks<ITransport, IAirplanes> this[int index]
        {
            get
            {
                if (index > - 1 && index < docksStages.Count)
                {
                    return docksStages[index];
                }
                return null;
            }
        }

        public ITransport this[int level, int key]
        {
            get
            {
                if (level > -1 && level < docksStages.Count)
                {
                    return docksStages[level].GetTransportByKey(key);
                }
                return null;
            }
        }

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }

            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine("CountLevels:" + docksStages.Count);

                foreach (var level in docksStages)
                {
                    sw.WriteLine("Level");
                    for (int i = 0; i < countPlaces; i++)
                    {
                        var warship = level[i];
                        if (warship != null)
                        {
                            if (warship.GetType().Name == "WarShip")
                            {
                                sw.Write(i + ":WarShip:");
                            }
                            if (warship.GetType().Name == "AircraftCarrier")
                            {
                                sw.Write(i + ":AircraftCarrier:");
                            }
                            sw.WriteLine(warship);
                        }
                    }
                }
            }
            return true;
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            using (StreamReader sr = new StreamReader(filename))
            {
                var strs = sr.ReadLine();
                if (strs.Contains("CountLevels"))
                {
                    int count = Convert.ToInt32(strs.Split(':')[1]);
                    if (docksStages != null)
                    {
                        docksStages.Clear();
                    }
                    docksStages = new List<Docks<ITransport, IAirplanes>>(count);
                }
                else
                {
                    return false;
                }

                int counter = -1;
                ITransport warship = null;
                while(counter < docksStages.Count)
                {
                    strs = sr.ReadLine();
                    if (strs == "Level")
                    {
                        counter++;
                        docksStages.Add(new Docks<ITransport, IAirplanes>(countPlaces,
                            6, pictureWidth, pictureHeight));
                        continue;
                    }

                    if (string.IsNullOrEmpty(strs))
                    {
                        break;
                    }

                    if (strs.Split(':')[1] == "WarShip")
                    {
                        warship = new WarShip(strs.Split(':')[2]);
                    }
                    else if (strs.Split(':')[1] == "AircraftCarrier")
                    {
                        warship = new AircraftCarrier(strs.Split(':')[2]);
                    }
                    docksStages[counter][Convert.ToInt32(strs.Split(':')[0])] = warship;
                }
            }
            return true;
        }
    }
}
