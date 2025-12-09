using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using KutuphaneSistemi; 

namespace iposbkutuphane
{
    public partial class anamenu : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        Color aktifRenk = Color.FromArgb(55, 50, 120);
        Color pasifRenk = Color.White;
        Color hoverRenk = Color.FromArgb(230, 230, 230);
        private Button suankiSeciliButon = null;

        public anamenu()
        {
            InitializeComponent();
            OlaylariBagla();

            this.Load += Anamenu_Load;
            this.MouseDown += Anamenu_MouseDown;
            this.MouseMove += Anamenu_MouseMove;
            this.MouseUp += Anamenu_MouseUp;
        }

        private void Anamenu_Load(object sender, EventArgs e)
        {
            // Program açılınca istatistik sayfası gelsin
            if (btnAnaMenu != null) btnAnaMenu.PerformClick();
        }

        private void Anamenu_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Anamenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Anamenu_MouseUp(object sender, MouseEventArgs e) { dragging = false; }

        private void OlaylariBagla()
        {
            Button[] butonlar = { btnAnaMenu, btnKitaplik, btnOgrenci, btnEmanet, btnGecikmis };
            foreach (var btn in butonlar)
            {
                if (btn != null)
                {
                    btn.MouseEnter += Buton_MouseEnter;
                    btn.MouseLeave += Buton_MouseLeave;
                }
            }
        }

        private void ButonuSekillendir(Button btn, Color renk, bool yuvarlakYap)
        {
            if (btn == null) return;
            btn.BackColor = renk;
            btn.ForeColor = (renk == aktifRenk) ? Color.White : Color.Black;

            if (yuvarlakYap)
            {
                int radius = 30;
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
                path.CloseAllFigures();
                btn.Region = new Region(path);
            }
            else btn.Region = null;
        }

        private void ButonaTiklandi(Button tiklananButon)
        {
            if (suankiSeciliButon != null) ButonuSekillendir(suankiSeciliButon, pasifRenk, false);
            suankiSeciliButon = tiklananButon;
            ButonuSekillendir(suankiSeciliButon, aktifRenk, true);
        }

        private void Buton_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn != suankiSeciliButon) ButonuSekillendir(btn, hoverRenk, true);
        }

        private void Buton_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn != suankiSeciliButon) ButonuSekillendir(btn, pasifRenk, false);
        }

        private void SayfaGetir(Form form)
        {
            pnlAnaMenu.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlAnaMenu.Controls.Add(form);
            form.Show();
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            ButonaTiklandi(btnAnaMenu);
            baslangıc fr = new baslangıc();
            SayfaGetir(fr);
        }

        private void btnKitaplik_Click(object sender, EventArgs e)
        {
            ButonaTiklandi(btnKitaplik);
            kitaplık fr = new kitaplık();
            SayfaGetir(fr);
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            ButonaTiklandi(btnOgrenci);
            ogrenciekle fr = new ogrenciekle();
            SayfaGetir(fr);
        }

        private void btnEmanet_Click(object sender, EventArgs e)
        {
            ButonaTiklandi(btnEmanet);
            emanet fr = new emanet();
            SayfaGetir(fr);
        }

        private void btnGecikmis_Click(object sender, EventArgs e)
        {
            ButonaTiklandi(btnGecikmis);
            gecikmis fr = new gecikmis();
            SayfaGetir(fr);
        }
    }
}