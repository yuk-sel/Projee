using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projee.İşlemler
{
    public interface IToplamFiyat
    {
        decimal Ucret(List<NumericUpDown> miktar, Dictionary<string, decimal> fiyat);
    }
    public class ToplamFiyatHesaplayici : IToplamFiyat
    {
        public decimal Ucret(List<NumericUpDown> miktar, Dictionary<string, decimal> fiyat)
        {
            decimal toplamFiyat = 0;
            foreach (var numericUpDown in miktar)
            {
                string Ad = numericUpDown.Tag.ToString();
                decimal Fiyat = fiyat[Ad];
                decimal urunmiktar = numericUpDown.Value;
                toplamFiyat += Fiyat * urunmiktar;
            }
            return toplamFiyat;
        }
    }
}