using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projee.İşlemler
{
    public interface IFormGoster
    {
        string FormSakla(List<Form> forms);

    }
    public class FormSakla : IFormGoster
    {
        string IFormGoster.FormSakla(List<Form> forms)
        {
            throw new NotImplementedException();
        }
    }
}