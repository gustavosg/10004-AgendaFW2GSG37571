using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Util;

namespace Data.Util
{
    public static class IntUtil
    {
        public static Int16 ConvertNullToInt16(this Int16? int16)
        {
            if (int16.IsNull())
                return 0;
            else
                return (Int16)int16;
        }

        public static Int16 ConvertStringToInt16(this String str)
        {
            if (str.IsNullOrEmpty())
                return Convert.ToInt16(0);
            else
                return Convert.ToInt16(str);
        }

        public static Boolean IsNullOrEmpty(this Int16? i)
        {
            if (i.IsNullOrEmpty())
                return true;
            else
                return false;
        }

    }
}
