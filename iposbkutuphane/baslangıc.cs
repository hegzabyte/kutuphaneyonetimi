using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace iposbkutuphane
{
    public partial class baslangıc : Form
    {
        private const string BAGLANTI = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Kutuphane.mdb;Persist Security Info=False;";
        private const int SATIR_YUKSEKLIGI = 110;

        private const string SORGU_OGRENCI_SAYISI = "SELECT COUNT(*) FROM Ogrenciler";
        private const string SORGU_KITAP_SAYISI = "SELECT COUNT(*) FROM Kitaplar";
        private const string SORGU_EMANET_SAYISI = "SELECT COUNT(*) FROM Emanetler WHERE Durum = 0";
        private const string SORGU_GECIKEN_SAYISI = "SELECT COUNT(*) FROM Emanetler WHERE Durum = 0 AND TeslimTarihi < Date()";

        private const string SORGU_SON_HAREKETLER = @"
            SELECT TOP 10
                (O.Ad + ' ' + O.Soyad) AS [Öğrenci],
                K.KitapAdi AS [Kitap],
                E.VerilisTarihi,
                IIF(E.Durum = 0, 'Okuyor', 'İade Etti') AS [Durum]
            FROM (Emanetler E
            INNER JOIN Ogrenciler O ON E.OgrenciID = O.OgrenciID)
            INNER JOIN Kitaplar K ON E.KitapID = K.KitapID
            ORDER BY E.EmanetID DESC";

        private readonly OleDbConnection baglanti;

        public baslangıc()
        {
            InitializeComponent();
            baglanti = new OleDbConnection(BAGLANTI);
        }

        private void baslangıc_Load(object sender, EventArgs e)
        {
            SayfayiYukle();
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (this.Visible)
            {
                SayfayiYukle();
            }
        }

        private void SayfayiYukle()
        {
            IstatistikleriGetir();
            SonHareketleriGetir();
        }

        private void IstatistikleriGetir()
        {
            try
            {
                BaglantiAc();
                SayilariHesapla();
                BaglantiKapat();
            }
            catch
            {
                BaglantiKapat();
            }
        }

        private void SayilariHesapla()
        {
            lblOgrenciSayisi.Text = OgrenciSayisiniGetir();
            lblKitapSayisi.Text = KitapSayisiniGetir();
            lblEmanetSayisi.Text = EmanetSayisiniGetir();
            lblGecikenSayisi.Text = GecikenSayisiniGetir();
        }

        private string OgrenciSayisiniGetir()
        {
            using (OleDbCommand komut = new OleDbCommand(SORGU_OGRENCI_SAYISI, baglanti))
            {
                return komut.ExecuteScalar().ToString();
            }
        }

        private string KitapSayisiniGetir()
        {
            using (OleDbCommand komut = new OleDbCommand(SORGU_KITAP_SAYISI, baglanti))
            {
                return komut.ExecuteScalar().ToString();
            }
        }

        private string EmanetSayisiniGetir()
        {
            using (OleDbCommand komut = new OleDbCommand(SORGU_EMANET_SAYISI, baglanti))
            {
                return komut.ExecuteScalar().ToString();
            }
        }

        private string GecikenSayisiniGetir()
        {
            using (OleDbCommand komut = new OleDbCommand(SORGU_GECIKEN_SAYISI, baglanti))
            {
                return komut.ExecuteScalar().ToString();
            }
        }

        private void SonHareketleriGetir()
        {
            try
            {
                BaglantiAc();
                DataTable veriTablosu = HareketVerileriniGetir();
                BaglantiKapat();
                VeriBagla(veriTablosu);
                Tablo();
            }
            catch
            {
                BaglantiKapat();
            }
        }

        private DataTable HareketVerileriniGetir()
        {
            DataTable veriTablosu = new DataTable();
            using (OleDbDataAdapter adaptor = new OleDbDataAdapter(SORGU_SON_HAREKETLER, baglanti))
            {
                adaptor.Fill(veriTablosu);
            }
            return veriTablosu;
        }

        private void VeriBagla(DataTable veriTablosu)
        {
            dgvAnaMenu.DataSource = veriTablosu;
        }

        private void Tablo()
        {
            if (dgvAnaMenu.Columns.Count == 0)
            {
                return;
            }

            TabloAyarla();
            SatirYukseklikleriniAyarla();
            dgvAnaMenu.ClearSelection();
        }


        private void TabloAyarla()
        {
            dgvAnaMenu.AllowUserToResizeRows = false;
            dgvAnaMenu.AllowUserToResizeColumns = false;
            dgvAnaMenu.AllowUserToOrderColumns = false;
            dgvAnaMenu.AllowUserToAddRows = false;
            dgvAnaMenu.ReadOnly = true;
            dgvAnaMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAnaMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnaMenu.MultiSelect = false;

            dgvAnaMenu.ColumnHeadersVisible = false;
            dgvAnaMenu.RowHeadersVisible = false;
            dgvAnaMenu.RowTemplate.Height = SATIR_YUKSEKLIGI;
            dgvAnaMenu.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvAnaMenu.BackgroundColor = Color.White;

            dgvAnaMenu.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAnaMenu.EnableHeadersVisualStyles = false;
        }

        private void SatirYukseklikleriniAyarla()
        {
            foreach (DataGridViewRow satir in dgvAnaMenu.Rows)
            {
                satir.Height = SATIR_YUKSEKLIGI;
            }
        }

        private void BaglantiAc()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }

        private void BaglantiKapat()
        {
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
        }
    }
}