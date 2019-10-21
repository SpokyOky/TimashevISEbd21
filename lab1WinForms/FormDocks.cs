using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1WinForms
{
    public partial class FormDocks : Form
    {
        Docks<ITransport> docks;
        public FormDocks()
        {
            InitializeComponent();
            docks = new Docks<ITransport>(6, pictureBox1.Width,
           pictureBox1.Height);
            Draw();
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);
            docks.Draw(gr);
            pictureBox1.Image = bmp;
        }

        private void btnAddWS_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var warship = new WarShip(100, 1000, dialog.Color);
                int place = docks + warship;
                Draw();
            }
        }
    }
}
