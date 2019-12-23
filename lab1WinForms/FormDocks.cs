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
            docks = new Docks<ITransport>(6, pictureBoxMain.Width,
           pictureBoxMain.Height);
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxMain.Width, pictureBoxMain.Height);
            Graphics gr = Graphics.FromImage(bmp);
            docks.Draw(gr);
            pictureBoxMain.Image = bmp;
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

        private void btnAddACC_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var warship = new AircraftCarrier(100, 1000, dialog.Color, 
                        dialogDop.Color, true, true);
                    int place = docks + warship;
                    Draw();
                }
            }
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            if(mtbPlace.Text != "")
            {
                var warship = docks - (Convert.ToInt32(mtbPlace.Text) - 1);
                if(warship != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxSelectedCar.Width, pictureBoxSelectedCar.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    warship.SetPosition(5, 5, pictureBoxSelectedCar.Width,pictureBoxSelectedCar.Height);
                    warship.DrawTransport(gr);
                    pictureBoxSelectedCar.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxSelectedCar.Width, pictureBoxSelectedCar.Height);
                    pictureBoxSelectedCar.Image = bmp;
                }
                Draw();
            }
        }
    }
}
