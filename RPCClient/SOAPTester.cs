using RPCClient.SoapService;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPCClient {
    class SOAPTester {
        static SoapServiceSoapClient _service = new SoapService.SoapServiceSoapClient();

        public static void TestAll(ref DataCollector collector) {
            TestGetZero(ref collector);
            TestGetInteger(ref collector);
            TestGetIntegers200(ref collector);
        }

        private static void TestGetZero(ref DataCollector collector) {
            DateTime counter = DateTime.Now;
            for (int i = 0; i < DataCollector.GetCount(); ++i)
                _service.SOAPGetZero();
            collector.AddTest(new TestData("SOAP GetZero", DateTime.Now.Subtract(counter)));
        }

        private static void TestGetInteger(ref DataCollector collector) {
            DateTime counter = DateTime.Now;
            for (int i = 0; i < DataCollector.GetCount(); ++i)
                _service.SOAPGetInteger();
            collector.AddTest(new TestData("SOAP GetInteger", DateTime.Now.Subtract(counter)));
        }

        private static void TestGetIntegers200(ref DataCollector collector) {
            DateTime counter = DateTime.Now;
            for (int i = 0; i < DataCollector.GetCount(); ++i)
                _service.SOAPGetIntegers(200);
            collector.AddTest(new TestData("SOAP GetIntegers200", DateTime.Now.Subtract(counter)));
        }
    }
}
