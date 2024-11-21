using Projee.Giriş_Sayfası;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projee.İşlemler
{
    public interface IFisGoster
    {
        string FisGoster(List<NumericUpDown> miktar, Dictionary<string, decimal> fiyat);
    }
    public class Goster : IFisGoster
    {
        private Dictionary<NumericUpDown, string> numericUpDownValues = new Dictionary<NumericUpDown, string>();
        public string FisGoster(List<NumericUpDown> miktar, Dictionary<string, decimal> fiyat)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var numericUpDown in miktar)
            {
                string Ad = numericUpDown.Tag.ToString();
                decimal Fiyat = fiyat[Ad];
                decimal urunmiktar = numericUpDown.Value;

                if (urunmiktar != 0)
                {
                    string labelText = $"{Ad}: {Fiyat} * {urunmiktar} = {Fiyat * urunmiktar}";
                    //  AnaSayfa anaSayfa = new AnaSayfa(); 
                    stringBuilder.AppendLine(labelText);

                    if (numericUpDownValues.ContainsKey(numericUpDown))
                    {
                        numericUpDownValues[numericUpDown] = labelText;
                    }
                    else
                    {
                        numericUpDownValues.Add(numericUpDown, labelText);
                    }

                }
            }

            return stringBuilder.ToString();
        }
    }

}