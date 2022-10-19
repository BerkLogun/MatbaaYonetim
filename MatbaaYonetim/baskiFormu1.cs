using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MatbaaYonetim
{
    public partial class baskiFormu1 : UserControl
    {
        public baskiFormu1()
        {
            InitializeComponent();



            //Ekstra gizleme
            exlabel1.Visible = false;
            extratext1.Visible = false;
            exlabel2.Visible = false;
            extratext2.Visible = false;
            exlabel3.Visible = false;
            extratext3.Visible = false;
            exlabel4.Visible = false;
            extratext4.Visible = false;
            exlabel5.Visible = false;
            extratext5.Visible = false;
            exlabel6.Visible = false;
            extratext6.Visible = false;

            exArkaLabel1.Visible = false;
            extraArkatext1.Visible = false;
            exArkaLabel2.Visible = false;
            extraArkatext2.Visible = false;
            exArkaLabel3.Visible = false;
            extraArkatext3.Visible = false;
            exArkaLabel4.Visible = false;
            extraArkatext4.Visible = false;
            exArkaLabel5.Visible = false;
            extraArkatext5.Visible = false;
            exArkaLabel6.Visible = false;
            extraArkatext6.Visible = false;







            //combobox ekleme
            //baskı türleri
            baskıTuruCombo_on.Items.Add("CMYK");
            baskıTuruCombo_on.Items.Add("CMYK + EKSTRA");
            baskıTuruCombo_on.Items.Add("EKSTRA");
            baskiTuruCombo_arka.Items.Add("CMYK");
            baskiTuruCombo_arka.Items.Add("CMYK + EKSTRA");
            baskiTuruCombo_arka.Items.Add("EKSTRA");


            //Ekstra sayisi
            önExSayiCombo.Items.Add("1");
            önExSayiCombo.Items.Add("2");
            önExSayiCombo.Items.Add("3");
            önExSayiCombo.Items.Add("4");
            önExSayiCombo.Items.Add("5");
            önExSayiCombo.Items.Add("6");

            arkaExSayiCombo.Items.Add("1");
            arkaExSayiCombo.Items.Add("2");
            arkaExSayiCombo.Items.Add("3");
            arkaExSayiCombo.Items.Add("4");
            arkaExSayiCombo.Items.Add("5");
            arkaExSayiCombo.Items.Add("6");
        }
        string selectecBaskiYuzu;

        private void baskiYuzuCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectecBaskiYuzu = (string)baskiYuzuCombo.SelectedItem;

            if(selectecBaskiYuzu == "ÖN")
            {
                onBaskıPanel.Visible = true;
                arkaBaskiPanel.Visible = false;
                arkaEkstraPanel.Visible = false;
            }
            else if(selectecBaskiYuzu == "ÖN + ARKA")
            {
                onBaskıPanel.Visible = true;
                arkaBaskiPanel.Visible = true;
            }
            else if(selectecBaskiYuzu == "DÜZ REVOLTA" || selectecBaskiYuzu == "ETEK-MAKAS REVOLTA")
            {
                onBaskıPanel.Visible = true;
                arkaBaskiPanel.Visible = false;
                arkaEkstraPanel.Visible = false;
            }
            else
            {
                onBaskıPanel.Visible = false;
                arkaBaskiPanel.Visible = false;
                önEkstraPanel.Visible = false;
                arkaEkstraPanel.Visible = false;
            }
        }

        private void baskıTuruCombo_on_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(baskıTuruCombo_on.SelectedIndex == 1 || baskıTuruCombo_on.SelectedIndex == 2)
            {
                önEkstraPanel.Visible = true;
            }
            else
            {
                önEkstraPanel.Visible = false;
            }
        }

        private void baskiTuruCombo_arka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (baskiTuruCombo_arka.SelectedIndex == 1 || baskiTuruCombo_arka.SelectedIndex == 2)
            {
                arkaEkstraPanel.Visible = true;
            }
            else
            {
                arkaEkstraPanel.Visible = false;
            }
        }

        private void önEkstraPanel_Paint(object sender, PaintEventArgs e)
        {

        }

      

        


        private void önExSayiCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Label> extraLabelList = new List<Label>();
            List<TextBox> extraTextList = new List<TextBox>();
            extraLabelList.Add(exlabel1);
            extraLabelList.Add(exlabel2);
            extraLabelList.Add(exlabel3);
            extraLabelList.Add(exlabel4);
            extraLabelList.Add(exlabel5);
            extraLabelList.Add(exlabel6);

            extraTextList.Add(extratext1);
            extraTextList.Add(extratext2);
            extraTextList.Add(extratext3);
            extraTextList.Add(extratext4);
            extraTextList.Add(extratext5);
            extraTextList.Add(extratext6);

            int önExComboSecilen = Convert.ToInt32(önExSayiCombo.SelectedItem);


            foreach (Label labels in extraLabelList)
            {
                labels.Visible = false;
            }
            foreach (TextBox textboxs in extraTextList)
            {
                textboxs.Visible = false;
            }
            for (int i = 0; i < önExComboSecilen; i++)
            {
                 extraLabelList[i].Visible = true;
                extraTextList[i].Visible = true;
            }

         
            
        }

        private void arkaExSayiCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Label> extraLabelList = new List<Label>();
            List<TextBox> extraTextList = new List<TextBox>();
            extraLabelList.Add(exArkaLabel1);
            extraLabelList.Add(exArkaLabel2);
            extraLabelList.Add(exArkaLabel3);
            extraLabelList.Add(exArkaLabel4);
            extraLabelList.Add(exArkaLabel5);
            extraLabelList.Add(exArkaLabel6);

            extraTextList.Add(extraArkatext1);
            extraTextList.Add(extraArkatext2);
            extraTextList.Add(extraArkatext3);
            extraTextList.Add(extraArkatext4);
            extraTextList.Add(extraArkatext5);
            extraTextList.Add(extraArkatext6);

            int arkaExComboSecilen = Convert.ToInt32(arkaExSayiCombo.SelectedItem);


            foreach (Label labels in extraLabelList)
            {
                labels.Visible = false;
            }
            foreach (TextBox textboxs in extraTextList)
            {
                textboxs.Visible = false;
            }
            for (int i = 0; i < arkaExComboSecilen; i++)
            {
                extraLabelList[i].Visible = true;
                extraTextList[i].Visible = true;
            }

        }

        private void onBaskıPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void yapistirmaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(yapistirmaCheckBox.Checked == true)
            {
                yapistirmaPanel.Visible = true;
            }
            else
            {
                yapistirmaPanel.Visible = false;
            }
        }

        private void kesimCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(kesimCheckBox.Checked == true)
            {
                kesimPanel.Visible = true;
            }
            else
            {
                kesimPanel.Visible = false;
            }
        }
        public static string connectionString = "*************";
        SqlConnection connect = new SqlConnection(connectionString);
        private void button1_Click(object sender, EventArgs e)
        {
            
            var random = new Random();
            int id = random.Next();
            int tarih = random.Next()+1;
            
            
                SqlCommand cmd = new SqlCommand("insert into isListesi ([isID], [tarih], [firmaAdi], [isAdi], [isTuru], [makine], [formaSayisi], [notlar], [ekstraBoyaDokumu], [yaldizGideri], [gramajCins], [kagitEbat], [gelenTabaka], [baskiEbatX], [baskiEbatY], [kesilenAdet], [baskiYuzu], [kesim], [yapistirma], [baskiTuruOn], [dispersiyOn], [selefOnX], [selefOnY], [selefOnTuru], [selefOnAdet], [lakOnEbatX], [lakOnEbatY], [lakOnTur], [lakOnAdet], [yaldizOn], [onEkstraSayi], [onEx1], [onEx2], [onEx3], [onEx4], [onEx5], [onEx6], [baskiTuruArka], [dispersiyonArka], [selefonArkaX], [selefonArkaY], [selefonTuruArka], [selefonAdetArka], [lakArkaEbatX], [lakArkaEbatY], [lakArkaTur], [lakArkaAdet], [yaldizArka], [arkaEkstraSayi], [arkaEx1], [arkaEx2], [arkaEx3], [arkaEx4], [arkaEx5], [arkaEx6], [kesimIslem], [kesimEbatX], [kesimEbatY], [kesimAdet], [yapistirmaIslem], [yapistirmaEbatX], [yapistirmaEbatY], [yapistirmaAdet], [yapistirmaBoy])" +
                    "values ('"+id+
                    "','"+tarih+"','"+firmaAdiBox.Text+"','"+ isAdiBox.Text + "','" + isTuruBox.Text + "','" + makineBox.Text + "','" + formaSayisiText.Text + "','" + notlarText.Text + "','" + exBoyaDText.Text + "','" + yaldizGideriText.Text + "','" + gramajCinsText.Text + "','" + kagitEbatText.Text + "','" + gelenTabakaText.Text + "','" + baskiEbatText_1.Text + "','" + baskiEbatText_2.Text + "','" + kesilenAdetText.Text + "','" + baskiYuzuCombo.Text + "','" + kesimCheckBox.Checked.ToString() + "','" + yapistirmaCheckBox.Checked.ToString() + "','" + baskıTuruCombo_on.Text + "','" + dispersOnCheck.Checked.ToString() + "','" + selefonEbad1_on.Text + "','" + selefonEbad2_on.Text + "','" + selefonTuruCombo_on.Text + "','" + selefonAdetOnText.Text + "','" + lakEbadı1_on.Text + "','" + lakEbadı2_on.Text + "','" + lakTuruCombo_on.Text + "','" + lakAdetOnText.Text + "','" + yaldizOnText.Text + "','" + önExSayiCombo.Text + "','" + extratext1.Text + "','" + extratext2.Text + "','" + extratext3.Text + "','" + extratext4.Text + "','" + extratext5.Text + "','" + extratext6.Text + "','" + baskiTuruCombo_arka.Text + "','" + dispersArkaCheck.Checked.ToString() + "','" + selefonEbat1_arka.Text + "','" + selefonEbat2_arka.Text + "','" + selefonTuruCombo_arka.Text + "','" + selefonAdetArkaText.Text + "','" + lakEbadı1_arka.Text + "','" + lakEbadı2_arka.Text + "','" + lakTuruCombo_arka.Text + "','" + lakAdetArkaText.Text + "','" + yaldizArkaText.Text + "','" + arkaExSayiCombo.Text + "','" + extraArkatext1.Text + "','" + extraArkatext2.Text + "','" + extraArkatext3.Text + "','" + extraArkatext4.Text + "','" + extraArkatext5.Text + "','" + extraArkatext6.Text + "','" + kesimİslemCombo.Text + "','" + kesimEbat1.Text + "','" + kesimEbat2.Text + "','" + kesimAdetText.Text + "','" + yapistirmaIslemCombo.Text + "','" + yapistirmaIslem1Text.Text + "','" + yapistirmaIslem2Text.Text + "','" + yapistirmaAdetText.Text + "','" + yapistirmaBoyText.Text + "')", connect);

                connect.Open();

                cmd.ExecuteNonQuery();
                
                MessageBox.Show("basarili");
                //SqlCommand cmd = new SqlCommand("INSERT INTO isListesi(isID) VALUES (" + id + ")");
                //cmd.Connection = connect;

                connect.Close();



            /*
             * 
             * ,isTuru,makine," +
                    "formaSayisi,notlar,ekstraBoyaDokumu,yaldizGideri,gramajCins,kagitEbat,gelenTabaka," +
                    "baskiEbatX,baskiEbatY,kesilenAdet,baskiYuzu,kesim,yapistirma,baskiTuruOn,dispersiyOn," +
                    "selefOnX,selefOnY,selefOnTuru,selefOnAdet,lakOnEbatX,lakOnEbatY,lakOnTur,lakOnAdet," +
                    "yaldizOn,onEkstraSayi,onEx1,onEx2,onEx3,onEx4,onEx5,onEx6," +
                    "baskiTuruArka,dispersiyonArka,selefonArkaX,selefonArkaY,selefonTuruArka,selefonAdetArka," +
                    "lakArkaEbatX,lakArkaEbatY,lakArkaTur,lakArkaAdet,yaldizArka,arkaEkstraSayi," +
                    "arkaEx1,arkaEx2,arkaEx3,arkaEx4,arkaEx5,arkaEx6,kesimIslem,kesimEbatX,kesimEbatY,kesimAdet," +
                    "yapistirmaIslem,yapistirmaEbatX,yapistirmaEbatY,yapistirmaAdet,yapistirmaBoy






                
            */


        }
    }
}
