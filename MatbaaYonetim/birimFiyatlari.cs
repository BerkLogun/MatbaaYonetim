using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MatbaaYonetim
{
    public partial class birimFiyatlari : UserControl
    {
        public birimFiyatlari()
        {
            InitializeComponent();
            dosyaOkumaYazma();
        }
        
        public void dosyaOkumaYazma()
        {

            // Fiyat listesindeki elemanları daha kolay erişim için list icerisine eklenmesi
            List<TextBox> fiyatList = new List<TextBox>();
            fiyatList.Add(cmyk_70x100Fiyat);
            fiyatList.Add(ekstra1_70x100Fiyat);
            fiyatList.Add(ekstra2_70x100Fiyat);
            fiyatList.Add(ekstra3_70x100Fiyat);
            fiyatList.Add(ekstra4_70x100Fiyat);
            fiyatList.Add(baski41_70x100Fiyat);
            fiyatList.Add(baski42_70x100Fiyat);
            fiyatList.Add(tirajCMYK_70x100Fiyat);
            fiyatList.Add(tirajEKSTRA_70x100Fiyat);
            fiyatList.Add(dispLAK_70x100Fiyat);
            fiyatList.Add(dispGecis_70x100Fiyat);
            fiyatList.Add(cmykEkstraBoya_70x100Fiyat);
            fiyatList.Add(cmyk_50x70Fiyat);
            fiyatList.Add(ekstra1_50x70Fiyat);
            fiyatList.Add(ekstra2_50x70Fiyat);
            fiyatList.Add(ekstra3_50x70Fiyat);
            fiyatList.Add(ekstra4_50x70Fiyat);
            fiyatList.Add(baski41_50x70Fiyat);
            fiyatList.Add(baski42_50x70Fiyat);
            fiyatList.Add(tirajCMYK_50x70Fiyat);
            fiyatList.Add(tirajEKSTRA_50x70Fiyat);
            fiyatList.Add(parlakSelefonFiyat);
            fiyatList.Add(parlakSF_50x70Fiyat);
            fiyatList.Add(matSelefonFiyat);
            fiyatList.Add(matSF_50x70Fiyat);
            fiyatList.Add(renk_35x50Fiyat);
            fiyatList.Add(tiraj_35x50Fiyat);
            fiyatList.Add(uvLakMFiyat);
            fiyatList.Add(bobstCemberFiyat);
            fiyatList.Add(bobstGecisFiyat);
            fiyatList.Add(yaldizBobstGecisFiyat);
            fiyatList.Add(yaldizBobstCemberFiyat);
            fiyatList.Add(yaldizKazanliGecisFiyat);
            fiyatList.Add(yaldizKazanliCemberFiyat);
            fiyatList.Add(kazanliKesimCemberFİyat);
            fiyatList.Add(kazanliKesimGecisFiyat);



            var lines = File.ReadAllLines(@"C:\Users\Berk\source\repos\MatbaaYonetim\MatbaaYonetim\FiyatList.csv");
            int i = 0;
            foreach (var line in lines)
            {
                i++;
                var values = line.Split(",");

                foreach (TextBox textboxs in fiyatList)
                {
                    textboxs.Text = values[i-1];

                }


            }


        }
    }
}
