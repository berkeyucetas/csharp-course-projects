using Currency.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.Classes
{
    public class SaleCurrency
    {
        DbCurrencyEntities db = new DbCurrencyEntities();
        public void MakeSale(string customerName, string customerSurname, int currencyCode, string operationtype, decimal currentValues, decimal amount, decimal totalPrice)
        {
            TblOperation t=new TblOperation();
            t.CustomerName= customerName;
            t.CustomerSurname= customerSurname;
            t.CurrencyID= currencyCode;
            t.CurrencyType= operationtype;
            t.CurrentCurrencyValue= currentValues;
            t.CurencyAmount= amount;
            t.TotalPrice= totalPrice;
            t.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblOperation.Add(t);
            db.SaveChanges();
            Console.WriteLine("Satış İşlemi Başarılı Bir Şekilde Gerçekleştirildi");



        }
    }
}
