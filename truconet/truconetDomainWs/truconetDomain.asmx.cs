using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;

namespace truconetDomainWs
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://truconet/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class truconetDomain : System.Web.Services.WebService
    {

        [WebMethod]
        public string crearPartido()
        {
            string retorno=""; 
            truconet.Truco aux= truconet.Truco.getInstance();

            foreach (truconet.Carta card in aux.Maso)
            {
                retorno += " " + card.ToString();
                
            }
            return retorno;
             
        }
    }
}
