namespace WindowsFormsTraktor
{
    partial class FormTraktor
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTraktor));
            this.pictureBoxTraktor = new System.Windows.Forms.PictureBox();
            this.buttonCreateTraktor = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.buttonCreateTraktorExcavator = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTraktor)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTraktor
            // 
            this.pictureBoxTraktor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTraktor.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTraktor.Name = "pictureBoxTraktor";
            this.pictureBoxTraktor.Size = new System.Drawing.Size(884, 462);
            this.pictureBoxTraktor.TabIndex = 0;
            this.pictureBoxTraktor.TabStop = false;
            // 
            // buttonCreateTraktor
            // 
            this.buttonCreateTraktor.Location = new System.Drawing.Point(710, 12);
            this.buttonCreateTraktor.Name = "buttonCreateTraktor";
            this.buttonCreateTraktor.Size = new System.Drawing.Size(162, 31);
            this.buttonCreateTraktor.TabIndex = 1;
            this.buttonCreateTraktor.Text = "Создать трактор";
            this.buttonCreateTraktor.UseVisualStyleBackColor = true;
            this.buttonCreateTraktor.Click += new System.EventHandler(this.CreateTraktor);
            // 
            // btn_right
            // 
            this.btn_right.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_right.BackgroundImage")));
            this.btn_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_right.Location = new System.Drawing.Point(842, 420);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(30, 30);
            this.btn_right.TabIndex = 2;
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.MoveTraktor);
            // 
            // btn_up
            // 
            this.btn_up.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_up.BackgroundImage")));
            this.btn_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_up.Location = new System.Drawing.Point(806, 384);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(30, 30);
            this.btn_up.TabIndex = 3;
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.MoveTraktor);
            // 
            // btn_left
            // 
            this.btn_left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_left.BackgroundImage")));
            this.btn_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_left.Location = new System.Drawing.Point(770, 420);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(30, 30);
            this.btn_left.TabIndex = 4;
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.MoveTraktor);
            // 
            // btn_down
            // 
            this.btn_down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_down.BackgroundImage")));
            this.btn_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_down.Location = new System.Drawing.Point(806, 420);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(30, 30);
            this.btn_down.TabIndex = 5;
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.MoveTraktor);
            // 
            // buttonCreateTraktorExcavator
            // 
            this.buttonCreateTraktorExcavator.Location = new System.Drawing.Point(710, 49);
            this.buttonCreateTraktorExcavator.Name = "buttonCreateTraktorExcavator";
            this.buttonCreateTraktorExcavator.Size = new System.Drawing.Size(162, 31);
            this.buttonCreateTraktorExcavator.TabIndex = 6;
            this.buttonCreateTraktorExcavator.Text = "Создать экскаватор";
            this.buttonCreateTraktorExcavator.UseVisualStyleBackColor = true;
            this.buttonCreateTraktorExcavator.Click += new System.EventHandler(this.CreateExcavator);
            // 
            // FormTraktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.buttonCreateTraktorExcavator);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.buttonCreateTraktor);
            this.Controls.Add(this.pictureBoxTraktor);
            this.Name = "FormTraktor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Трактор";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTraktor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTraktor;
        private System.Windows.Forms.Button buttonCreateTraktor;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button buttonCreateTraktorExcavator;
    }
}

