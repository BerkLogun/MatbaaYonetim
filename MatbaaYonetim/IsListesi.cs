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
            string connectionString = "***********";
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
                    isListesiDataGrid.Rows.Add(da.GetValue(0).ToString(), da.GetValue(1).ToString(), da.GetValue(2).ToString(), da.GetValue(3).ToString(), da.GetValue(4).ToString(), da.GetValue(5).ToString(), da.GetValue(6).ToString(), da.GetValue(7).ToString(), da.GetValue(8).ToString(),"","","","","","","");
                }

                connect.Close();
            }
            if(filtreCombo1.Text == "SELEFON")
            {
                isListesiDataGrid.Rows.Clear();
                connect.Open();

                SqlCommand cmd = new SqlCommand("SELECT isID, tarih, firmaAdi, isAdi, makine, lakOnTur, kesilenAdet, kagitEbat, gramajCins FROM isListesi WHERE NOT selefOnX ='' ORDER BY selefonSira");
                cmd.Connection = connect;
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    isListesiDataGrid.Rows.Add(da.GetValue(0).ToString(), da.GetValue(1).ToString(), da.GetValue(2).ToString(), da.GetValue(3).ToString(), da.GetValue(4).ToString(), da.GetValue(5).ToString(), da.GetValue(6).ToString(), da.GetValue(7).ToString(), da.GetValue(8).ToString(),"","","","","","","");
                }

                connect.Close();
            }
            if(filtreCombo1.Text == "LAK")
            {
                isListesiDataGrid.Rows.Clear();
                connect.Open();

                SqlCommand cmd = new SqlCommand("SELECT isID, tarih, firmaAdi, isAdi, makine, lakOnTur, kesilenAdet, kagitEbat, gramajCins FROM isListesi WHERE NOT lakOnEbatX ='' ORDER BY lakSira");
                cmd.Connection = connect;
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    isListesiDataGrid.Rows.Add(da.GetValue(0).ToString(), da.GetValue(1).ToString(), da.GetValue(2).ToString(), da.GetValue(3).ToString(), da.GetValue(4).ToString(), da.GetValue(5).ToString(), da.GetValue(6).ToString(), da.GetValue(7).ToString(), da.GetValue(8).ToString(),"","","","","","","");
                }

                connect.Close();
            }
            if(filtreCombo1.Text == "BOBST KESİM")
            {
                isListesiDataGrid.Rows.Clear();
                connect.Open();

                SqlCommand cmd = new SqlCommand("SELECT isID, tarih, firmaAdi, isAdi, makine, lakOnTur, kesilenAdet, kagitEbat, gramajCins FROM isListesi WHERE kesimIslem ='BOBST GOFRE' ORDER BY bobstSira");
                cmd.Connection = connect;
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    isListesiDataGrid.Rows.Add(da.GetValue(0).ToString(), da.GetValue(1).ToString(), da.GetValue(2).ToString(), da.GetValue(3).ToString(), da.GetValue(4).ToString(), da.GetValue(5).ToString(), da.GetValue(6).ToString(), da.GetValue(7).ToString(), da.GetValue(8).ToString(),"","","","","","","");
                }

                connect.Close();
            }
            if (filtreCombo1.Text == "KAZANLI KESİM")
            {
                isListesiDataGrid.Rows.Clear();
                connect.Open();

                SqlCommand cmd = new SqlCommand("SELECT isID, tarih, firmaAdi, isAdi, makine, lakOnTur, kesilenAdet, kagitEbat, gramajCins FROM isListesi WHERE kesimIslem ='KAZANLI KESIM' ORDER BY kazanliSira");
                cmd.Connection = connect;
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    isListesiDataGrid.Rows.Add(da.GetValue(0).ToString(), da.GetValue(1).ToString(), da.GetValue(2).ToString(), da.GetValue(3).ToString(), da.GetValue(4).ToString(), da.GetValue(5).ToString(), da.GetValue(6).ToString(), da.GetValue(7).ToString(), da.GetValue(8).ToString(),"","","","","","","");
                }

                connect.Close();
            }
            if (filtreCombo1.Text == "70X100")
            {
                isListesiDataGrid.Rows.Clear();
                connect.Open();

                SqlCommand cmd = new SqlCommand("SELECT isID, tarih, firmaAdi, isAdi, makine, lakOnTur, kesilenAdet, kagitEbat, gramajCins FROM isListesi WHERE makine ='70X100' ORDER BY yetmisSira");
                cmd.Connection = connect;
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    isListesiDataGrid.Rows.Add(da.GetValue(0).ToString(), da.GetValue(1).ToString(), da.GetValue(2).ToString(), da.GetValue(3).ToString(), da.GetValue(4).ToString(), da.GetValue(5).ToString(), da.GetValue(6).ToString(), da.GetValue(7).ToString(), da.GetValue(8).ToString(),"","","","","","","");
                }

                connect.Close();
            }
            if (filtreCombo1.Text == "50X70")
            {
                isListesiDataGrid.Rows.Clear();
                connect.Open();

                SqlCommand cmd = new SqlCommand("SELECT isID, tarih, firmaAdi, isAdi, makine, lakOnTur, kesilenAdet, kagitEbat, gramajCins FROM isListesi WHERE makine ='50X70' ORDER BY elliSira");
                cmd.Connection = connect;
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    isListesiDataGrid.Rows.Add(da.GetValue(0).ToString(), da.GetValue(1).ToString(), da.GetValue(2).ToString(), da.GetValue(3).ToString(), da.GetValue(4).ToString(), da.GetValue(5).ToString(), da.GetValue(6).ToString(), da.GetValue(7).ToString(), da.GetValue(8).ToString(),"","","","","","","");
                }

                connect.Close();
            }
            if (filtreCombo1.Text == "SMS2")
            {
                isListesiDataGrid.Rows.Clear();
                connect.Open();

                SqlCommand cmd = new SqlCommand("SELECT isID, tarih, firmaAdi, isAdi, makine, lakOnTur, kesilenAdet, kagitEbat, gramajCins FROM isListesi WHERE makine ='SMS2' ORDER BY smsSira");
                cmd.Connection = connect;
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    isListesiDataGrid.Rows.Add(da.GetValue(0).ToString(), da.GetValue(1).ToString(), da.GetValue(2).ToString(), da.GetValue(3).ToString(), da.GetValue(4).ToString(), da.GetValue(5).ToString(), da.GetValue(6).ToString(), da.GetValue(7).ToString(), da.GetValue(8).ToString(),"","","","","","","");
                }

                connect.Close();
            }


        }

        private void filtreCombo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataListUpdate();
        }




        int dragRow = -1;
        Label dragLabel = null;

        private void isListesiDataGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
            dragRow = e.RowIndex;

            if (dragLabel == null) dragLabel = new Label();
            dragLabel.Text = isListesiDataGrid[e.ColumnIndex, e.RowIndex].Value.ToString();

            dragLabel.Parent = isListesiDataGrid;
            dragLabel.Location = e.Location;
        }

        private void isListesiDataGrid_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left && dragLabel != null)
                {
                    dragLabel.Location = e.Location;
                    isListesiDataGrid.ClearSelection();
                }
            }
            catch { }
        }

        private void isListesiDataGrid_MouseUp(object sender, MouseEventArgs e)
        {

            var hit = isListesiDataGrid.HitTest(e.X, e.Y);
            int dropRow = -1;

            try
            {
                if (hit.Type != DataGridViewHitTestType.None)
                {
                    dropRow = hit.RowIndex;
                    if (dragRow >= 0)
                    {
                        int tgtRow = dropRow + (dragRow > dropRow ? 1 : 0);
                        if (tgtRow != dragRow)
                        {
                            DataGridViewRow row = isListesiDataGrid.Rows[dragRow];
                            isListesiDataGrid.Rows.Remove(row);
                            isListesiDataGrid.Rows.Insert(tgtRow, row);

                            isListesiDataGrid.ClearSelection();
                            row.Selected = true;
                        }
                    }
                }
                else { isListesiDataGrid.Rows[dragRow].Selected = true; }

                if (dragLabel != null)
                {
                    dragLabel.Dispose();
                    dragLabel = null;
                }

            }
            catch { }
        }

        private void isListesiDataGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
            try
            {
                if (filtreCombo1.Text == "SELEFON")
                {
                    if (isListesiDataGrid.Columns.Contains("selefonSira1"))
                    {
                        foreach (DataGridViewRow r in isListesiDataGrid.Rows)
                        {
                            r.Cells["selefonSira1"].Value = r.Index + 1;
                        }
                    }
                }
                if (filtreCombo1.Text == "LAK")
                {
                    if (isListesiDataGrid.Columns.Contains("lakSira1"))
                    {
                        foreach (DataGridViewRow r in isListesiDataGrid.Rows)
                        {
                            r.Cells["lakSira1"].Value = r.Index + 1;
                        }
                    }
                }
                if (filtreCombo1.Text == "BOBST KESİM")
                {
                    if (isListesiDataGrid.Columns.Contains("bobstSira1"))
                    {
                        foreach (DataGridViewRow r in isListesiDataGrid.Rows)
                        {
                            r.Cells["bobstSira1"].Value = r.Index + 1;
                        }
                    }
                }
                if (filtreCombo1.Text == "KAZANLI KESİM")
                {
                    if (isListesiDataGrid.Columns.Contains("kazanliSira1"))
                    {
                        foreach (DataGridViewRow r in isListesiDataGrid.Rows)
                        {
                            r.Cells["kazanliSira1"].Value = r.Index + 1;
                        }
                    }
                }
                if (filtreCombo1.Text == "70X100")
                {
                    if (isListesiDataGrid.Columns.Contains("sira70x100"))
                    {
                        foreach (DataGridViewRow r in isListesiDataGrid.Rows)
                        {
                            r.Cells["sira70x100"].Value = r.Index + 1;
                        }
                    }
                }
                if (filtreCombo1.Text == "50X70")
                {
                    if (isListesiDataGrid.Columns.Contains("sira50x70"))
                    {
                        foreach (DataGridViewRow r in isListesiDataGrid.Rows)
                        {
                            r.Cells["sira50x70"].Value = r.Index + 1;
                        }
                    }
                }
                if (filtreCombo1.Text == "SMS2")
                {
                    if (isListesiDataGrid.Columns.Contains("sms2Sira"))
                    {
                        foreach (DataGridViewRow r in isListesiDataGrid.Rows)
                        {
                            r.Cells["sms2Sira"].Value = r.Index + 1;
                        }
                    }
                }
            }
            catch { }
        }

        private void siralamaGuncelle_Click(object sender, EventArgs e)
        {
            
            string connectionString = "";
            SqlConnection connect = new SqlConnection(connectionString);


            

            if (filtreCombo1.Text == "SELEFON")
            {
                if (isListesiDataGrid.Columns.Contains("selefonSira1"))
                {
                    SqlCommand cmd = connect.CreateCommand();
                    

                    string selefon = "";
                    string isNo = "";
                    

                    connect.Open();
                    foreach (DataGridViewRow r in isListesiDataGrid.Rows)
                    {

                        selefon = r.Cells["selefonSira1"].Value.ToString();
                        isNo = r.Cells["isID1"].Value.ToString();
                        cmd.CommandText = "UPDATE isListesi set selefonSira = " + selefon + " WHERE isID = " + isNo;
                        cmd.ExecuteNonQuery();

                    }

                    
                }
            }
            if (filtreCombo1.Text == "LAK")
            {
                if (isListesiDataGrid.Columns.Contains("lakSira1"))
                {
                    SqlCommand cmd = connect.CreateCommand();

                    string laksira = "";
                    string isNo = "";

                 
                   connect.Open();
                   foreach (DataGridViewRow r in isListesiDataGrid.Rows)
                   {
                       laksira = r.Cells["lakSira1"].Value.ToString();
                       isNo = r.Cells["isID1"].Value.ToString();
                       cmd.CommandText = "UPDATE isListesi set lakSira = " + laksira + " WHERE isID = " + isNo;
                       cmd.ExecuteNonQuery();
                   }
                   connect.Close();
                    
                }
            }
            if (filtreCombo1.Text == "BOBST KESİM")
            {
                if (isListesiDataGrid.Columns.Contains("bobstSira1"))
                {
                    SqlCommand cmd = connect.CreateCommand();
                    string bobstsira;
                    string isNo = "";
                    connect.Open();
                    foreach (DataGridViewRow r in isListesiDataGrid.Rows)
                    {
                        bobstsira = r.Cells["bobstSira1"].Value.ToString();
                        isNo = r.Cells["isID1"].Value.ToString();
                        cmd.CommandText = "UPDATE isListesi set bobstSira = " + bobstsira + " WHERE isID = " + isNo;
                        cmd.ExecuteNonQuery();

                    }
                }
            }
            if (filtreCombo1.Text == "KAZANLI KESİM")
            {
                if (isListesiDataGrid.Columns.Contains("kazanliSira1"))
                {
                    SqlCommand cmd = connect.CreateCommand();
                    string kazansira;
                    string isNo = "";
                    connect.Open();
                    foreach (DataGridViewRow r in isListesiDataGrid.Rows)
                    {
                        kazansira = r.Cells["kazanliSira1"].Value.ToString();
                        isNo = r.Cells["isID1"].Value.ToString();
                        cmd.CommandText = "UPDATE isListesi set kazanliSira = " + kazansira + " WHERE isID = " + isNo;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            if (filtreCombo1.Text == "70X100")
            {
                if (isListesiDataGrid.Columns.Contains("sira70x100"))
                {
                    SqlCommand cmd = connect.CreateCommand();
                    string yetmisira;
                    string isNo = "";
                    connect.Open();
                    foreach (DataGridViewRow r in isListesiDataGrid.Rows)
                    {
                        yetmisira = r.Cells["sira70x100"].Value.ToString();
                        isNo = r.Cells["isID1"].Value.ToString();
                        cmd.CommandText = "UPDATE isListesi set yetmisSira = " + yetmisira + " WHERE isID = " + isNo;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            if (filtreCombo1.Text == "50X70")
            {
                if (isListesiDataGrid.Columns.Contains("sira50x70"))
                {
                    SqlCommand cmd = connect.CreateCommand();
                    string siraelli;
                    string isNo = "";
                    connect.Open();
                    foreach (DataGridViewRow r in isListesiDataGrid.Rows)
                    {
                        siraelli = r.Cells["sira50x70"].Value.ToString();
                        isNo = r.Cells["isID1"].Value.ToString();
                        cmd.CommandText = "UPDATE isListesi set elliSira = " + siraelli + " WHERE isID = " + isNo;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            if (filtreCombo1.Text == "SMS2")
            {
                if (isListesiDataGrid.Columns.Contains("sms2Sira"))
                {
                    SqlCommand cmd = connect.CreateCommand();
                    string smsira;
                    string isNo = "";
                    connect.Open();
                    foreach (DataGridViewRow r in isListesiDataGrid.Rows)
                    {
                        smsira = r.Cells["sms2Sira"].Value.ToString();
                        isNo = r.Cells["isID1"].Value.ToString();
                        cmd.CommandText = "UPDATE isListesi set smsSira = " + smsira + " WHERE isID = " + isNo;
                        cmd.ExecuteNonQuery();
                    }
                }
            }

        }
    }
}
