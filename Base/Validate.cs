using System;

namespace Base
{
    public static class Validate
    {
        public static bool IsNumeric(string value)
        {
            try
            {
                int outValue;
                if (int.TryParse(value, out outValue))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool IsDate(string value)
        {
            try
            {
                DateTime outValue;
                if (DateTime.TryParse(value, out outValue))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool IsGuid(string value)
        {
            try
            {
                Guid outValue;
                if (Guid.TryParse(value, out outValue))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
