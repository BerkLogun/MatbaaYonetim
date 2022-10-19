using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatbaaYonetim
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }


        private void Anasayfa_Load_1(object sender, EventArgs e)
        {
            baskiFormu11.Hide();
            isListesi1.Hide();
            aylikRaporlar1.Hide();
            birimFiyatlari1.Hide();
            
        }

        private void isBaskiButton_Click(object sender, EventArgs e)
        {
            isListesi1.Hide();
            birimFiyatlari1.Hide();
            aylikRaporlar1.Hide();
            baskiFormu11.Show();
            baskiFormu11.BringToFront();

        }


        private void isListesiButton_Click_1(object sender, EventArgs e)
        {
            baskiFormu11.Hide();
            birimFiyatlari1.Hide();
            aylikRaporlar1.Hide();
            isListesi1.Show();
            isListesi1.BringToFront();
        }

        private void fiyatListeButton_Click_1(object sender, EventArgs e)
        {
            baskiFormu11.Hide();
            isListesi1.Hide();
            aylikRaporlar1.Hide();
            birimFiyatlari1.Show();
            birimFiyatlari1.BringToFront();
        }

        private void aylikRaporButton_Click(object sender, EventArgs e)
        {
            baskiFormu11.Hide();
            isListesi1.Hide();
            birimFiyatlari1.Hide();
            aylikRaporlar1.Show();
            aylikRaporlar1.BringToFront();
        }

        
    }

    

}
