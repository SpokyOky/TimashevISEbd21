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
        public int countPlaces = 6;

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

        public void SaveData(string filename)
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
                    foreach (ITransport warship in level)
                    {
                        try
                        {
                            if (warship != null)
                            {
                                if (warship.GetType().Name == "WarShip")
                                {
                                    sw.Write(level.GetKey + ":WarShip:");
                                }
                                if (warship.GetType().Name == "AircraftCarrier")
                                {
                                    sw.Write(level.GetKey + ":AircraftCarrier:");
                                }
                                sw.WriteLine(warship);
                            }
                        }
                        finally { }
                    }
                }
            }
        }

        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
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
                    throw new Exception("Неверный формат файла");
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
        }

        public bool SaveLevelData(string filename, int selectedLevel)
        {
            if (selectedLevel < 0 || selectedLevel >= countPlaces)
            {
                return false;
            }

            if (File.Exists(filename))
            {
                File.Delete(filename);
            }

            if (docksStages[selectedLevel] == null)
            {
                return false;
            }

            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine("Level");

                for (int i = 0; i < countPlaces; i++)
                {
                    var warship = docksStages[selectedLevel][i];
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

                sw.WriteLine("Level");
            }
            return true;
        }

        public bool LoadLevelData(string filename, int selectedLevel)
        {
            if (selectedLevel < 0 || selectedLevel >= countPlaces)
            {
                return false;
            }

            if (!File.Exists(filename))
            {
                return false;
            }


            using (StreamReader sr = new StreamReader(filename))
            {
                var strs = sr.ReadLine();
                if (strs.Contains("Level"))
                {
                    docksStages[selectedLevel].Clear();

                    int counter = -1;
                    ITransport warship = null;
                    while (counter < 1)
                    {
                        strs = sr.ReadLine();
                        if (strs == "Level")
                        {
                            counter++;
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
                        docksStages[selectedLevel][Convert.ToInt32(strs.Split(':')[0])] = warship;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public void Sort()
        {
            docksStages.Sort();
        }
    }
}
