using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Util
{
    public static class IntUtil
    {
        public static Int16 ConvertNullToInt16(this Int16 i)
        {
            if (i == null)
                return 0;
            else
                return i;
        }

        public static Int16 ConvertStringToInt16(this String s)
        {
            if (s.IsNullOrEmpty())
                return Convert.ToInt16(0);
            else
                return Convert.ToInt16(s);
        }

        public static Boolean IsNullOrEmpty(this Int16 i)
        {
            if (i == null)
                return true;
            else
                return false;
        }

    }
}
