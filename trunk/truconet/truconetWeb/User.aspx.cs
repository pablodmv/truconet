﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
    using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace truconetWeb
{
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCartas_Click(object sender, EventArgs e)
        {
            truconetFachada.truconetFachada ws = new truconetFachada.truconetFachada();
            this.TextBox1.Text= ws.holaPablo();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
