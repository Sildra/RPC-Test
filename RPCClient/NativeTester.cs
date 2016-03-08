using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPCClient {
    class NativeTester {
        public static void TestAll(ref DataCollector collector) {
            TestGetZero(ref collector);
        }

        private static void TestGetZero(ref DataCollector collector) {
            DateTime counter = DateTime.Now;
            for (int i = 0; i < DataCollector.GetCount(); ++i)
                NativeGetZero();
            collector.AddTest(new TestData("Native GetZero", DateTime.Now.Subtract(counter)));
        }

        private static int NativeGetZero() {
            return 0;
        }
    }
}
