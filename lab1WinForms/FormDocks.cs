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
        MultiLevelDocks docks;

        const int countLevel = 5;

        private int[] shiftX = new int[countLevel];
        private int[] shiftY = new int[countLevel];

        public FormDocks()
        {
            InitializeComponent();
            docks = new MultiLevelDocks(countLevel, pictureBoxDocks.Width, pictureBoxDocks.Height);
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevel.Items.Add("Уровень " + (i + 1));
            }
        }

        private void Draw()
        {
            if (listBoxLevel.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxDocks.Width, pictureBoxDocks.Height);
                Graphics gr = Graphics.FromImage(bmp);
                docks[listBoxLevel.SelectedIndex].Draw(gr);
                pictureBoxDocks.Image = bmp;
            }
        }

        private void btnAddWS_Click(object sender, EventArgs e)
        {
            if (listBoxLevel.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var warship = new WarShip(100, 1000, dialog.Color);
                    int place = docks[listBoxLevel.SelectedIndex] + warship;
                    Draw();
                }
            }
        }

        private void btnAddACC_Click(object sender, EventArgs e)
        {
            if (listBoxLevel.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var warship = new AircraftCarrier(100, 1000, dialog.Color,
                            dialogDop.Color, AirplanesCount.SIX, true, true);
                        int place = docks[listBoxLevel.SelectedIndex] + warship;
                        Draw();
                    }
                }
            }
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            if (listBoxLevel.SelectedIndex > -1)
            {
                if (mtbPlace.Text != "")
                {
                    var warship = docks[listBoxLevel.SelectedIndex] - (Convert.ToInt32(mtbPlace.Text) - 1);
                    if (warship != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        warship.SetPosition(5, 5, pictureBox2.Width, pictureBox2.Height);
                        warship.DrawTransport(gr);
                        pictureBox2.Image = bmp;
                    }
                    else
                    {
                        Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                        pictureBox2.Image = bmp;
                    }
                    Draw();
                }
            }
        }

        private void btnLanding_Click(object sender, EventArgs e)
        {
            int AirplaneType = new Random().Next(3);
            IAirplanes airplane;
            switch (AirplaneType)
            {
                case 0:
                    airplane = new Fighter(shiftX[listBoxLevel.SelectedIndex],
                        shiftY[listBoxLevel.SelectedIndex]);
                    break;
                case 1:
                    airplane = new SimpleAirplane(shiftX[listBoxLevel.SelectedIndex], 
                        shiftY[listBoxLevel.SelectedIndex]);
                    break;
                case 2:
                    airplane = new Stealth(shiftX[listBoxLevel.SelectedIndex], 
                        shiftY[listBoxLevel.SelectedIndex]);
                    break;
                default:
                    airplane = new Stealth(shiftX[listBoxLevel.SelectedIndex],
                        shiftY[listBoxLevel.SelectedIndex]);
                    break;
            }
            docks[listBoxLevel.SelectedIndex].AddAirplanes(airplane);
            shiftX[listBoxLevel.SelectedIndex] += 100;
            if (shiftX[listBoxLevel.SelectedIndex] >= 700)
            {
                shiftX[listBoxLevel.SelectedIndex] = 0;
                shiftY[listBoxLevel.SelectedIndex] += 30;
            }
            Draw();
        }

        private void btnCompareLess_Click(object sender, EventArgs e)
        {
            if (listBoxLevel.SelectedIndex > -1)
            {
                if (mtbPlace.Text != "")
                {
                    if (docks[listBoxLevel.SelectedIndex] < Convert.ToInt32(mtbPlace.Text))
                    {
                        labelCompareText.Text = "Свободных мест меньше " + mtbPlace.Text;
                    }
                    else if (docks[listBoxLevel.SelectedIndex] > Convert.ToInt32(mtbPlace.Text))
                    {
                        labelCompareText.Text = "Свободных мест больше " + mtbPlace.Text;
                    }
                    else
                    {
                        labelCompareText.Text = "Свободных мест равно " + mtbPlace.Text;
                    }
                }
            }
        }

        private void listBoxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
