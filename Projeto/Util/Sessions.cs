using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using Dominio.Models;
using Projeto.Models;

namespace Projeto.Util
{
    public class Sessions
    {
        public static Usuario Usuario
        {
            get { return (Usuario)HttpContext.Current.Session["usuario"]; }
            set { HttpContext.Current.Session["usuario"] = value; }
        }
    }
}