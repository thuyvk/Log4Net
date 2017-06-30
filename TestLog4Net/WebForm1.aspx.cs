using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestLog4Net
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                var x = "2x";
                var y = 2;
                int z = Convert.ToInt32(x) + Convert.ToInt32(y);
                
            }
            catch (Exception ms)
            {
                WriteLog.LogError(ms);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                var x = "2x";
                var y = 2;
                int z = Convert.ToInt32(x) + Convert.ToInt32(y);
            }
            catch(Exception ex)
            {
                WriteLog.LogWarning(ex);
            }
            
        }
    }
}