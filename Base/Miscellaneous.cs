using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;

namespace Base
{
    public static class Miscellaneous
    {
        public static IEnumerable<string> ConvertCommaSeperatedStringToList(string commaSeperatedString)
        {
            try
            {
                string[] result = commaSeperatedString.Split(',');
                return result.ToList();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public static string ConvertListIntoCommaSeperatedString(ListItemCollection list)
        {
            try
            {
                string result = string.Empty;
                foreach (ListItem item in list)
                    if (item.Selected)
                        if (!string.IsNullOrWhiteSpace(result))
                            result = result + "," + item.Value;
                        else
                            result = item.Value;
                return result;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public static void ExportToExcel(Control webControl, string filename)
        {
            try
            {
                HttpContext.Current.Response.Clear();
                HttpContext.Current.Response.Buffer = true;
                HttpContext.Current.Response.AddHeader("content-disposition", "attachment;filename=" + filename + ".xls");
                HttpContext.Current.Response.Charset = "";
                HttpContext.Current.Response.ContentType = "application/vnd.ms-excel";
                StringWriter sWriter = new StringWriter();
                HtmlTextWriter hWriter = new HtmlTextWriter(sWriter);
                webControl.RenderControl(hWriter);
                HttpContext.Current.Response.Output.Write(sWriter.ToString());
                HttpContext.Current.Response.Flush();
                HttpContext.Current.Response.End();

            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public static string SerializeJsonData(object serializeJsonData)
        {
            try
            {
                return new JavaScriptSerializer().Serialize(serializeJsonData);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public static object DeserializeJsonData(string deSerializeJsonString)
        {
            try
            {
                return new JavaScriptSerializer().Deserialize<object>(deSerializeJsonString);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
