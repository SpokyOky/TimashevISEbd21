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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCompareLess = new System.Windows.Forms.Button();
            this.labelCompareText = new System.Windows.Forms.Label();
            this.listBoxLevel = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLanding = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВсёToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьЛевелToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьВсёToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьЛевелToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveLevelFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openLevelFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxDocks
            // 
            this.pictureBoxDocks.Location = new System.Drawing.Point(12, 35);
            this.pictureBoxDocks.Name = "pictureBoxDocks";
            this.pictureBoxDocks.Size = new System.Drawing.Size(642, 385);
            this.pictureBoxDocks.TabIndex = 0;
            this.pictureBoxDocks.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(660, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Место";
            // 
            // mtbPlace
            // 
            this.mtbPlace.Location = new System.Drawing.Point(705, 227);
            this.mtbPlace.Mask = "0";
            this.mtbPlace.Name = "mtbPlace";
            this.mtbPlace.Size = new System.Drawing.Size(13, 20);
            this.mtbPlace.TabIndex = 5;
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(660, 253);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(127, 33);
            this.btnTake.TabIndex = 6;
            this.btnTake.Text = "Забрать корабль";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(663, 292);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 40);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnCompareLess
            // 
            this.btnCompareLess.Location = new System.Drawing.Point(660, 152);
            this.btnCompareLess.Name = "btnCompareLess";
            this.btnCompareLess.Size = new System.Drawing.Size(127, 45);
            this.btnCompareLess.TabIndex = 9;
            this.btnCompareLess.Text = "Сравнить свободные места";
            this.btnCompareLess.UseVisualStyleBackColor = true;
            this.btnCompareLess.Click += new System.EventHandler(this.btnCompareLess_Click);
            // 
            // labelCompareText
            // 
            this.labelCompareText.AutoSize = true;
            this.labelCompareText.Location = new System.Drawing.Point(660, 200);
            this.labelCompareText.Name = "labelCompareText";
            this.labelCompareText.Size = new System.Drawing.Size(0, 13);
            this.labelCompareText.TabIndex = 11;
            // 
            // listBoxLevel
            // 
            this.listBoxLevel.FormattingEnabled = true;
            this.listBoxLevel.Location = new System.Drawing.Point(663, 338);
            this.listBoxLevel.Name = "listBoxLevel";
            this.listBoxLevel.Size = new System.Drawing.Size(107, 82);
            this.listBoxLevel.TabIndex = 12;
            this.listBoxLevel.SelectedIndexChanged += new System.EventHandler(this.listBoxLevel_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(660, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 73);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Припарковать";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLanding
            // 
            this.btnLanding.Location = new System.Drawing.Point(660, 113);
            this.btnLanding.Name = "btnLanding";
            this.btnLanding.Size = new System.Drawing.Size(127, 33);
            this.btnLanding.TabIndex = 8;
            this.btnLanding.Text = "Посадить самолёты";
            this.btnLanding.UseVisualStyleBackColor = true;
            this.btnLanding.Click += new System.EventHandler(this.btnLanding_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьВсёToolStripMenuItem,
            this.сохранитьЛевелToolStripMenuItem});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // сохранитьВсёToolStripMenuItem
            // 
            this.сохранитьВсёToolStripMenuItem.Name = "сохранитьВсёToolStripMenuItem";
            this.сохранитьВсёToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьВсёToolStripMenuItem.Text = "Сохранить всё";
            this.сохранитьВсёToolStripMenuItem.Click += new System.EventHandler(this.сохранитьВсёToolStripMenuItem_Click);
            // 
            // сохранитьЛевелToolStripMenuItem
            // 
            this.сохранитьЛевелToolStripMenuItem.Name = "сохранитьЛевелToolStripMenuItem";
            this.сохранитьЛевелToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьЛевелToolStripMenuItem.Text = "Сохранить левел";
            this.сохранитьЛевелToolStripMenuItem.Click += new System.EventHandler(this.сохранитьЛевелToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьВсёToolStripMenuItem,
            this.загрузитьЛевелToolStripMenuItem});
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            // 
            // загрузитьВсёToolStripMenuItem
            // 
            this.загрузитьВсёToolStripMenuItem.Name = "загрузитьВсёToolStripMenuItem";
            this.загрузитьВсёToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.загрузитьВсёToolStripMenuItem.Text = "Загрузить всё";
            this.загрузитьВсёToolStripMenuItem.Click += new System.EventHandler(this.загрузитьВсёToolStripMenuItem_Click);
            // 
            // загрузитьЛевелToolStripMenuItem
            // 
            this.загрузитьЛевелToolStripMenuItem.Name = "загрузитьЛевелToolStripMenuItem";
            this.загрузитьЛевелToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.загрузитьЛевелToolStripMenuItem.Text = "Загрузить левел";
            this.загрузитьЛевелToolStripMenuItem.Click += new System.EventHandler(this.загрузитьЛевелToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "txt file | *.txt";
            this.openFileDialog.RestoreDirectory = true;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // openLevelFileDialog
            // 
            this.openLevelFileDialog.FileName = "openFileDialog1";
            // 
            // FormDocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 432);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBoxLevel);
            this.Controls.Add(this.labelCompareText);
            this.Controls.Add(this.btnCompareLess);
            this.Controls.Add(this.btnLanding);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.mtbPlace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxDocks);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormDocks";
            this.Text = "FormDocks";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDocks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbPlace;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCompareLess;
        private System.Windows.Forms.Label labelCompareText;
        private System.Windows.Forms.ListBox listBoxLevel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLanding;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВсёToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьЛевелToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьВсёToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьЛевелToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveLevelFileDialog;
        private System.Windows.Forms.OpenFileDialog openLevelFileDialog;
    }
}