using Currency.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Globalization;

namespace Currency.Classes
{
    public class GetCurrency
    {
        DbCurrencyEntities db = new DbCurrencyEntities();
        public void SaveCurrencyDolar()
        {
            string url = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(url);
            string dolarAlis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            dolarAlis = dolarAlis.Replace(".", ",");
            string dolarSatis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            dolarSatis = dolarSatis.Replace(".", ",");
            TblCurrencyValue t = new TblCurrencyValue();
            t.CurrencyID = 1;
            t.CurrencyBuying = decimal.Parse(dolarAlis);
            t.CurrencySelling = decimal.Parse(dolarSatis);
            db.TblCurrencyValue.Add(t);
            db.SaveChanges();
        }
        public void SaveCurrencyEuro()
        {
            string url = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(url);
            string euroAlis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            euroAlis = euroAlis.Replace(".", ",");
            string euroSatis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            euroSatis = euroSatis.Replace(".", ",");
            TblCurrencyValue t = new TblCurrencyValue();
            t.CurrencyID = 2;
            t.CurrencyBuying = decimal.Parse(euroAlis);
            t.CurrencySelling = decimal.Parse(euroSatis);
            db.TblCurrencyValue.Add(t);
            db.SaveChanges();
        }
        public void SaveCurrencySterlin()
        {
            string url = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(url);
            string SterlinAlis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteBuying").InnerXml;
            SterlinAlis = SterlinAlis.Replace(".", ",");
            string SterlinSatis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;
            SterlinSatis = SterlinSatis.Replace(".", ",");
            TblCurrencyValue t = new TblCurrencyValue();
            t.CurrencyID = 4;
            t.CurrencyBuying = decimal.Parse(SterlinAlis);
            t.CurrencySelling = decimal.Parse(SterlinSatis);
            db.TblCurrencyValue.Add(t);
            db.SaveChanges();
        }
    }
}
