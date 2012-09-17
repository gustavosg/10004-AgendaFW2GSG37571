using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Util;

namespace Data.Models
{
    public class LocaisM : Singleton<LocaisM>
    {

        #region Properties

        public Int16 id { get; set; }
        public String nome { get; set; }

        #endregion

        #region Methods

        public void InserirBD()
        {
            
        }

        #endregion

    }
}
