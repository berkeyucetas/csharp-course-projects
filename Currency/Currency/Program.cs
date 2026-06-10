using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Currency.Classes;
using Currency.Model;
using System.Globalization;

namespace Currency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            DbCurrencyEntities db = new DbCurrencyEntities();
            SaleCurrency sale = new SaleCurrency();
            void CurrencyList()
            {
                Console.WriteLine(" ");
                Console.WriteLine("     Döviz Listesi");
                var values = db.TblCurrency.ToList();
                foreach (var item in values)
                {
                    Console.WriteLine(item.ID + " " + item.CurrencyName + " " + item.CurrencySymbol);
                }
            }
            void CurrentCurrency()
            {
                Console.WriteLine(" ");
                Console.WriteLine("     Güncel Kur Listesi");
                Console.WriteLine(" ");
                var values = db.TblCurrencyValue.ToList();
                foreach (var item in values)
                {
                    Console.WriteLine("Döviz: "+ item.TblCurrency.CurrencyName+ "||   Alış: "+ item.CurrencyBuying+ "||   Satış: "+ item.CurrencySelling);
                }
            }
            
            void GetCurrencyClasses()
            {
                GetCurrency getCurrency = new GetCurrency();
                getCurrency.SaveCurrencyDolar();
                getCurrency.SaveCurrencyEuro();
                getCurrency.SaveCurrencySterlin();
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("   DÖVİZ İŞLEMLERiNE HOŞGELDİNİZ   ");
            Console.WriteLine(" ");
            Console.WriteLine("MevcutKullanıcı: Admin "+"     Tarih: " +DateTime.Now.ToShortDateString());
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz: ");
            Console.WriteLine(" ");
            Console.WriteLine(" 1- Döviz Listesi");
            Console.WriteLine(" 2- Güncel Kurlar ");
            Console.WriteLine(" 3- Satış Yap");
            Console.WriteLine(" 4- Alış Hareketleri");
            Console.WriteLine(" 5- Satış Hareketleri");
            Console.WriteLine(" 6- Kurları Veritabanına Kaydet");
            Console.WriteLine(" 7- Yardım");
            Console.WriteLine(" 8- Çıkış Yap");
            Console.WriteLine(" ");
            Console.Write("Yapmak İstediğiniz İşlem Numarasını Giriniz:  ");


            string choose;
            choose=Console.ReadLine();
            if(choose=="1" || choose == "01")
            { CurrencyList(); }
            if (choose == "2"||choose=="02")
            { CurrentCurrency(); }
            if (choose == "3" || choose == "03")
            {   Console.WriteLine();
                Console.WriteLine("Müşteri Adı: ");
                string customerName = Console.ReadLine();
                Console.WriteLine("Müşteri Soyadı: ");
                string customerSurname = Console.ReadLine();
                Console.WriteLine("Döviz Kodu: ");
                int currencyCode = int.Parse(Console.ReadLine());
                Console.WriteLine("İşlem Türü: ");
                string operationtype = Console.ReadLine();
                Console.WriteLine("Güncel Kur Değeri: ");
                decimal currentValues = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Alınacak Tutar: ");
                decimal amount = decimal.Parse(Console.ReadLine());
                decimal totalPrice = currentValues * amount;

                Console.WriteLine("Toplam Ücret: " + totalPrice);

                sale.MakeSale(customerName,customerSurname,currencyCode,operationtype,currentValues,amount,totalPrice);
            }
            if (choose == "4" || choose == "04")
            { 
                SaleOperation saleOperation= new SaleOperation();
                saleOperation.CustomerSaleOperationAlis();
            }
            if (choose == "5" || choose == "05")
            {
                SaleOperation saleOperation = new SaleOperation();
                saleOperation.CustomerSaleOperationSatis();
            }
            if (choose == "6" || choose == "06")
            { GetCurrencyClasses();
                Console.WriteLine("Döviz başarılıyla veritabanına kaydedildi");
            }


            Console.ReadLine();





        }
    }
}
