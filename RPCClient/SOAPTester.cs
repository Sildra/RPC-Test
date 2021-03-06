﻿using RPCClient.SoapService;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPCClient {
    class SOAPTester {
        static SoapServiceSoapClient _service = new SoapService.SoapServiceSoapClient();
        static string _testType = "SOAP";

        public static void TestAll(ref DataCollector collector) {
            TestGetZero(ref collector);
            TestGetInteger(ref collector);
            TestGetIntegers200(ref collector);
        }

        private static void TestGetZero(ref DataCollector collector) {
            DateTime counter = DateTime.Now;
            for (int i = 0; i < DataCollector.GetCount(); ++i)
                _service.GetZero();
            collector.AddTest(new TestData(_testType + " GetZero", DateTime.Now.Subtract(counter)));
        }

        private static void TestGetInteger(ref DataCollector collector) {
            DateTime counter = DateTime.Now;
            for (int i = 0; i < DataCollector.GetCount(); ++i)
                _service.GetInteger();
            collector.AddTest(new TestData(_testType + " GetInteger", DateTime.Now.Subtract(counter)));
        }

        private static void TestGetIntegers200(ref DataCollector collector) {
            DateTime counter = DateTime.Now;
            for (int i = 0; i < DataCollector.GetCount(); ++i)
                _service.GetIntegers(200);
            collector.AddTest(new TestData(_testType + " GetIntegers200", DateTime.Now.Subtract(counter)));
        }
    }
}
