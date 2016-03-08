using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace RPCServer {
    /// <summary>
    /// Summary description for SoapService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SoapService : WebService {
        Random generator = new Random(200);

        [WebMethod]
        public void SOAPResetGenerator() {
            generator = new Random(200);
        }
        [WebMethod]
        public Int32 SOAPGetInteger() {
            return generator.Next();
        }
        [WebMethod]
        public Int32 SOAPGetZero() {
            return 0;
        }
        [WebMethod]
        public Int32[] SOAPGetIntegers(uint count) {
            Int32[] result = new Int32[count];
            for (uint i = 0; i < count; ++i)
                result[i] = generator.Next();

            return result;
        }
    }
}
