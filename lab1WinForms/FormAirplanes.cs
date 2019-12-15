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
    public partial class FormAirplanes : Form
    {
        IAirplanes airplanes = null;

        private event airplanesDelegate eventAddAirplanes;

        public FormAirplanes()
        {
            InitializeComponent();
        }

        private void lblSimpleAirplane_MouseDown(object sender, MouseEventArgs e)
        {
            lblSimpleAirplane.DoDragDrop(lblSimpleAirplane.Text,
                DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void lblFighter_MouseDown(object sender, MouseEventArgs e)
        {
            lblFighter.DoDragDrop(lblFighter.Text,
                   DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void lblStealth_MouseDown(object sender, MouseEventArgs e)
        {
            lblStealth.DoDragDrop(lblStealth.Text,
                DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelPictureBoxAirplanes_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "SimpleAirplane":
                    airplanes = new SimpleAirplane(-60, -10);
                    break;
                case "Fighter":
                    airplanes = new Fighter(-60, -10);
                    break;
                case "Stealth":
                    airplanes = new Stealth(-60, -10);
                    break;
            }
            DrawTransport();
        }

        private void panelPictureBoxAirplanes_DragEnter(object sender, DragEventArgs e)
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

        public void DrawTransport()
        {
            if (airplanes != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxAirplanes.Width, pictureBoxAirplanes.Height);
                Graphics gr = Graphics.FromImage(bmp);
                airplanes.DrawAirplanes(AirplanesCount.THREE, gr, Color.White);
                pictureBoxAirplanes.Image = bmp;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            eventAddAirplanes?.Invoke(airplanes);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void AddEvent(airplanesDelegate e)
        {
            if (eventAddAirplanes == null)
            {
                eventAddAirplanes = new airplanesDelegate(e);
            }
            else
            {
                eventAddAirplanes += e;
            }
        }
    }
}
