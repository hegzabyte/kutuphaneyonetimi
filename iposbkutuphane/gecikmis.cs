using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace iposbkutuphane
{
    public partial class gecikmis : Form
    {
        private const string BAGLANTI = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Kutuphane.mdb;Persist Security Info=False;";
        private const int SATIR_YUKSEKLIGI = 110;
        private const string SORGU_GECIKEN_KITAPLAR = @"
            SELECT 
                E.EmanetID,
                (O.Ad + ' ' + O.Soyad) AS [Ogrenci],
                O.Sinif, 
                O.Telefon, 
                K.KitapAdi, 
                E.VerilisTarihi, 
                E.TeslikTarihi,
                (CSTR(DateDiff('d', E.TeslimTarihi, Date())) + ' Gün Geçti') AS GecikmeGun
            FROM (Emanetler E
            INNER JOIN Ogrenciler O ON E.OgrenciID = O.OgrenciID)
            INNER JOIN Kitaplar K ON E.KitapID = K.KitapID
            WHERE E.Durum = 0 AND E.TeslimTarihi < Date() 
            ORDER BY E.TeslimTarihi ASC";

        private readonly OleDbConnection baglanti;

        public gecikmis()
        {
            InitializeComponent();
            baglanti = new OleDbConnection(BAGLANTI);
            EventleriKaydet();
        }

        private void EventleriKaydet()
        {
            dgvGecikenler.Paint += dgvGecikenler_Paint;
        }

        private void gecikmis_Load(object sender, EventArgs e)
        {
            Listele();
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (this.Visible)
            {
                Listele();
            }
        }

        private void Listele()
        {
            try
            {
                BaglantiKapat();
                DataTable veriTablosu = GecikenKitaplariGetir();
                VeriyiBagla(veriTablosu);
                Tablo();
            }
            catch
            {
                BaglantiKapat();
            }
        }

        private void BaglantiKapat()
        {
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
        }

        private DataTable GecikenKitaplariGetir()
        {
            baglanti.Open();
            DataTable veriTablosu = new DataTable();
            using (OleDbDataAdapter adaptor = new OleDbDataAdapter(SORGU_GECIKEN_KITAPLAR, baglanti))
            {
                adaptor.Fill(veriTablosu);
            }
            baglanti.Close();
            return veriTablosu;
        }

        private void VeriyiBagla(DataTable veriTablosu)
        {
            dgvGecikenler.DataSource = null;
            dgvGecikenler.Columns.Clear();
            dgvGecikenler.DataSource = veriTablosu;
        }

        private void Tablo()
        {
            if (dgvGecikenler.Columns.Count == 0)
            {
                return;
            }

            TabloAyarla();
            SutunlariAyarla();
            SatirYukseklikleriniAyarla();
            dgvGecikenler.ClearSelection();
        }


        private void TabloAyarla()
        {
            dgvGecikenler.AllowUserToResizeRows = false;
            dgvGecikenler.AllowUserToResizeColumns = false;
            dgvGecikenler.AllowUserToOrderColumns = false;
            dgvGecikenler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGecikenler.AllowUserToAddRows = false;
            dgvGecikenler.ReadOnly = true;
            dgvGecikenler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGecikenler.MultiSelect = false;
            dgvGecikenler.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvGecikenler.EnableHeadersVisualStyles = false;
            dgvGecikenler.ColumnHeadersVisible = false;
            dgvGecikenler.RowHeadersVisible = false;
            dgvGecikenler.RowTemplate.Height = SATIR_YUKSEKLIGI;
            dgvGecikenler.DefaultCellStyle.Font = new Font("Segoe UI", 10);
        }

        private void SutunlariAyarla()
        {
            IdSutunuGizle();
            GecikmeGunSutun();
        }

        private void IdSutunuGizle()
        {
            if (dgvGecikenler.Columns.Contains("EmanetID"))
            {
                dgvGecikenler.Columns["EmanetID"].Visible = false;
            }
        }

        private void GecikmeGunSutun()
        {
            if (dgvGecikenler.Columns.Contains("GecikmeGun"))
            {
                dgvGecikenler.Columns["GecikmeGun"].DefaultCellStyle.ForeColor = Color.Red;
                dgvGecikenler.Columns["GecikmeGun"].DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            }
        }

        private void SatirYukseklikleriniAyarla()
        {
            foreach (DataGridViewRow satir in dgvGecikenler.Rows)
            {
                satir.Height = SATIR_YUKSEKLIGI;
            }
        }

        private void dgvGecikenler_Paint(object sender, PaintEventArgs e)
        {
            if (dgvGecikenler.Rows.Count == 0)
            {
                BosTabloMesajiGoster(e);
            }
        }

        private void BosTabloMesajiGoster(PaintEventArgs e)
        {
            string mesaj = " Geciken Kitap Yok";
            Font yazi = new Font("Segoe UI", 16, FontStyle.Bold);
            SizeF metinBoyutu = e.Graphics.MeasureString(mesaj, yazi);

            float x = (dgvGecikenler.Width - metinBoyutu.Width) / 2;
            float y = (dgvGecikenler.Height - metinBoyutu.Height) / 2;

            e.Graphics.DrawString(mesaj, yazi, Brushes.LimeGreen, x, y);
        }

        private void dgvGecikenler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}