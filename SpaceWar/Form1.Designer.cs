namespace SpaceWar
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxMyShip = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnemy = new System.Windows.Forms.PictureBox();
            this.timerEnemy = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMyShip
            // 
            this.pictureBoxMyShip.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMyShip.Image")));
            this.pictureBoxMyShip.Location = new System.Drawing.Point(245, 306);
            this.pictureBoxMyShip.Name = "pictureBoxMyShip";
            this.pictureBoxMyShip.Size = new System.Drawing.Size(91, 108);
            this.pictureBoxMyShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMyShip.TabIndex = 0;
            this.pictureBoxMyShip.TabStop = false;
            // 
            // pictureBoxEnemy
            // 
            this.pictureBoxEnemy.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEnemy.Image")));
            this.pictureBoxEnemy.Location = new System.Drawing.Point(194, 12);
            this.pictureBoxEnemy.Name = "pictureBoxEnemy";
            this.pictureBoxEnemy.Size = new System.Drawing.Size(91, 108);
            this.pictureBoxEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEnemy.TabIndex = 1;
            this.pictureBoxEnemy.TabStop = false;
            // 
            // timerEnemy
            // 
            this.timerEnemy.Enabled = true;
            this.timerEnemy.Interval = 10;
            this.timerEnemy.Tick += new System.EventHandler(this.timerEnemy_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxEnemy);
            this.Controls.Add(this.pictureBoxMyShip);
            this.Name = "Form1";
            this.Text = "Космические войны";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMyShip;
        private System.Windows.Forms.PictureBox pictureBoxEnemy;
        private System.Windows.Forms.Timer timerEnemy;
    }
}

