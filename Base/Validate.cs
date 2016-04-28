using System;

namespace Base
{
    public static class Validate
    {
        public static bool IsNumeric(string value)
        {
            int outValue;
            if (int.TryParse(value, out outValue))
                return true;
            else
                return false;
        }

        public static bool IsDate(string value)
        {
            DateTime outValue;
            if (DateTime.TryParse(value, out outValue))
                return true;
            else
                return false;
        }

        public static bool IsGuid(string value)
        {
            Guid outValue;
            if (Guid.TryParse(value, out outValue))
                return true;
            else
                return false;
        }       
    }
}
