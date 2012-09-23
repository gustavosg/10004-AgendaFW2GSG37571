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

        public static Boolean IsNullOrEmpty(this Int16 i)
        {
            if (i == null)
                return true;
            else
                return false;
        }

    }
}
