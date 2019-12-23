namespace lab1WinForms
{
    partial class FormDocks
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
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.btnAddWS = new System.Windows.Forms.Button();
            this.btnAddACC = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbPlace = new System.Windows.Forms.MaskedTextBox();
            this.btnTake = new System.Windows.Forms.Button();
            this.pictureBoxSelectedWarship = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedWarship)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(642, 297);
            this.pictureBoxMain.TabIndex = 0;
            this.pictureBoxMain.TabStop = false;
            // 
            // btnAddWS
            // 
            this.btnAddWS.Location = new System.Drawing.Point(661, 13);
            this.btnAddWS.Name = "btnAddWS";
            this.btnAddWS.Size = new System.Drawing.Size(127, 33);
            this.btnAddWS.TabIndex = 1;
            this.btnAddWS.Text = "Припарковать warship";
            this.btnAddWS.UseVisualStyleBackColor = true;
            this.btnAddWS.Click += new System.EventHandler(this.btnAddWS_Click);
            // 
            // btnAddACC
            // 
            this.btnAddACC.Location = new System.Drawing.Point(661, 52);
            this.btnAddACC.Name = "btnAddACC";
            this.btnAddACC.Size = new System.Drawing.Size(127, 33);
            this.btnAddACC.TabIndex = 2;
            this.btnAddACC.Text = "Припарковать ACC";
            this.btnAddACC.UseVisualStyleBackColor = true;
            this.btnAddACC.Click += new System.EventHandler(this.btnAddACC_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(661, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Место";
            // 
            // mtbPlace
            // 
            this.mtbPlace.Location = new System.Drawing.Point(706, 205);
            this.mtbPlace.Mask = "0";
            this.mtbPlace.Name = "mtbPlace";
            this.mtbPlace.Size = new System.Drawing.Size(13, 20);
            this.mtbPlace.TabIndex = 5;
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(661, 231);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(127, 33);
            this.btnTake.TabIndex = 6;
            this.btnTake.Text = "Забрать корабль";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // pictureBoxSelectedWarship
            // 
            this.pictureBoxSelectedWarship.Location = new System.Drawing.Point(664, 270);
            this.pictureBoxSelectedWarship.Name = "pictureBoxSelectedWarship";
            this.pictureBoxSelectedWarship.Size = new System.Drawing.Size(120, 40);
            this.pictureBoxSelectedWarship.TabIndex = 7;
            this.pictureBoxSelectedWarship.TabStop = false;
            // 
            // FormDocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 322);
            this.Controls.Add(this.pictureBoxSelectedWarship);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.mtbPlace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddACC);
            this.Controls.Add(this.btnAddWS);
            this.Controls.Add(this.pictureBoxMain);
            this.Name = "FormDocks";
            this.Text = "FormDocks";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedWarship)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Button btnAddWS;
        private System.Windows.Forms.Button btnAddACC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbPlace;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.PictureBox pictureBoxSelectedWarship;
    }
}