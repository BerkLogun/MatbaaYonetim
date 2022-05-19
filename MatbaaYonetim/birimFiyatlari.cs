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
using System.Data.SqlClient;

namespace MatbaaYonetim
{
    public partial class birimFiyatlari : UserControl
    {
        public birimFiyatlari()
        {
            InitializeComponent();
            dosyaOkumaYazma();
        }
        static string connectionString = "Data Source=(LocalDb)\\LocalDb;Initial Catalog=MatbaaLogs;Integrated Security=True";
        public void dosyaOkumaYazma()
        {
            SqlConnection connect = new SqlConnection(connectionString);

            // Fiyat listesindeki elemanları daha kolay erişim için list icerisine eklenmesi

            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("Select cmyk_70x100Fiyat,ekstra1_70x100Fiyat,ekstra2_70x100Fiyat,ekstra3_70x100Fiyat,ekstra4_70x100Fiyat,baski41_70x100Fiyat,baski42_70x100Fiyat,tirajCMYK_70x100Fiyat,tirajEKSTRA_70x100Fiyat,dispLAK_70x100Fiyat,dispGecis_70x100Fiyat,cmykEkstraBoya_70x100Fiyat,cmyk_50x70Fiyat,ekstra1_50x70Fiyat,ekstra2_50x70Fiyat,ekstra3_50x70Fiyat,ekstra4_50x70Fiyat,baski41_50x70Fiyat,baski42_50x70Fiyat,tirajCMYK_50x70Fiyat,tirajEKSTRA_50x70Fiyat,parlakSelefonFiyat,parlakSF_50x70Fiyat,matSelefonFiyat,matSF_50x70Fiyat,renk_35x50Fiyat,tiraj_35x50Fiyat,uvLakMFiyat,bobstCemberFiyat,bobstGecisFiyat,yaldizBobstGecisFiyat,yaldizBobstCemberFiyat,yaldizKazanliGecisFiyat,yaldizKazanliCemberFiyat,kazanliKesimCemberFİyat,kazanliKesimGecisFiyat from fiyatListesi ");
                cmd.Connection = connect;
                SqlDataReader da = cmd.ExecuteReader();
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


                while (da.Read())
                {
                    int i = 0;

                    foreach (TextBox textboxs in fiyatList)
                    {
                        textboxs.Text = da.GetValue(i).ToString();
                        i++;
                    }

                }



            connect.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
    }
}
