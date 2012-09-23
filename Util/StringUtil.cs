using System;
using System.Web;

namespace Data.Util
{
    public static class StringUtil
    {
        public static String ConvertInt16ToString(this Int16 i)
        {
            if (i.IsNullOrEmpty())
                return String.Empty;
            else
                return Convert.ToString(i);
        }

        /// <summary>
        /// Verifica se campo informado é vazio ou não
        /// </summary>
        /// <param name="s"></param>
        /// <returns>Valor booleano</returns>
        public static Boolean IsNullOrEmpty(this String s)
        {
            if (s == null)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Converte texto nulo para formato string
        /// </summary>
        /// <param name="s"></param>
        /// <returns>Retorna string</returns>
        public static String ConvertNullToString(this String s)
        {
            if (s.IsNullOrEmpty())
                return String.Empty;
            else
                return s;
        }

        /// <summary>
        /// Converte assinatura passada para texto decodificado de html
        /// </summary>
        /// <param name="s"></param>
        /// <returns>String em formato legível</returns>
        public static String ConvertStringToHTMLDecode(this String s)
        {
            if (s.IsNullOrEmpty())
                return s.ConvertNullToString();
            else
                return HttpUtility.HtmlDecode(s);
        }

    }
}
