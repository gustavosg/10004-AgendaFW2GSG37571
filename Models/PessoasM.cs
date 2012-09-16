using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Util;

namespace Data.Models
{
    public class PessoasM : Singleton<PessoasM>
    {

        #region Properties

        public Int16 id { get; set; }
        public String nome { get; set; }
        public Char sexo { get; set; }
        public Int16 idade { get; set; }

        #endregion


    }
}
