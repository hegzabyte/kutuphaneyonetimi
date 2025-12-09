using System.Windows.Forms;

namespace iposbkutuphane
{
    partial class kitaplık
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitaplık));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAra = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDuzenle = new Guna.UI2.WinForms.Guna2Button();
            this.btnSil = new Guna.UI2.WinForms.Guna2Button();
            this.btnEkle = new Guna.UI2.WinForms.Guna2Button();
            this.dgvListe = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlKayit = new Guna.UI2.WinForms.Guna2Panel();
            this.btnKaydet = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numStok = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnWebdenBul = new Guna.UI2.WinForms.Guna2Button();
            this.pbResim = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dtpTarih = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.numSayfa = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtYayinevi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtYazar = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAd = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.pnlKayit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSayfa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.txtAra);
            this.panel1.Controls.Add(this.btnDuzenle);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnEkle);
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 471);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 62);
            this.panel1.TabIndex = 0;
            // 
            // txtAra
            // 
            this.txtAra.BorderRadius = 20;
            this.txtAra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txtAra, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtAra.DefaultText = "";
            this.txtAra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAra.IconRight = global::iposbkutuphane.Properties.Resources.search24;
            this.txtAra.Location = new System.Drawing.Point(583, 14);
            this.txtAra.Name = "txtAra";
            this.txtAra.PlaceholderText = "Kitap Veya Yazar Arat...";
            this.txtAra.SelectedText = "";
            this.txtAra.Size = new System.Drawing.Size(307, 36);
            this.txtAra.TabIndex = 6;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.BorderRadius = 15;
            this.guna2Transition1.SetDecoration(this.btnDuzenle, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnDuzenle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDuzenle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDuzenle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDuzenle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDuzenle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnDuzenle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.ForeColor = System.Drawing.Color.White;
            this.btnDuzenle.Image = global::iposbkutuphane.Properties.Resources.duzenle3;
            this.btnDuzenle.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDuzenle.Location = new System.Drawing.Point(192, 9);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(180, 45);
            this.btnDuzenle.TabIndex = 5;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BorderRadius = 15;
            this.guna2Transition1.SetDecoration(this.btnSil, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSil.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSil.Location = new System.Drawing.Point(378, 9);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(180, 45);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BorderRadius = 15;
            this.guna2Transition1.SetDecoration(this.btnEkle, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnEkle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEkle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEkle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEkle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEkle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Image = global::iposbkutuphane.Properties.Resources.ekle2;
            this.btnEkle.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEkle.Location = new System.Drawing.Point(6, 9);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(180, 45);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dgvListe
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvListe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListe.ColumnHeadersHeight = 4;
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2Transition1.SetDecoration(this.dgvListe, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListe.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListe.Location = new System.Drawing.Point(0, 0);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.RowHeadersVisible = false;
            this.dgvListe.Size = new System.Drawing.Size(1031, 471);
            this.dgvListe.TabIndex = 1;
            this.dgvListe.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListe.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListe.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListe.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListe.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListe.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListe.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListe.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvListe.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListe.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvListe.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListe.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListe.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvListe.ThemeStyle.ReadOnly = false;
            this.dgvListe.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListe.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListe.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvListe.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListe.ThemeStyle.RowsStyle.Height = 22;
            this.dgvListe.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListe.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvListe.MultiSelect = false;
            this.dgvListe.ReadOnly = true;
            this.dgvListe.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;


            // 
            // pnlKayit
            // 
            this.pnlKayit.BorderRadius = 16;
            this.pnlKayit.Controls.Add(this.btnKaydet);
            this.pnlKayit.Controls.Add(this.label2);
            this.pnlKayit.Controls.Add(this.label3);
            this.pnlKayit.Controls.Add(this.label1);
            this.pnlKayit.Controls.Add(this.numStok);
            this.pnlKayit.Controls.Add(this.btnWebdenBul);
            this.pnlKayit.Controls.Add(this.pbResim);
            this.pnlKayit.Controls.Add(this.dtpTarih);
            this.pnlKayit.Controls.Add(this.numSayfa);
            this.pnlKayit.Controls.Add(this.txtYayinevi);
            this.pnlKayit.Controls.Add(this.txtYazar);
            this.pnlKayit.Controls.Add(this.txtAd);
            this.guna2Transition1.SetDecoration(this.pnlKayit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlKayit.Location = new System.Drawing.Point(654, -5);
            this.pnlKayit.Name = "pnlKayit";
            this.pnlKayit.Size = new System.Drawing.Size(279, 479);
            this.pnlKayit.TabIndex = 2;
            this.pnlKayit.Visible = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BorderRadius = 10;
            this.guna2Transition1.SetDecoration(this.btnKaydet, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnKaydet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKaydet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKaydet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKaydet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKaydet.FillColor = System.Drawing.Color.DarkOrange;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(51, 390);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(185, 34);
            this.btnKaydet.TabIndex = 26;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Inter", 8.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(152, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Adet Sayısı : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(19, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Eklenme Tarihi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Inter", 8.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(21, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Sayfa Sayısı :";
            // 
            // numStok
            // 
            this.numStok.BackColor = System.Drawing.Color.Transparent;
            this.numStok.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.numStok, Guna.UI2.AnimatorNS.DecorationType.None);
            this.numStok.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numStok.Location = new System.Drawing.Point(152, 319);
            this.numStok.Name = "numStok";
            this.numStok.Size = new System.Drawing.Size(112, 24);
            this.numStok.TabIndex = 22;
            // 
            // btnWebdenBul
            // 
            this.btnWebdenBul.BorderRadius = 10;
            this.guna2Transition1.SetDecoration(this.btnWebdenBul, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnWebdenBul.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWebdenBul.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWebdenBul.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWebdenBul.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWebdenBul.Font = new System.Drawing.Font("Inter", 8.25F);
            this.btnWebdenBul.ForeColor = System.Drawing.Color.White;
            this.btnWebdenBul.Location = new System.Drawing.Point(51, 431);
            this.btnWebdenBul.Name = "btnWebdenBul";
            this.btnWebdenBul.Size = new System.Drawing.Size(185, 29);
            this.btnWebdenBul.TabIndex = 21;
            this.btnWebdenBul.Text = "Web\'den Bul 🔍";
            this.btnWebdenBul.Click += new System.EventHandler(this.btnWebdenBul_Click);
            // 
            // pbResim
            // 
            this.guna2Transition1.SetDecoration(this.pbResim, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pbResim.ImageRotate = 0F;
            this.pbResim.Location = new System.Drawing.Point(35, 12);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(208, 156);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbResim.TabIndex = 20;
            this.pbResim.TabStop = false;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Checked = true;
            this.guna2Transition1.SetDecoration(this.dtpTarih, Guna.UI2.AnimatorNS.DecorationType.None);
            this.dtpTarih.FillColor = System.Drawing.Color.White;
            this.dtpTarih.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpTarih.Location = new System.Drawing.Point(22, 362);
            this.dtpTarih.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTarih.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(242, 22);
            this.dtpTarih.TabIndex = 18;
            this.dtpTarih.Value = new System.DateTime(2025, 12, 6, 17, 32, 39, 915);
            // 
            // numSayfa
            // 
            this.numSayfa.BackColor = System.Drawing.Color.Transparent;
            this.numSayfa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.numSayfa, Guna.UI2.AnimatorNS.DecorationType.None);
            this.numSayfa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numSayfa.Location = new System.Drawing.Point(24, 319);
            this.numSayfa.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numSayfa.Name = "numSayfa";
            this.numSayfa.Size = new System.Drawing.Size(122, 24);
            this.numSayfa.TabIndex = 17;
            // 
            // txtYayinevi
            // 
            this.txtYayinevi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txtYayinevi, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtYayinevi.DefaultText = "";
            this.txtYayinevi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtYayinevi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtYayinevi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYayinevi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYayinevi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYayinevi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtYayinevi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYayinevi.Location = new System.Drawing.Point(24, 268);
            this.txtYayinevi.Name = "txtYayinevi";
            this.txtYayinevi.PlaceholderText = "YayınEvi Adı";
            this.txtYayinevi.SelectedText = "";
            this.txtYayinevi.Size = new System.Drawing.Size(240, 32);
            this.txtYayinevi.TabIndex = 16;
            // 
            // txtYazar
            // 
            this.txtYazar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txtYazar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtYazar.DefaultText = "";
            this.txtYazar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtYazar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtYazar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYazar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYazar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYazar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtYazar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYazar.Location = new System.Drawing.Point(24, 223);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.PlaceholderText = "Yazar Adı";
            this.txtYazar.SelectedText = "";
            this.txtYazar.Size = new System.Drawing.Size(240, 36);
            this.txtYazar.TabIndex = 15;
            // 
            // txtAd
            // 
            this.txtAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txtAd, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtAd.DefaultText = "";
            this.txtAd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAd.Location = new System.Drawing.Point(24, 179);
            this.txtAd.Name = "txtAd";
            this.txtAd.PlaceholderText = "Kitap Adı";
            this.txtAd.SelectedText = "";
            this.txtAd.Size = new System.Drawing.Size(240, 36);
            this.txtAd.TabIndex = 14;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.VertSlide;
            this.guna2Transition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation2;
            this.guna2Transition1.Interval = 15;
            // 
            // kitaplık
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1031, 533);
            this.Controls.Add(this.pnlKayit);
            this.Controls.Add(this.dgvListe);
            this.Controls.Add(this.panel1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Name = "kitaplık";
            this.Text = "kitaplık";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.pnlKayit.ResumeLayout(false);
            this.pnlKayit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSayfa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnDuzenle;
        private Guna.UI2.WinForms.Guna2Button btnSil;
        private Guna.UI2.WinForms.Guna2Button btnEkle;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListe;
        private Guna.UI2.WinForms.Guna2TextBox txtAra;
        private Guna.UI2.WinForms.Guna2Panel pnlKayit;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2NumericUpDown numStok;
        private Guna.UI2.WinForms.Guna2Button btnWebdenBul;
        private Guna.UI2.WinForms.Guna2PictureBox pbResim;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTarih;
        private Guna.UI2.WinForms.Guna2NumericUpDown numSayfa;
        private Guna.UI2.WinForms.Guna2TextBox txtYayinevi;
        private Guna.UI2.WinForms.Guna2TextBox txtYazar;
        private Guna.UI2.WinForms.Guna2TextBox txtAd;
        private Guna.UI2.WinForms.Guna2Button btnKaydet;
    }
}