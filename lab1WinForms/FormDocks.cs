using NLog;
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

        const int countLevel = 5;

        private Logger logger;

        private int[] shiftX = new int[countLevel];
        private int[] shiftY = new int[countLevel];

        public FormDocks()
        {
            InitializeComponent();

            logger = LogManager.GetCurrentClassLogger();

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
                            dialogDop.Color, true, true);
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
                    try
                    {
                        var warship = docks[listBoxLevel.SelectedIndex] - (Convert.ToInt32(mtbPlace.Text) - 1);

                        Bitmap bmp = new Bitmap(pictureBoxSelectedWarship.Width, pictureBoxSelectedWarship.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        warship.SetPosition(5, 5, pictureBoxSelectedWarship.Width, pictureBoxSelectedWarship.Height);
                        warship.DrawTransport(gr);
                        pictureBoxSelectedWarship.Image = bmp;

                        Draw();
                    }
                    catch (DocksNotFoundException ex)
                    {
                        logger.Error("Корабль на месте " + mtbPlace.Text + " не найден");
                        MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK,
MessageBoxIcon.Error);
                        Bitmap bmp = new Bitmap(pictureBoxSelectedWarship.Width, pictureBoxSelectedWarship.Height);
                        pictureBoxSelectedWarship.Image = bmp;
                    }
                    catch (Exception ex)
                    {
                        logger.Error("Неизвестная ошибка");
                        MessageBox.Show(ex.Message, "Неизвестная ошибка",
MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                try
                {
                    int place = docks[listBoxLevel.SelectedIndex] + warship;
                    logger.Info("Добавлен корабль " + warship + " на место " + place);
                    Draw();
                }
                catch (DocksOverflowException ex)
                {
                    logger.Error("Переполнение на уровне " + listBoxLevel.SelectedIndex);
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
MessageBoxIcon.Error);
                }
                catch (DocksAlreadyHaveException ex)
                {
                    MessageBox.Show(ex.Message, "Дублирование", MessageBoxButtons.OK,
MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Error("Неизвестная ошибка");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            formWS = new FormWarShipConfig();
            formWS.AddEvent(AddWarship);
            formWS.Show();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try {
                    docks.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    logger.Error("Неизвестная ошибка при сохранении");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try {
                    docks.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
    MessageBoxIcon.Information);
                    logger.Info("Загружно из файла " + openFileDialog.FileName);
                }
                catch (DocksOccupiedPlaceException ex)
                {
                    logger.Error("Занятое место");
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,
 MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Error("Неизвестная ошибка при сохранении");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            docks.Sort();
            Draw();
            logger.Info("Сортировка уровней");
        }
    }
}
