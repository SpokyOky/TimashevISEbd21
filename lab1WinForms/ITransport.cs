using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1WinForms
{
    public interface ITransport
    {
        void SetPosition(int x, int y, int widht, int height);

        void MoveTransport(Direction direction);

        void DrawTransport(Graphics g);
    }
}
