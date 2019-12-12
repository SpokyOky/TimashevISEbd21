using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1WinForms
{
    public partial class FormDocks : Form
    {
        MultiLevelDocks docks;

        FormWarShipConfig formWS;
        FormAirplanes formA;

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

        private void AddAirplanes(IAirplanes airplane)
        {
            if (listBoxLevel.SelectedIndex > -1)
            {
                if (airplane != null)
                {
                    if (airplane is Fighter)
                    {
                        airplane = new Fighter(shiftX[listBoxLevel.SelectedIndex],
                            shiftY[listBoxLevel.SelectedIndex]);
                    }
                    else if (airplane is SimpleAirplane)
                    {
                        airplane = new SimpleAirplane(shiftX[listBoxLevel.SelectedIndex],
                            shiftY[listBoxLevel.SelectedIndex]);
                    }
                    else if (airplane is Stealth)
                    {
                        airplane = new Stealth(shiftX[listBoxLevel.SelectedIndex],
                            shiftY[listBoxLevel.SelectedIndex]);
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
            }
        }

        private void btnLanding_Click(object sender, EventArgs e)
        {
            formA = new FormAirplanes();
            formA.AddEvent(AddAirplanes);
            formA.Show();
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

        private void AddWarship(ITransport warship)
        {
            if (warship != null && listBoxLevel.SelectedIndex > -1)
            {
                int place = docks[listBoxLevel.SelectedIndex] + warship;
                if (place > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Не удалось поставить корабль");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            formWS = new FormWarShipConfig();
            formWS.AddEvent(AddWarship);
            formWS.Show();
        }


        private bool SaveLevelData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }

            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine("Level");

                for (int i = 0; i < docks.countPlaces; i++)
                {
                    var warship = docks[listBoxLevel.SelectedIndex][i];
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

        private bool LoadLevelData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            using (StreamReader sr = new StreamReader(filename))
            {
                var strs = sr.ReadLine();
                if (strs.Contains("Level"))
                {
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
                        docks[listBoxLevel.SelectedIndex][Convert.ToInt32(strs.Split(':')[0])] = warship;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private void сохранитьВсёToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (docks.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьВсёToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (docks.LoadData(openFileDialog.FileName))
                {

                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                Draw();
            }
        }

        private void сохранитьЛевелToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveLevelFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (SaveLevelData(saveLevelFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение левела прошло успешно", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьЛевелToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openLevelFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (LoadLevelData(openLevelFileDialog.FileName))
                {

                    MessageBox.Show("Загрузка левела прошла успешно", "Результат", MessageBoxButtons.OK,
    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не загрузилось", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                Draw();
            }
        }
    }
}
