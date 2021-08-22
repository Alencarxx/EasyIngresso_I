using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace EasyIngresso.WEB
{
    public class PaginaAutenticada : Page
    {
        public const string PARAMETRO_URL_REDIRECT = "redirectUrl";

        protected void Page_Init(object sender, EventArgs e)
        {
            if (HttpContext.Current.User == null || String.IsNullOrEmpty(HttpContext.Current.User.Identity.Name))
            {
                Response.Redirect($"{System.Web.Security.FormsAuthentication.LoginUrl}?{PaginaAutenticada.PARAMETRO_URL_REDIRECT}={this.Request.Url.AbsolutePath}", true);
            }
        }
    }
}