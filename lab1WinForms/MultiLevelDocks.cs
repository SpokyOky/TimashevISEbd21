using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1WinForms
{
    public class MultiLevelDocks
    {
        List<Docks<ITransport>> docksStages;
        private int countPlaces = 6;

        public MultiLevelDocks(int countStages, int picWidth, int picHeight)
        {
            docksStages = new List<Docks<ITransport>>();

            for (int i = 0; i < countStages; ++i)
            {
                docksStages.Add(new Docks<ITransport>(
                    countPlaces, 6, picWidth, picHeight));
            }
        }

        public Docks<ITransport> this[int index]
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
