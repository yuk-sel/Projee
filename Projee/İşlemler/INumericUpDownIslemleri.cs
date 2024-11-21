using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projee.İşlemler
{
    public interface INumericUpDownIslemleri
    {
        void NudTagAtama(List<NumericUpDown> miktar, Dictionary<string, decimal> fiyat);
        void NudDegerDegistirme(List<NumericUpDown> miktar, EventHandler handler);
    }

    public class TagAtama : INumericUpDownIslemleri
    {
        private EventHandler Numericupdown_ValueChanged;

        public void NudTagAtama(List<NumericUpDown> miktar, Dictionary<string, decimal> fiyat)
        {
            int i = 0;
            foreach (var menuIsimleri in fiyat.Keys)
            {
                if (i < miktar.Count)
                {
                    miktar[i].Tag = menuIsimleri;
                    i++;
                }
            }

        }
        public void NudDegerDegistirme(List<NumericUpDown> miktar, EventHandler handler)
        {
            Numericupdown_ValueChanged = handler;
            foreach (var miktarlari in miktar)
            {

                miktarlari.ValueChanged += Numericupdown_ValueChanged;
            }
        }
    }
}