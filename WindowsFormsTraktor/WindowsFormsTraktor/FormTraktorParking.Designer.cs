namespace WindowsFormsTraktor
{
    partial class FormTraktorParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.groupBoxTraktorPickup = new System.Windows.Forms.GroupBox();
            this.pictureBoxTakenTransport = new System.Windows.Forms.PictureBox();
            this.btnPickupTraktor = new System.Windows.Forms.Button();
            this.maskedTextBoxPlaceNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.listBoxParkingLevels = new System.Windows.Forms.ListBox();
            this.buttonAddTransport = new System.Windows.Forms.Button();
            this.menuStripWorkingWithParkingLevels = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxTraktorPickup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakenTransport)).BeginInit();
            this.menuStripWorkingWithParkingLevels.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 24);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(712, 438);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // groupBoxTraktorPickup
            // 
            this.groupBoxTraktorPickup.Controls.Add(this.pictureBoxTakenTransport);
            this.groupBoxTraktorPickup.Controls.Add(this.btnPickupTraktor);
            this.groupBoxTraktorPickup.Controls.Add(this.maskedTextBoxPlaceNumber);
            this.groupBoxTraktorPickup.Controls.Add(this.labelPlace);
            this.groupBoxTraktorPickup.Location = new System.Drawing.Point(719, 255);
            this.groupBoxTraktorPickup.Name = "groupBoxTraktorPickup";
            this.groupBoxTraktorPickup.Size = new System.Drawing.Size(154, 195);
            this.groupBoxTraktorPickup.TabIndex = 3;
            this.groupBoxTraktorPickup.TabStop = false;
            this.groupBoxTraktorPickup.Text = "Забрать технику";
            // 
            // pictureBoxTakenTransport
            // 
            this.pictureBoxTakenTransport.Location = new System.Drawing.Point(28, 97);
            this.pictureBoxTakenTransport.Name = "pictureBoxTakenTransport";
            this.pictureBoxTakenTransport.Size = new System.Drawing.Size(110, 70);
            this.pictureBoxTakenTransport.TabIndex = 3;
            this.pictureBoxTakenTransport.TabStop = false;
            // 
            // btnPickupTraktor
            // 
            this.btnPickupTraktor.Location = new System.Drawing.Point(33, 68);
            this.btnPickupTraktor.Name = "btnPickupTraktor";
            this.btnPickupTraktor.Size = new System.Drawing.Size(75, 23);
            this.btnPickupTraktor.TabIndex = 2;
            this.btnPickupTraktor.Text = "Забрать";
            this.btnPickupTraktor.UseVisualStyleBackColor = true;
            this.btnPickupTraktor.Click += new System.EventHandler(this.TakeTraktor);
            // 
            // maskedTextBoxPlaceNumber
            // 
            this.maskedTextBoxPlaceNumber.Location = new System.Drawing.Point(51, 42);
            this.maskedTextBoxPlaceNumber.Mask = "00";
            this.maskedTextBoxPlaceNumber.Name = "maskedTextBoxPlaceNumber";
            this.maskedTextBoxPlaceNumber.Size = new System.Drawing.Size(87, 20);
            this.maskedTextBoxPlaceNumber.TabIndex = 1;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(6, 45);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(39, 13);
            this.labelPlace.TabIndex = 0;
            this.labelPlace.Text = "Место";
            // 
            // listBoxParkingLevels
            // 
            this.listBoxParkingLevels.FormattingEnabled = true;
            this.listBoxParkingLevels.Location = new System.Drawing.Point(719, 64);
            this.listBoxParkingLevels.Name = "listBoxParkingLevels";
            this.listBoxParkingLevels.Size = new System.Drawing.Size(150, 121);
            this.listBoxParkingLevels.TabIndex = 4;
            this.listBoxParkingLevels.SelectedIndexChanged += new System.EventHandler(this.listBoxParkingLevels_SelectedIndexChanged);
            // 
            // buttonAddTransport
            // 
            this.buttonAddTransport.Location = new System.Drawing.Point(722, 191);
            this.buttonAddTransport.Name = "buttonAddTransport";
            this.buttonAddTransport.Size = new System.Drawing.Size(149, 31);
            this.buttonAddTransport.TabIndex = 5;
            this.buttonAddTransport.Text = "Добавить технику";
            this.buttonAddTransport.UseVisualStyleBackColor = true;
            this.buttonAddTransport.Click += new System.EventHandler(this.buttonAddTransport_Click);
            // 
            // menuStripWorkingWithParkingLevels
            // 
            this.menuStripWorkingWithParkingLevels.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStripWorkingWithParkingLevels.Location = new System.Drawing.Point(0, 0);
            this.menuStripWorkingWithParkingLevels.Name = "menuStripWorkingWithParkingLevels";
            this.menuStripWorkingWithParkingLevels.Size = new System.Drawing.Size(884, 24);
            this.menuStripWorkingWithParkingLevels.TabIndex = 6;
            this.menuStripWorkingWithParkingLevels.Text = "menuStrip1";
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
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // FormTraktorParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.buttonAddTransport);
            this.Controls.Add(this.listBoxParkingLevels);
            this.Controls.Add(this.groupBoxTraktorPickup);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.menuStripWorkingWithParkingLevels);
            this.MainMenuStrip = this.menuStripWorkingWithParkingLevels;
            this.Name = "FormTraktorParking";
            this.Text = "Стоянка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxTraktorPickup.ResumeLayout(false);
            this.groupBoxTraktorPickup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakenTransport)).EndInit();
            this.menuStripWorkingWithParkingLevels.ResumeLayout(false);
            this.menuStripWorkingWithParkingLevels.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.GroupBox groupBoxTraktorPickup;
        private System.Windows.Forms.PictureBox pictureBoxTakenTransport;
        private System.Windows.Forms.Button btnPickupTraktor;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlaceNumber;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.ListBox listBoxParkingLevels;
        private System.Windows.Forms.Button buttonAddTransport;
        private System.Windows.Forms.MenuStrip menuStripWorkingWithParkingLevels;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}