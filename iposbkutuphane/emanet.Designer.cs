namespace KutuphaneSistemi
{
    partial class emanet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboOgrenci = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboKitap = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dateVerilis = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateTeslim = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIslemYap = new Guna.UI2.WinForms.Guna2Button();
            this.gridEmanetler = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnTemizle = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmanetler)).BeginInit();
            this.SuspendLayout();
            // 
            // comboOgrenci
            // 
            this.comboOgrenci.BackColor = System.Drawing.Color.Transparent;
            this.comboOgrenci.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboOgrenci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOgrenci.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboOgrenci.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboOgrenci.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboOgrenci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboOgrenci.ItemHeight = 30;
            this.comboOgrenci.Location = new System.Drawing.Point(12, 127);
            this.comboOgrenci.Name = "comboOgrenci";
            this.comboOgrenci.Size = new System.Drawing.Size(341, 36);
            this.comboOgrenci.TabIndex = 3;
            // 
            // comboKitap
            // 
            this.comboKitap.BackColor = System.Drawing.Color.Transparent;
            this.comboKitap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboKitap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboKitap.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboKitap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboKitap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboKitap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboKitap.ItemHeight = 30;
            this.comboKitap.Location = new System.Drawing.Point(12, 186);
            this.comboKitap.Name = "comboKitap";
            this.comboKitap.Size = new System.Drawing.Size(341, 36);
            this.comboKitap.TabIndex = 4;
            // 
            // dateVerilis
            // 
            this.dateVerilis.Checked = true;
            this.dateVerilis.FillColor = System.Drawing.Color.White;
            this.dateVerilis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateVerilis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.dateVerilis.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateVerilis.Location = new System.Drawing.Point(12, 245);
            this.dateVerilis.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateVerilis.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateVerilis.Name = "dateVerilis";
            this.dateVerilis.Size = new System.Drawing.Size(341, 36);
            this.dateVerilis.TabIndex = 5;
            this.dateVerilis.Value = new System.DateTime(2025, 12, 7, 15, 28, 43, 122);
            // 
            // dateTeslim
            // 
            this.dateTeslim.Checked = true;
            this.dateTeslim.FillColor = System.Drawing.Color.White;
            this.dateTeslim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTeslim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.dateTeslim.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTeslim.Location = new System.Drawing.Point(12, 304);
            this.dateTeslim.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTeslim.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTeslim.Name = "dateTeslim";
            this.dateTeslim.Size = new System.Drawing.Size(341, 36);
            this.dateTeslim.TabIndex = 6;
            this.dateTeslim.Value = new System.DateTime(2025, 12, 7, 15, 28, 43, 122);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(9, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kayıtlı Öğrenci :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(9, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kayıtlı Kitap :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kitabın Veriliş Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kitabın Teslim Tarihi :";
            // 
            // btnIslemYap
            // 
            this.btnIslemYap.BorderRadius = 15;
            this.btnIslemYap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIslemYap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIslemYap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIslemYap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIslemYap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.btnIslemYap.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnIslemYap.ForeColor = System.Drawing.Color.White;
            this.btnIslemYap.Location = new System.Drawing.Point(92, 346);
            this.btnIslemYap.Name = "btnIslemYap";
            this.btnIslemYap.Size = new System.Drawing.Size(155, 45);
            this.btnIslemYap.TabIndex = 11;
            this.btnIslemYap.Text = "İşlemi Tamamla";
            this.btnIslemYap.Click += new System.EventHandler(this.btnIslemYap_Click);
            // 
            // gridEmanetler
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridEmanetler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridEmanetler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEmanetler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridEmanetler.ColumnHeadersHeight = 4;
            this.gridEmanetler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridEmanetler.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridEmanetler.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridEmanetler.Location = new System.Drawing.Point(362, 27);
            this.gridEmanetler.Name = "gridEmanetler";
            this.gridEmanetler.ReadOnly = true;
            this.gridEmanetler.RowHeadersVisible = false;
            this.gridEmanetler.Size = new System.Drawing.Size(564, 494);
            this.gridEmanetler.TabIndex = 12;
            this.gridEmanetler.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridEmanetler.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridEmanetler.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridEmanetler.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridEmanetler.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridEmanetler.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.gridEmanetler.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridEmanetler.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridEmanetler.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridEmanetler.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridEmanetler.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridEmanetler.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridEmanetler.ThemeStyle.HeaderStyle.Height = 4;
            this.gridEmanetler.ThemeStyle.ReadOnly = true;
            this.gridEmanetler.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridEmanetler.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridEmanetler.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridEmanetler.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridEmanetler.ThemeStyle.RowsStyle.Height = 22;
            this.gridEmanetler.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridEmanetler.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridEmanetler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEmanetler_CellClick);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BorderRadius = 15;
            this.btnTemizle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTemizle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTemizle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTemizle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTemizle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTemizle.Location = new System.Drawing.Point(109, 397);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(121, 29);
            this.btnTemizle.TabIndex = 13;
            this.btnTemizle.Text = "İptal Et";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // emanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(930, 533);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.gridEmanetler);
            this.Controls.Add(this.btnIslemYap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTeslim);
            this.Controls.Add(this.dateVerilis);
            this.Controls.Add(this.comboKitap);
            this.Controls.Add(this.comboOgrenci);
            this.Name = "emanet";
            this.Text = "emanet";
            this.Load += new System.EventHandler(this.EmanetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmanetler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox comboOgrenci;
        private Guna.UI2.WinForms.Guna2ComboBox comboKitap;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateVerilis;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTeslim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnIslemYap;
        private Guna.UI2.WinForms.Guna2DataGridView gridEmanetler;
        private Guna.UI2.WinForms.Guna2Button btnTemizle;
    }
}