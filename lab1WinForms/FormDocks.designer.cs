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
            this.pictureBoxDocks = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbPlace = new System.Windows.Forms.MaskedTextBox();
            this.btnTake = new System.Windows.Forms.Button();
            this.pictureBoxSelectedWarship = new System.Windows.Forms.PictureBox();
            this.labelCompareText = new System.Windows.Forms.Label();
            this.listBoxLevel = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedWarship)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDocks
            // 
            this.pictureBoxDocks.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxDocks.Name = "pictureBoxDocks";
            this.pictureBoxDocks.Size = new System.Drawing.Size(642, 385);
            this.pictureBoxDocks.TabIndex = 0;
            this.pictureBoxDocks.TabStop = false;
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
            // labelCompareText
            // 
            this.labelCompareText.AutoSize = true;
            this.labelCompareText.Location = new System.Drawing.Point(661, 178);
            this.labelCompareText.Name = "labelCompareText";
            this.labelCompareText.Size = new System.Drawing.Size(0, 13);
            this.labelCompareText.TabIndex = 11;
            // 
            // listBoxLevel
            // 
            this.listBoxLevel.FormattingEnabled = true;
            this.listBoxLevel.Location = new System.Drawing.Point(664, 316);
            this.listBoxLevel.Name = "listBoxLevel";
            this.listBoxLevel.Size = new System.Drawing.Size(107, 82);
            this.listBoxLevel.TabIndex = 12;
            this.listBoxLevel.SelectedIndexChanged += new System.EventHandler(this.listBoxLevel_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(661, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 73);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Припарковать";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormDocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 410);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBoxLevel);
            this.Controls.Add(this.labelCompareText);
            this.Controls.Add(this.pictureBoxSelectedWarship);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.mtbPlace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxDocks);
            this.Name = "FormDocks";
            this.Text = "FormDocks";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedWarship)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDocks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbPlace;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.PictureBox pictureBoxSelectedWarship;
        private System.Windows.Forms.Label labelCompareText;
        private System.Windows.Forms.ListBox listBoxLevel;
        private System.Windows.Forms.Button btnAdd;
    }
}