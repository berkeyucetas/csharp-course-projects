using Currency.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.Classes
{
    public class SaleOperation
    {
       public void CustomerSaleOperationAlis()
        {
            DbCurrencyEntities db = new DbCurrencyEntities();
            var values = db.TblOperation.Where(x=>x.CurrencyType=="alış").ToList();
            foreach (var item in values)
            {
                Console.WriteLine("ID: "+item.ID+ "||  Müşteri: "+ item.CustomerName+" "+item.CustomerSurname+ "||  Döviz: "+ item.TblCurrency.CurrencyName+ "||  İşlem Türü: "+ item.CurrencyType+ "||  Kur Birim Tutarı: " + item.CurrentCurrencyValue+ "||  Alınan Tutar: "+ item.CurencyAmount+ "||  Toplam Tutar: "+ item.TotalPrice);

            }
        }
        public void CustomerSaleOperationSatis()
        {
            DbCurrencyEntities db = new DbCurrencyEntities();
            var values = db.TblOperation.Where(x => x.CurrencyType == "satış").ToList();
            foreach (var item in values)
            {
                Console.WriteLine("ID: " + item.ID + "||  Müşteri: " + item.CustomerName + " " + item.CustomerSurname + "||  Döviz: " + item.TblCurrency.CurrencyName + "||  İşlem Türü: " + item.CurrencyType + "||  Kur Birim Tutarı: " + item.CurrentCurrencyValue + "||  Alınan Tutar: " + item.CurencyAmount + "||  Toplam Tutar: " + item.TotalPrice);

            }
        }
    }
}
