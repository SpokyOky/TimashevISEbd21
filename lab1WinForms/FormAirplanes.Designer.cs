namespace lab1WinForms
{
    partial class FormAirplanes
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
            this.lblSimpleAirplane = new System.Windows.Forms.Label();
            this.lblFighter = new System.Windows.Forms.Label();
            this.lblStealth = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBoxAirplanes = new System.Windows.Forms.PictureBox();
            this.panelPictureBox = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirplanes)).BeginInit();
            this.panelPictureBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSimpleAirplane
            // 
            this.lblSimpleAirplane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSimpleAirplane.Location = new System.Drawing.Point(12, 9);
            this.lblSimpleAirplane.Name = "lblSimpleAirplane";
            this.lblSimpleAirplane.Size = new System.Drawing.Size(100, 23);
            this.lblSimpleAirplane.TabIndex = 0;
            this.lblSimpleAirplane.Text = "SimpleAirplane";
            this.lblSimpleAirplane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSimpleAirplane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblSimpleAirplane_MouseDown);
            // 
            // lblFighter
            // 
            this.lblFighter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFighter.Location = new System.Drawing.Point(118, 9);
            this.lblFighter.Name = "lblFighter";
            this.lblFighter.Size = new System.Drawing.Size(100, 23);
            this.lblFighter.TabIndex = 1;
            this.lblFighter.Text = "Fighter";
            this.lblFighter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFighter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblFighter_MouseDown);
            // 
            // lblStealth
            // 
            this.lblStealth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStealth.Location = new System.Drawing.Point(224, 9);
            this.lblStealth.Name = "lblStealth";
            this.lblStealth.Size = new System.Drawing.Size(100, 23);
            this.lblStealth.TabIndex = 2;
            this.lblStealth.Text = "Stealth";
            this.lblStealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStealth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblStealth_MouseDown);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 35);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(118, 35);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pictureBoxAirplanes
            // 
            this.pictureBoxAirplanes.BackColor = System.Drawing.Color.Black;
            this.pictureBoxAirplanes.Location = new System.Drawing.Point(-1, -1);
            this.pictureBoxAirplanes.Name = "pictureBoxAirplanes";
            this.pictureBoxAirplanes.Size = new System.Drawing.Size(100, 23);
            this.pictureBoxAirplanes.TabIndex = 7;
            this.pictureBoxAirplanes.TabStop = false;
            // 
            // panelPictureBox
            // 
            this.panelPictureBox.AllowDrop = true;
            this.panelPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPictureBox.Controls.Add(this.pictureBoxAirplanes);
            this.panelPictureBox.Location = new System.Drawing.Point(224, 35);
            this.panelPictureBox.Name = "panelPictureBox";
            this.panelPictureBox.Size = new System.Drawing.Size(100, 23);
            this.panelPictureBox.TabIndex = 8;
            this.panelPictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelPictureBoxAirplanes_DragDrop);
            this.panelPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelPictureBoxAirplanes_DragEnter);
            // 
            // FormAirplanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 70);
            this.Controls.Add(this.panelPictureBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblStealth);
            this.Controls.Add(this.lblFighter);
            this.Controls.Add(this.lblSimpleAirplane);
            this.Name = "FormAirplanes";
            this.Text = "FormAirplanes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirplanes)).EndInit();
            this.panelPictureBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSimpleAirplane;
        private System.Windows.Forms.Label lblFighter;
        private System.Windows.Forms.Label lblStealth;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBoxAirplanes;
        private System.Windows.Forms.Panel panelPictureBox;
    }
}