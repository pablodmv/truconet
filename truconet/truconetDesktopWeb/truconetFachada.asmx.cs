using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;

namespace truconetDesktopWeb
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://truconet/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class truconetFachada : System.Web.Services.WebService
    {
        
        [WebMethod]
        public string holaPablo()
        {
            //ArrayList aux = new ArrayList();
            truconetDomain.truconetDomain ws = new truconetDomain.truconetDomain();
            return ws.crearPartido();
        }
    }
}
