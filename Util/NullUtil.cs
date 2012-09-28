using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Util
{
    public static class NullUtil
    {

        /// <summary>
        ///  Testa se um objeto é nulo
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Boolean IsNull(this object obj)
        {
            return obj == null;
        }

        /// <summary>
        /// Testa se uma string é nula ou vazia
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static Boolean IsNullOrEmpty(this String str)
        {
            return string.IsNullOrEmpty(str);
        }
    }
}
