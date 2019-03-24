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
            this.btnParkTraktor = new System.Windows.Forms.Button();
            this.btnParkTraktorExcavator = new System.Windows.Forms.Button();
            this.groupBoxTraktorPickup = new System.Windows.Forms.GroupBox();
            this.pictureBoxTakenTransport = new System.Windows.Forms.PictureBox();
            this.btnPickupTraktor = new System.Windows.Forms.Button();
            this.maskedTextBoxPlaceNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxTraktorPickup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakenTransport)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(713, 462);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // btnParkTraktor
            // 
            this.btnParkTraktor.Location = new System.Drawing.Point(722, 36);
            this.btnParkTraktor.Name = "btnParkTraktor";
            this.btnParkTraktor.Size = new System.Drawing.Size(151, 48);
            this.btnParkTraktor.TabIndex = 1;
            this.btnParkTraktor.Text = "Припарковать трактор";
            this.btnParkTraktor.UseVisualStyleBackColor = true;
            this.btnParkTraktor.Click += new System.EventHandler(this.ParkTraktor);
            // 
            // btnParkTraktorExcavator
            // 
            this.btnParkTraktorExcavator.Location = new System.Drawing.Point(722, 90);
            this.btnParkTraktorExcavator.Name = "btnParkTraktorExcavator";
            this.btnParkTraktorExcavator.Size = new System.Drawing.Size(151, 48);
            this.btnParkTraktorExcavator.TabIndex = 2;
            this.btnParkTraktorExcavator.Text = "Припарковать трактор-экскаватор";
            this.btnParkTraktorExcavator.UseVisualStyleBackColor = true;
            this.btnParkTraktorExcavator.Click += new System.EventHandler(this.ParkTraktorExcavator);
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
            // FormTraktorParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.groupBoxTraktorPickup);
            this.Controls.Add(this.btnParkTraktorExcavator);
            this.Controls.Add(this.btnParkTraktor);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormTraktorParking";
            this.Text = "Стоянка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxTraktorPickup.ResumeLayout(false);
            this.groupBoxTraktorPickup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakenTransport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button btnParkTraktor;
        private System.Windows.Forms.Button btnParkTraktorExcavator;
        private System.Windows.Forms.GroupBox groupBoxTraktorPickup;
        private System.Windows.Forms.PictureBox pictureBoxTakenTransport;
        private System.Windows.Forms.Button btnPickupTraktor;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlaceNumber;
        private System.Windows.Forms.Label labelPlace;
    }
}