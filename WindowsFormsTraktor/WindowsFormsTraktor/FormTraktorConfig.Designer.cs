namespace WindowsFormsTraktor
{
    partial class FormTraktorConfig
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
            this.pictureBoxTraktor = new System.Windows.Forms.PictureBox();
            this.groupBoxTransportSelection = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelTraktorExcavator = new System.Windows.Forms.Label();
            this.labelTraktor = new System.Windows.Forms.Label();
            this.panelForPictureBox = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelPink = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.groupBoxColorSelection = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTraktor)).BeginInit();
            this.groupBoxTransportSelection.SuspendLayout();
            this.panelForPictureBox.SuspendLayout();
            this.groupBoxColorSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxTraktor
            // 
            this.pictureBoxTraktor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxTraktor.Location = new System.Drawing.Point(22, 3);
            this.pictureBoxTraktor.Name = "pictureBoxTraktor";
            this.pictureBoxTraktor.Size = new System.Drawing.Size(110, 70);
            this.pictureBoxTraktor.TabIndex = 0;
            this.pictureBoxTraktor.TabStop = false;
            // 
            // groupBoxTransportSelection
            // 
            this.groupBoxTransportSelection.Controls.Add(this.buttonAdd);
            this.groupBoxTransportSelection.Controls.Add(this.buttonCancel);
            this.groupBoxTransportSelection.Controls.Add(this.labelTraktorExcavator);
            this.groupBoxTransportSelection.Controls.Add(this.labelTraktor);
            this.groupBoxTransportSelection.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTransportSelection.Name = "groupBoxTransportSelection";
            this.groupBoxTransportSelection.Size = new System.Drawing.Size(188, 218);
            this.groupBoxTransportSelection.TabIndex = 1;
            this.groupBoxTransportSelection.TabStop = false;
            this.groupBoxTransportSelection.Text = "Тип техники";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(69, 136);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(103, 30);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(69, 172);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(103, 29);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelTraktorExcavator
            // 
            this.labelTraktorExcavator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTraktorExcavator.Location = new System.Drawing.Point(6, 89);
            this.labelTraktorExcavator.Name = "labelTraktorExcavator";
            this.labelTraktorExcavator.Size = new System.Drawing.Size(166, 23);
            this.labelTraktorExcavator.TabIndex = 1;
            this.labelTraktorExcavator.Text = "Трактор-экскаватор";
            this.labelTraktorExcavator.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTraktorExcavator_MouseDown);
            // 
            // labelTraktor
            // 
            this.labelTraktor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTraktor.Location = new System.Drawing.Point(6, 42);
            this.labelTraktor.Name = "labelTraktor";
            this.labelTraktor.Size = new System.Drawing.Size(166, 23);
            this.labelTraktor.TabIndex = 0;
            this.labelTraktor.Text = "Трактор";
            this.labelTraktor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTraktor_MouseDown);
            // 
            // panelForPictureBox
            // 
            this.panelForPictureBox.AllowDrop = true;
            this.panelForPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForPictureBox.Controls.Add(this.labelDopColor);
            this.panelForPictureBox.Controls.Add(this.labelMainColor);
            this.panelForPictureBox.Controls.Add(this.pictureBoxTraktor);
            this.panelForPictureBox.Location = new System.Drawing.Point(206, 12);
            this.panelForPictureBox.Name = "panelForPictureBox";
            this.panelForPictureBox.Size = new System.Drawing.Size(154, 181);
            this.panelForPictureBox.TabIndex = 2;
            this.panelForPictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelForPictureBox_DragDrop);
            this.panelForPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelForPictureBox_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(21, 135);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(110, 30);
            this.labelDopColor.TabIndex = 2;
            this.labelDopColor.Text = "Дополнительный цвет";
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(21, 87);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(110, 30);
            this.labelMainColor.TabIndex = 1;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // panelBlack
            // 
            this.panelBlack.AllowDrop = true;
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(28, 32);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(30, 30);
            this.panelBlack.TabIndex = 3;
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelPink
            // 
            this.panelPink.AllowDrop = true;
            this.panelPink.BackColor = System.Drawing.Color.Fuchsia;
            this.panelPink.Location = new System.Drawing.Point(64, 32);
            this.panelPink.Name = "panelPink";
            this.panelPink.Size = new System.Drawing.Size(30, 30);
            this.panelPink.TabIndex = 4;
            this.panelPink.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.AllowDrop = true;
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(64, 67);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(30, 30);
            this.panelBlue.TabIndex = 6;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGreen
            // 
            this.panelGreen.AllowDrop = true;
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.Location = new System.Drawing.Point(28, 67);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(30, 30);
            this.panelGreen.TabIndex = 5;
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelOrange
            // 
            this.panelOrange.AllowDrop = true;
            this.panelOrange.BackColor = System.Drawing.Color.Orange;
            this.panelOrange.Location = new System.Drawing.Point(64, 138);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(30, 30);
            this.panelOrange.TabIndex = 10;
            this.panelOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.AllowDrop = true;
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(64, 103);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(30, 30);
            this.panelYellow.TabIndex = 8;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGray
            // 
            this.panelGray.AllowDrop = true;
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.Location = new System.Drawing.Point(28, 138);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(30, 30);
            this.panelGray.TabIndex = 9;
            this.panelGray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.AllowDrop = true;
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(28, 103);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(30, 30);
            this.panelRed.TabIndex = 7;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // groupBoxColorSelection
            // 
            this.groupBoxColorSelection.Controls.Add(this.panelOrange);
            this.groupBoxColorSelection.Controls.Add(this.panelBlue);
            this.groupBoxColorSelection.Controls.Add(this.panelYellow);
            this.groupBoxColorSelection.Controls.Add(this.panelPink);
            this.groupBoxColorSelection.Controls.Add(this.panelGray);
            this.groupBoxColorSelection.Controls.Add(this.panelGreen);
            this.groupBoxColorSelection.Controls.Add(this.panelRed);
            this.groupBoxColorSelection.Controls.Add(this.panelBlack);
            this.groupBoxColorSelection.Location = new System.Drawing.Point(366, 12);
            this.groupBoxColorSelection.Name = "groupBoxColorSelection";
            this.groupBoxColorSelection.Size = new System.Drawing.Size(118, 200);
            this.groupBoxColorSelection.TabIndex = 11;
            this.groupBoxColorSelection.TabStop = false;
            this.groupBoxColorSelection.Text = "Выбор цвета";
            // 
            // FormTraktorConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 245);
            this.Controls.Add(this.groupBoxColorSelection);
            this.Controls.Add(this.panelForPictureBox);
            this.Controls.Add(this.groupBoxTransportSelection);
            this.Name = "FormTraktorConfig";
            this.Text = "Выбор техники";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTraktor)).EndInit();
            this.groupBoxTransportSelection.ResumeLayout(false);
            this.panelForPictureBox.ResumeLayout(false);
            this.groupBoxColorSelection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTraktor;
        private System.Windows.Forms.GroupBox groupBoxTransportSelection;
        private System.Windows.Forms.Label labelTraktorExcavator;
        private System.Windows.Forms.Label labelTraktor;
        private System.Windows.Forms.Panel panelForPictureBox;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelPink;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.GroupBox groupBoxColorSelection;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
    }
}