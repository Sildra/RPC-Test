using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPCClient {
    class NativeService {
        public int GetZero() {
            return 0;
        }
    }

    class NativeTester {
        static NativeService _service = new NativeService();
        static string _testType = "Native";

        public static void TestAll(ref DataCollector collector) {
            TestGetZero(ref collector);
        }

        private static void TestGetZero(ref DataCollector collector) {
            DateTime counter = DateTime.Now;
            for (int i = 0; i < DataCollector.GetCount(); ++i)
                _service.GetZero();
            collector.AddTest(new TestData(_testType + " GetZero", DateTime.Now.Subtract(counter)));
        }
    }
}
