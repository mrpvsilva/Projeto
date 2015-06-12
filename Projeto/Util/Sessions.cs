using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using Projeto.Models;

namespace Projeto.Util
{
    public class Sessions
    {
        public static UsuarioViewModel Usuario
        {
            get { return (UsuarioViewModel)HttpContext.Current.Session["usuario"]; }
            set { HttpContext.Current.Session["usuario"] = value; }
        }
    }
}