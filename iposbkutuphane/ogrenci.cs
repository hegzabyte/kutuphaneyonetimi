using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace iposbkutuphane
{
    public partial class ogrenciekle : Form
    {
        private const string BAGLANTI = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Kutuphane.mdb;Persist Security Info=False;";
        private const int SATIR_YUKSEKLIGI = 110;
        private const string SORGU_TUMUNU_GETIR = "SELECT * FROM Ogrenciler ORDER BY OgrenciID DESC";
        private const string SORGU_EKLE = "INSERT INTO Ogrenciler (Ad, Soyad, Sinif, OkulNo, Telefon, KayitTarihi) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)";
        private const string SORGU_SIL = "DELETE FROM Ogrenciler WHERE OgrenciID=";

        private readonly OleDbConnection baglanti;

        public ogrenciekle()
        {
            InitializeComponent();
            baglanti = new OleDbConnection(BAGLANTI);
            EventleriKaydet();
        }

        private void EventleriKaydet()
        {
            dgvOgrenci.Paint += dgvOgrenci_Paint;
            dgvOgrenci.RowPrePaint += (s, e) => e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void ogrenciekle_Load(object sender, EventArgs e)
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
                DataTable veriTablosu = OgrencileriGetir();
                VeriBagla(veriTablosu);
                Tablo();
            }
            catch (Exception)
            {
                
            }
        }

        private void BaglantiKapat()
        {
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
        }

        private DataTable OgrencileriGetir()
        {
            baglanti.Open();
            DataTable veriTablosu = new DataTable();
            using (OleDbDataAdapter adaptor = new OleDbDataAdapter(SORGU_TUMUNU_GETIR, baglanti))
            {
                adaptor.Fill(veriTablosu);
            }
            baglanti.Close();
            return veriTablosu;
        }

        private void VeriBagla(DataTable veriTablosu)
        {
            dgvOgrenci.DataSource = veriTablosu;
        }

        private void Tablo()
        {
            if (dgvOgrenci.Columns.Count == 0)
            {
                return;
            }

            TabloAyarları();
            IDGizle();
            SatirYukseklikleriniAyarla();
            dgvOgrenci.ClearSelection();
        }

        private void TabloAyarları()
        {
            dgvOgrenci.AllowUserToResizeRows = false;
            dgvOgrenci.AllowUserToResizeColumns = false;
            dgvOgrenci.AllowUserToOrderColumns = false;
            dgvOgrenci.AllowUserToAddRows = false;
            dgvOgrenci.ReadOnly = true;
            dgvOgrenci.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOgrenci.MultiSelect = false;
            dgvOgrenci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOgrenci.ColumnHeadersVisible = false;
            dgvOgrenci.RowHeadersVisible = false;
            dgvOgrenci.RowTemplate.Height = SATIR_YUKSEKLIGI;
            dgvOgrenci.DefaultCellStyle.Font = new Font("Segoe UI", 10);
        }

        private void IDGizle()
        {
            if (dgvOgrenci.Columns.Contains("OgrenciID"))
            {
                dgvOgrenci.Columns["OgrenciID"].Visible = false;
            }
        }

        private void SatirYukseklikleriniAyarla()
        {
            foreach (DataGridViewRow satir in dgvOgrenci.Rows)
            {
                satir.Height = SATIR_YUKSEKLIGI;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text))
            {
                return;
            }

            try
            {
                OgrenciEkle();
                Basarili();
                YenileVeTemizle();
            }
            catch (Exception ex)
            {
                VeriTabani(ex);
            }
        }

        private void OgrenciEkle()
        {
            baglanti.Open();
            using (OleDbCommand komut = KomutOlustur())
            {
                komut.ExecuteNonQuery();
            }
            baglanti.Close();
        }

        private OleDbCommand KomutOlustur()
        {
            OleDbCommand komut = new OleDbCommand(SORGU_EKLE, baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtSinif.Text);
            komut.Parameters.AddWithValue("@p4", txtOkulNo.Text);
            komut.Parameters.AddWithValue("@p5", " ");
            komut.Parameters.AddWithValue("@p6", DateTime.Now.ToShortDateString());
            return komut;
        }

        private void Basarili()
        {
            MessageBox.Show("Eklendi");
        }

        private void YenileVeTemizle()
        {
            Listele();
            Temizle();
        }

        private void VeriTabani(Exception ex)
        {
            baglanti.Close();
            MessageBox.Show(ex.Message);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (!SatirSecilmisMi())
            {
                return;
            }

            if (SilmeOnayi())
            {
                SeciliOgrenciyiSil();
            }
        }

        private bool SatirSecilmisMi()
        {
            return dgvOgrenci.SelectedRows.Count > 0;
        }

        private bool SilmeOnayi()
        {
            return MessageBox.Show("Silinsin mi?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        private void SeciliOgrenciyiSil()
        {
            try
            {
                baglanti.Open();
                SilmeIsleminiGerceklestir();
                baglanti.Close();
                Listele();
            }
            catch (Exception)
            {
                baglanti.Close();
            }
        }

        private void SilmeIsleminiGerceklestir()
        {
            string ogrenciId = dgvOgrenci.CurrentRow.Cells["OgrenciID"].Value.ToString();
            string silmeSorgusu = SORGU_SIL + ogrenciId;
            using (OleDbCommand komut = new OleDbCommand(silmeSorgusu, baglanti))
            {
                komut.ExecuteNonQuery();
            }
        }

        private void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtSinif.Clear();
            txtOkulNo.Clear();
            txtAd.Focus();
        }

        private void dgvOgrenci_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}