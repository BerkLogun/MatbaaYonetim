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
    public partial class IsListesi : UserControl
    {
        public IsListesi()
        {
            InitializeComponent();
            
        }


        public void dataListUpdate()
        {
            string connectionString = "Data Source=(LocalDb)\\LocalDb;Initial Catalog=MatbaaLogs;Integrated Security=True";
            SqlConnection connect = new SqlConnection(connectionString);
            


            if(filtreCombo1.Text == "HEPSİ")
            {
                isListesiDataGrid.Rows.Clear();
                connect.Open();

                SqlCommand cmd = new SqlCommand("SELECT isID, tarih, firmaAdi, isAdi, makine, lakOnTur, kesilenAdet, kagitEbat, gramajCins FROM isListesi");
                cmd.Connection = connect;
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    isListesiDataGrid.Rows.Add(da.GetValue(0).ToString(), da.GetValue(1).ToString(), da.GetValue(2).ToString(), da.GetValue(3).ToString(), da.GetValue(4).ToString(), da.GetValue(5).ToString(), da.GetValue(6).ToString(), da.GetValue(7).ToString(), da.GetValue(8).ToString());
                }

                connect.Close();
            }
            if(filtreCombo1.Text == "SELEFON")
            {
                isListesiDataGrid.Rows.Clear();
                connect.Open();

                SqlCommand cmd = new SqlCommand("SELECT isID, tarih, firmaAdi, isAdi, makine, lakOnTur, kesilenAdet, kagitEbat, gramajCins FROM isListesi WHERE NOT selefOnX =''");
                cmd.Connection = connect;
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    isListesiDataGrid.Rows.Add(da.GetValue(0).ToString(), da.GetValue(1).ToString(), da.GetValue(2).ToString(), da.GetValue(3).ToString(), da.GetValue(4).ToString(), da.GetValue(5).ToString(), da.GetValue(6).ToString(), da.GetValue(7).ToString(), da.GetValue(8).ToString());
                }

                connect.Close();
            }
            if(filtreCombo1.Text == "LAK")
            {
                isListesiDataGrid.Rows.Clear();
                connect.Open();

                SqlCommand cmd = new SqlCommand("SELECT isID, tarih, firmaAdi, isAdi, makine, lakOnTur, kesilenAdet, kagitEbat, gramajCins FROM isListesi WHERE NOT lakOnEbatX =''");
                cmd.Connection = connect;
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    isListesiDataGrid.Rows.Add(da.GetValue(0).ToString(), da.GetValue(1).ToString(), da.GetValue(2).ToString(), da.GetValue(3).ToString(), da.GetValue(4).ToString(), da.GetValue(5).ToString(), da.GetValue(6).ToString(), da.GetValue(7).ToString(), da.GetValue(8).ToString());
                }

                connect.Close();
            }
            if(filtreCombo1.Text == "BOBST KESİM")
            {
                isListesiDataGrid.Rows.Clear();
                connect.Open();

                SqlCommand cmd = new SqlCommand("SELECT isID, tarih, firmaAdi, isAdi, makine, lakOnTur, kesilenAdet, kagitEbat, gramajCins FROM isListesi WHERE kesimIslem ='BOBST GOFRE'");
                cmd.Connection = connect;
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    isListesiDataGrid.Rows.Add(da.GetValue(0).ToString(), da.GetValue(1).ToString(), da.GetValue(2).ToString(), da.GetValue(3).ToString(), da.GetValue(4).ToString(), da.GetValue(5).ToString(), da.GetValue(6).ToString(), da.GetValue(7).ToString(), da.GetValue(8).ToString());
                }

                connect.Close();
            }
        }

        private void filtreCombo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataListUpdate();
        }
    }
}
