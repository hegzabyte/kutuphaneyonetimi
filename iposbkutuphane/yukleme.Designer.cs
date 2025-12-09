namespace iposbkutuphane
{
    partial class yukleme
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yukleme));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelArka = new System.Windows.Forms.Panel();
            this.panelYukle = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelArka.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(65, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelArka
            // 
            this.panelArka.BackColor = System.Drawing.Color.White;
            this.panelArka.Controls.Add(this.panelYukle);
            this.panelArka.Controls.Add(this.pictureBox1);
            this.panelArka.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelArka.Location = new System.Drawing.Point(0, 0);
            this.panelArka.Name = "panelArka";
            this.panelArka.Size = new System.Drawing.Size(353, 407);
            this.panelArka.TabIndex = 1;
            // 
            // panelYukle
            // 
            this.panelYukle.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelYukle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelYukle.Location = new System.Drawing.Point(0, 369);
            this.panelYukle.Name = "panelYukle";
            this.panelYukle.Size = new System.Drawing.Size(353, 38);
            this.panelYukle.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // yukleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 407);
            this.Controls.Add(this.panelArka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "yukleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IPOSB MTAL Kütüphane";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelArka.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelArka;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelYukle;
    }
}