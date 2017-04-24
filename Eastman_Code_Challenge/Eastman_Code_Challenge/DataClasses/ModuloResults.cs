using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eastman_Code_Challenge
{
    public class ModuloResults : ObjectBase
    {
        private string _Modulo = "";


        public string Modulo
        {
           get { return _Modulo; }
           set
           {
               if (_Modulo != value)
             {
                 _Modulo = value;
               RaisePropertyChanged("Modulo");
             }
           }
        }
    }
}
