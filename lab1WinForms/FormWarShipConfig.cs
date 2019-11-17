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
    public partial class FormWarShipConfig : Form
    {
        ITransport warship = null;

        private event warshipDelegate eventAddWarship;

        public FormWarShipConfig()
        {
            InitializeComponent();

            labelColorBlack.MouseDown += labelColor_MouseDown;
            labelColorBlue.MouseDown += labelColor_MouseDown;
            labelColorCrimson.MouseDown += labelColor_MouseDown;
            labelColorGreen.MouseDown += labelColor_MouseDown;
            labelColorMagenta.MouseDown += labelColor_MouseDown;
            labelColorPink.MouseDown += labelColor_MouseDown;
            labelColorWhite.MouseDown += labelColor_MouseDown;
            labelColorYellow.MouseDown += labelColor_MouseDown;

            btnCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        public void DrawTransport()
        {
            if (warship != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxTransport.Width, pictureBoxTransport.Height);
                Graphics gr = Graphics.FromImage(bmp);
                warship.SetPosition(0, 0, pictureBoxTransport.Width, pictureBoxTransport.Height);
                warship.DrawTransport(gr);
                pictureBoxTransport.Image = bmp;
            }
        }

        public void AddEvent(warshipDelegate e)
        {
            if(eventAddWarship == null)
            {
                eventAddWarship = new warshipDelegate(e);
            }
            else
            {
                eventAddWarship += e;
            }
        }

        private void labelWarShip_MouseDown(object sender, MouseEventArgs e)
        {
            labelWarShip.DoDragDrop(labelWarShip.Text, 
                DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelAircraftCarrier_MouseDown(object sender, MouseEventArgs e)
        {
            labelAircraftCarrier.DoDragDrop(labelAircraftCarrier.Text,
                DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelPictureBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelPictureBox_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "WarShip":
                    warship = new WarShip(100, 500, Color.Black);
                    break;
                case "AircraftCarrier":
                    warship = new AircraftCarrier(100, 500, 
                        Color.Black, Color.White, AirplanesCount.FIVE, true, true);
                    break;
            }
            DrawTransport();
        }

        private void labelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, 
                DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelMainColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            if (warship != null)
            {
                warship.SetPrimaryColor((Color)e.Data.GetData(typeof(Color)));
                DrawTransport();
            }
        }

        private void labelSecondColor_DragDrop(object sender, DragEventArgs e)
        {
            if(warship != null)
            {
                if (warship is AircraftCarrier)
                {
                    (warship as 
                        AircraftCarrier).SetSecondaryColor((Color)e.Data.GetData(typeof(Color)));
                    DrawTransport();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            eventAddWarship?.Invoke(warship);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
