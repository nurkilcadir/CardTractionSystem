using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication17
{
    public class HomeBusinessLogic  
    {
        public static void SaveInfo(string vbMusteri, string txtAd, string txtAdiki, string txtSoyad, string txtKartNo, string cbxİslem,
            string cbxKurye, string txtUrunKod, string cbxKTipi, string kayitTarih, string teslimTarih, string kuryeTarih, string bsMüsteri, string barkod, string tcNo,
            string txtSube, string txtUrunAd, string txtBayi, string cbxSozlesme, string basimTarih, string iadeTarih)  
        {  
            try  
            {  
                string query = "INSERT INTO KARTTAKIP (VBMUSTERINO,AD,IKINCIAD,SOYAD,KARTNO,ISLEMKODU,URUNKOD,KURYEKODU,KARTTURU,KAYITTARIHI,TESLIMTARIHI,KURYETARIHI,BSMUSTERINO,BARKOD,TCNO,SUBEKODU,URUNADI,BAYIKODU,SOZLESMEDURUM,BASIMTARIHI,IADETARIH)" +
                                    " Values ('" + vbMusteri + "','" + txtAd + "','" + txtAdiki + "','" + txtSoyad + "','" + txtKartNo + "','" + cbxİslem + "','" + txtUrunKod + "','" + cbxKurye + "','" + cbxKTipi + "','" + kayitTarih + "','" + teslimTarih + "','" + kuryeTarih + "','" + bsMüsteri + "','" + barkod + "','" + tcNo + "','" + txtSube + "','" + txtUrunAd + "','" + txtBayi + "','" + cbxSozlesme + "','" + basimTarih + "','" + iadeTarih + "')";     
                DAL.executeQuery(query);
            }  
            catch (Exception ex)  
            {  
                throw ex;  
            }  
        }
        public static void DetaySave(string kartId,string Islemkodu,string kayittarihi,string kayitusercode,string kayitkanalkodu,string islemaciklama)
        {
            try
            {
                string query = "INSERT INTO KURYETAKIP (KARTID,ISLEMKODU,KAYITTARIHI,KAYITUSERCODE,KAYITKANALKODU,ISLEMACIKLAMASI)" +
                                    " Values ('" + kartId + "','" + Islemkodu + "','" + kayittarihi + "','" + kayitusercode + "','" + kayitkanalkodu + "','" + islemaciklama + "')";
                DAL.executeQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }  
        }
    }
}
