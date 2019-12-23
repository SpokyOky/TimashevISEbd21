namespace lab1WinForms
{
    partial class FormWarShipConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxTransport = new System.Windows.Forms.PictureBox();
            this.groupBoxWarShipType = new System.Windows.Forms.GroupBox();
            this.labelAircraftCarrier = new System.Windows.Forms.Label();
            this.labelWarShip = new System.Windows.Forms.Label();
            this.panelPictureBox = new System.Windows.Forms.Panel();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.labelColorWhite = new System.Windows.Forms.Label();
            this.labelColorBlack = new System.Windows.Forms.Label();
            this.labelColorBlue = new System.Windows.Forms.Label();
            this.labelColorGreen = new System.Windows.Forms.Label();
            this.labelColorPink = new System.Windows.Forms.Label();
            this.labelColorMagenta = new System.Windows.Forms.Label();
            this.labelColorYellow = new System.Windows.Forms.Label();
            this.labelColorCrimson = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.labelSecondColor = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTransport)).BeginInit();
            this.groupBoxWarShipType.SuspendLayout();
            this.panelPictureBox.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxTransport
            // 
            this.pictureBoxTransport.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxTransport.Name = "pictureBoxTransport";
            this.pictureBoxTransport.Size = new System.Drawing.Size(120, 40);
            this.pictureBoxTransport.TabIndex = 0;
            this.pictureBoxTransport.TabStop = false;
            // 
            // groupBoxWarShipType
            // 
            this.groupBoxWarShipType.Controls.Add(this.labelAircraftCarrier);
            this.groupBoxWarShipType.Controls.Add(this.labelWarShip);
            this.groupBoxWarShipType.Location = new System.Drawing.Point(13, 13);
            this.groupBoxWarShipType.Name = "groupBoxWarShipType";
            this.groupBoxWarShipType.Size = new System.Drawing.Size(200, 100);
            this.groupBoxWarShipType.TabIndex = 1;
            this.groupBoxWarShipType.TabStop = false;
            this.groupBoxWarShipType.Text = "Тип корабля";
            // 
            // labelAircraftCarrier
            // 
            this.labelAircraftCarrier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAircraftCarrier.Location = new System.Drawing.Point(7, 61);
            this.labelAircraftCarrier.Name = "labelAircraftCarrier";
            this.labelAircraftCarrier.Size = new System.Drawing.Size(187, 36);
            this.labelAircraftCarrier.TabIndex = 1;
            this.labelAircraftCarrier.Text = "AircraftCarrier";
            this.labelAircraftCarrier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAircraftCarrier.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAircraftCarrier_MouseDown);
            // 
            // labelWarShip
            // 
            this.labelWarShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelWarShip.Location = new System.Drawing.Point(7, 20);
            this.labelWarShip.Name = "labelWarShip";
            this.labelWarShip.Size = new System.Drawing.Size(187, 36);
            this.labelWarShip.TabIndex = 0;
            this.labelWarShip.Text = "WarShip";
            this.labelWarShip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelWarShip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelWarShip_MouseDown);
            // 
            // panelPictureBox
            // 
            this.panelPictureBox.AllowDrop = true;
            this.panelPictureBox.Controls.Add(this.labelSecondColor);
            this.panelPictureBox.Controls.Add(this.labelMainColor);
            this.panelPictureBox.Controls.Add(this.pictureBoxTransport);
            this.panelPictureBox.Location = new System.Drawing.Point(219, 13);
            this.panelPictureBox.Name = "panelPictureBox";
            this.panelPictureBox.Size = new System.Drawing.Size(127, 100);
            this.panelPictureBox.TabIndex = 2;
            this.panelPictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelPictureBox_DragDrop);
            this.panelPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelPictureBox_DragEnter);
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.labelColorPink);
            this.groupBoxColors.Controls.Add(this.labelColorMagenta);
            this.groupBoxColors.Controls.Add(this.labelColorYellow);
            this.groupBoxColors.Controls.Add(this.labelColorCrimson);
            this.groupBoxColors.Controls.Add(this.labelColorBlue);
            this.groupBoxColors.Controls.Add(this.labelColorGreen);
            this.groupBoxColors.Controls.Add(this.labelColorBlack);
            this.groupBoxColors.Controls.Add(this.labelColorWhite);
            this.groupBoxColors.Location = new System.Drawing.Point(352, 16);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(153, 100);
            this.groupBoxColors.TabIndex = 3;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // labelColorWhite
            // 
            this.labelColorWhite.BackColor = System.Drawing.Color.White;
            this.labelColorWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColorWhite.Location = new System.Drawing.Point(6, 16);
            this.labelColorWhite.Name = "labelColorWhite";
            this.labelColorWhite.Size = new System.Drawing.Size(30, 30);
            this.labelColorWhite.TabIndex = 0;
            // 
            // labelColorBlack
            // 
            this.labelColorBlack.BackColor = System.Drawing.Color.Black;
            this.labelColorBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColorBlack.Location = new System.Drawing.Point(6, 58);
            this.labelColorBlack.Name = "labelColorBlack";
            this.labelColorBlack.Size = new System.Drawing.Size(30, 30);
            this.labelColorBlack.TabIndex = 1;
            // 
            // labelColorBlue
            // 
            this.labelColorBlue.BackColor = System.Drawing.Color.Blue;
            this.labelColorBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColorBlue.Location = new System.Drawing.Point(42, 58);
            this.labelColorBlue.Name = "labelColorBlue";
            this.labelColorBlue.Size = new System.Drawing.Size(30, 30);
            this.labelColorBlue.TabIndex = 3;
            // 
            // labelColorGreen
            // 
            this.labelColorGreen.BackColor = System.Drawing.Color.Green;
            this.labelColorGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColorGreen.Location = new System.Drawing.Point(42, 16);
            this.labelColorGreen.Name = "labelColorGreen";
            this.labelColorGreen.Size = new System.Drawing.Size(30, 30);
            this.labelColorGreen.TabIndex = 2;
            // 
            // labelColorPink
            // 
            this.labelColorPink.BackColor = System.Drawing.Color.DeepPink;
            this.labelColorPink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColorPink.Location = new System.Drawing.Point(114, 58);
            this.labelColorPink.Name = "labelColorPink";
            this.labelColorPink.Size = new System.Drawing.Size(30, 30);
            this.labelColorPink.TabIndex = 7;
            // 
            // labelColorMagenta
            // 
            this.labelColorMagenta.BackColor = System.Drawing.Color.Magenta;
            this.labelColorMagenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColorMagenta.Location = new System.Drawing.Point(114, 16);
            this.labelColorMagenta.Name = "labelColorMagenta";
            this.labelColorMagenta.Size = new System.Drawing.Size(30, 30);
            this.labelColorMagenta.TabIndex = 6;
            // 
            // labelColorYellow
            // 
            this.labelColorYellow.BackColor = System.Drawing.Color.Yellow;
            this.labelColorYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColorYellow.Location = new System.Drawing.Point(78, 58);
            this.labelColorYellow.Name = "labelColorYellow";
            this.labelColorYellow.Size = new System.Drawing.Size(30, 30);
            this.labelColorYellow.TabIndex = 5;
            // 
            // labelColorCrimson
            // 
            this.labelColorCrimson.BackColor = System.Drawing.Color.Crimson;
            this.labelColorCrimson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColorCrimson.Location = new System.Drawing.Point(78, 16);
            this.labelColorCrimson.Name = "labelColorCrimson";
            this.labelColorCrimson.Size = new System.Drawing.Size(30, 30);
            this.labelColorCrimson.TabIndex = 4;
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(3, 46);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(46, 50);
            this.labelMainColor.TabIndex = 1;
            this.labelMainColor.Text = "Primary Color";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // labelSecondColor
            // 
            this.labelSecondColor.AllowDrop = true;
            this.labelSecondColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSecondColor.Location = new System.Drawing.Point(55, 46);
            this.labelSecondColor.Name = "labelSecondColor";
            this.labelSecondColor.Size = new System.Drawing.Size(68, 50);
            this.labelSecondColor.TabIndex = 2;
            this.labelSecondColor.Text = "Secondary Color";
            this.labelSecondColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSecondColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelSecondColor_DragDrop);
            this.labelSecondColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 119);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(230, 34);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(274, 119);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(230, 34);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormWarShipConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 164);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.panelPictureBox);
            this.Controls.Add(this.groupBoxWarShipType);
            this.Name = "FormWarShipConfig";
            this.Text = "FormWarShipConfig";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTransport)).EndInit();
            this.groupBoxWarShipType.ResumeLayout(false);
            this.panelPictureBox.ResumeLayout(false);
            this.groupBoxColors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTransport;
        private System.Windows.Forms.GroupBox groupBoxWarShipType;
        private System.Windows.Forms.Label labelAircraftCarrier;
        private System.Windows.Forms.Label labelWarShip;
        private System.Windows.Forms.Panel panelPictureBox;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Label labelColorPink;
        private System.Windows.Forms.Label labelColorMagenta;
        private System.Windows.Forms.Label labelColorYellow;
        private System.Windows.Forms.Label labelColorCrimson;
        private System.Windows.Forms.Label labelColorBlue;
        private System.Windows.Forms.Label labelColorGreen;
        private System.Windows.Forms.Label labelColorBlack;
        private System.Windows.Forms.Label labelColorWhite;
        private System.Windows.Forms.Label labelSecondColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}