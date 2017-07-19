using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppDemo.forms
{
    public partial class contact_action : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            alertMessage.InnerHtml = $"{Request.Form["name"]} {Request.Form["family"]} پیام شما برای دپارتمان {Request.Form["Department"]} ارسال شد.";
        }
    }
}