using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EasyIngresso.WEB
{
    public partial class Login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ValidadorUsuario_ServerValidate(object source, ServerValidateEventArgs args)
        {
            try
            {

                var usuario = 0;// App_Start..AutenticarUsuario(txtUsuario.Text, txtSenha.Text);

                //App_Start.AuthenticationConfig.CreateCokie(usuario);

                HttpCookie cookie = new HttpCookie("usuario");

                cookie.Value = txtUsuario.Text;

                Response.Cookies.Add(cookie);

                args.IsValid = true;


            }
            catch (System.Exception ex)
            {

                args.IsValid = false;

                ValidadorUsuario.Text = ex.Message;
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                var paginaRedirecionamento = String.IsNullOrEmpty(Request.QueryString[PaginaAutenticada.PARAMETRO_URL_REDIRECT]) ? "/" : Request.QueryString[PaginaAutenticada.PARAMETRO_URL_REDIRECT];

                Response.Redirect(paginaRedirecionamento, true);

            }

        }
    }
}