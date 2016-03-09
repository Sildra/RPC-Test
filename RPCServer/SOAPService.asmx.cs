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
        public void ResetGenerator() {
            generator = new Random(200);
        }
        [WebMethod]
        public int GetInteger() {
            return generator.Next();
        }
        [WebMethod]
        public int GetZero() {
            return 0;
        }
        [WebMethod]
        public int[] GetIntegers(uint count) {
            int[] result = new int[count];
            for (uint i = 0; i < count; ++i)
                result[i] = generator.Next();

            return result;
        }
    }
}
