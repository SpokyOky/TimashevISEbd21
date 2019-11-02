using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1WinForms
{
    public class MultiLevelDocks
    {
        List<Docks<ITransport, IAirplanes>> docksStages;
        private int countPlaces = 6;

        public MultiLevelDocks(int countStages, int picWidth, int picHeight)
        {
            docksStages = new List<Docks<ITransport, IAirplanes>>();

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
    }
}
