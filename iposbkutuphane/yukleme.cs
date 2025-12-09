using System;
using System.Windows.Forms;

namespace iposbkutuphane
{
    public partial class yukleme : Form
    {
        public yukleme()
        {
            InitializeComponent();
        }

        private void yukleme_Load(object sender, EventArgs e)
        {
            timer1.Start(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelYukle.Width += 5;

            if (panelYukle.Width >= panelArka.Width)
            {
                timer1.Stop();

                anamenu anaMenu = new anamenu();
                anaMenu.Show();
                this.Hide();
            }
        }

    }
}