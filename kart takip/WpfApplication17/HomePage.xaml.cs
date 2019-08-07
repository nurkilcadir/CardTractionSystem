using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace WpfApplication17
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    ///         
    //public class KuryeDTO
    //    {
    //        public int Id { get; set; }
    //        public string vbMüsteri { get; set; }
    //        public string txtAdiki { get; set; }
    //    }

    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }
        public DataRow KartId;

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            //KuryeDTO Kurye= new KuryeDTO();
            try
            {
                string vbMüsteri = this.vbMüsteri.Text;
                string txtAd = this.txtAd.Text;
                string txtAdiki = this.txtAdiki.Text;
                string txtSoyad = this.txtSoyad.Text;
                string txtKartNo = this.txtKartNo.Text;
                string cbxİslem = this.cbxİslem.Text;
                string cbxKurye = this.cbxKurye.Text;
                string txtUrunKod = this.txtUrunKod.Text;
                string cbxKTipi = this.cbxKTipi.Text;
                //string kayitTarih = this.kayitTarih.Text;
                //string teslimTarih = this.teslimTarih.Text;
                //string kuryeTarih = this.kuryeTarih.Text;
                string bsMüsteri = this.bsMüsteri.Text;
                string barkod = this.barkod.Text;
                string tcNo = this.tcNo.Text;
                string txtSube = this.txtSube.Text + this.cbxSube.Text;
                string txtUrunAd = this.txtUrunAd.Text;
                string txtBayi = this.txtBayi.Text;
                string cbxSozlesme = this.cbxSozlesme.Text;
                //string basimTarih = this.basimTarih.Text;
                //string iadeTarih = this.iadeTarih.Text;
                string date = this.kuryeTarih.Text;
                string kuryeTarih = DateTime.ParseExact(date, "dd.MM.yyyy",
                                CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
                string date1 = this.teslimTarih.Text;
                string teslimTarih = DateTime.ParseExact(date, "dd.MM.yyyy",
                                CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
                string date2 = this.kayitTarih.Text;
                string kayitTarih = DateTime.ParseExact(date, "dd.MM.yyyy",
                                CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
                string date3 = this.basimTarih.Text;
                string basimTarih = DateTime.ParseExact(date, "dd.MM.yyyy",
                                CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
                string date4 = this.iadeTarih.Text;
                string iadeTarih = DateTime.ParseExact(date, "dd.MM.yyyy",
                                CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
                if (vbMüsteri != "" && txtAd != "" && txtSoyad != "" && txtKartNo != ""
                    && cbxİslem != "" && cbxKurye != "" && txtUrunKod != "" && cbxKTipi != "" &&
                    kayitTarih != "" && teslimTarih != "" && kuryeTarih != "" && bsMüsteri != "" &&
                    barkod != "" && tcNo != "" && txtSube != "" &&
                    txtUrunAd != "" && txtBayi != "" && cbxSozlesme != "" && basimTarih != "" &&
                    iadeTarih != "")
                {
                    HomeBusinessLogic.SaveInfo(vbMüsteri, txtAd, txtAdiki, txtSoyad, txtKartNo, cbxİslem, cbxKurye, txtUrunKod,
                   cbxKTipi, kayitTarih, teslimTarih, kuryeTarih, bsMüsteri, barkod, tcNo, txtSube, txtUrunAd,
                   txtBayi, cbxSozlesme, basimTarih, iadeTarih);
                    MessageBox.Show("Kayıt ekleme işlemi başarılı", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                    foreach (UIElement element in MyGrid.Children)
                    {
                        TextBox textbox = element as TextBox;
                        if (textbox != null)
                        {
                            textbox.Text = String.Empty;
                        }

                    }

                    foreach (UIElement element in MyGrid.Children)
                    {
                        ComboBox combobox = element as ComboBox;
                        if (combobox != null)
                        {
                            combobox.Text = String.Empty;
                        }

                    }

                    foreach (UIElement element in MyGrid.Children)
                    {
                        DatePicker datePicker = element as DatePicker;
                        if (datePicker != null)
                        {
                            datePicker.Text = String.Empty;
                        }

                    }
                }
                else
                {
                    MessageBox.Show("** ile gösterilen alanlari boş birakmayiniz.", "Fail", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                } 
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                MessageBox.Show("Bir şeyler yanlış gitti, lütfen tekrar deneyiniz.", "Fail", MessageBoxButton.OK, MessageBoxImage.Error);
            }
    
        }
        
        
        private void btnLstele_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Users\st900394\Documents\localdb.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    con.Open();
                    SqlDataAdapter adapvare = new SqlDataAdapter("SELECT * FROM KARTTAKIP", con);
                    System.Data.DataSet dsFald = new System.Data.DataSet();
                    adapvare.Fill(dsFald, "KARTTAKIP");
                    lstDeneme.DataContext = dsFald.Tables["KARTTAKIP"].DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string tur = aracbx.Text.ToString();
            if (tur == "Kart No")
            {
                string sorgu = txtKartNo.Text.ToString();
                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Users\st900394\Documents\localdb.mdf;Integrated Security=True;Connect Timeout=30"))
                    {
                        con.Open();
                        SqlDataAdapter adapvare = new SqlDataAdapter("SELECT * FROM KARTTAKIP WHERE KARTNO= "+"'"+sorgu+"'", con);
                        System.Data.DataSet dsFald = new System.Data.DataSet();
                        adapvare.Fill(dsFald, "KARTTAKIP");
                        lstDeneme.DataContext = dsFald.Tables["KARTTAKIP"].DefaultView;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            if (tur == "Ad")
            {
                string sorgu1 = txtAd.Text.ToString();
                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Users\st900394\Documents\localdb.mdf;Integrated Security=True;Connect Timeout=30"))
                    {
                        con.Open();
                        SqlDataAdapter adapvare = new SqlDataAdapter("SELECT * FROM KARTTAKIP WHERE AD= " + "'" + sorgu1 + "'", con);
                        System.Data.DataSet dsFald = new System.Data.DataSet();
                        adapvare.Fill(dsFald, "KARTTAKIP");
                        lstDeneme.DataContext = dsFald.Tables["KARTTAKIP"].DefaultView;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            if (tur == "Soyad")
            {
                string sorgu1 = txtSoyad.Text.ToString();
                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Users\st900394\Documents\localdb.mdf;Integrated Security=True;Connect Timeout=30"))
                    {
                        con.Open();
                        SqlDataAdapter adapvare = new SqlDataAdapter("SELECT * FROM KARTTAKIP WHERE SOYAD= " + "'" + sorgu1 + "'", con);
                        System.Data.DataSet dsFald = new System.Data.DataSet();
                        adapvare.Fill(dsFald, "KARTTAKIP");
                        lstDeneme.DataContext = dsFald.Tables["KARTTAKIP"].DefaultView;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            if (tur == "Vb Müşteri No")
            {
                string sorgu1 = vbMüsteri.Text.ToString();
                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Users\st900394\Documents\localdb.mdf;Integrated Security=True;Connect Timeout=30"))
                    {
                        con.Open();
                        SqlDataAdapter adapvare = new SqlDataAdapter("SELECT * FROM KARTTAKIP WHERE VBMUSTERINO= " + "'" + sorgu1 + "'", con);
                        System.Data.DataSet dsFald = new System.Data.DataSet();
                        adapvare.Fill(dsFald, "KARTTAKIP");
                        lstDeneme.DataContext = dsFald.Tables["KARTTAKIP"].DefaultView;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            if (tur == "TC No")
            {
                string sorgu1 = tcNo.Text.ToString();
                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Users\st900394\Documents\localdb.mdf;Integrated Security=True;Connect Timeout=30"))
                    {
                        con.Open();
                        SqlDataAdapter adapvare = new SqlDataAdapter("SELECT * FROM KARTTAKIP WHERE TCNO= " + "'" + sorgu1 + "'", con);
                        System.Data.DataSet dsFald = new System.Data.DataSet();
                        adapvare.Fill(dsFald, "KARTTAKIP");
                        lstDeneme.DataContext = dsFald.Tables["KARTTAKIP"].DefaultView;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnDetayEkle_Click(object sender, RoutedEventArgs e)
        {
            Page2 p2 = new Page2();
            this.NavigationService.Navigate(p2);
        }

        //private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        //{
        //    Page2 p2 = new Page2();
        //    var item = sender as ListViewItem;
        //    if (item != null && item.IsSelected)
        //    {
        //        this.NavigationService.Navigate(p2);
        //    }
        //}
    }
}
