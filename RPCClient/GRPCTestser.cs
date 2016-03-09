using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Grpcservice;
using Grpc.Core;

namespace RPCClient {
    class GRPCTestser {
        static GRPCService.GRPCServiceClient _service = GRPCService.NewClient(new Channel("localhost", 52025, ChannelCredentials.Insecure));
        static string _testType = "GRPC";

        public static void TestAll(ref DataCollector collector) {
            TestGetZero(ref collector);
            TestGetInteger(ref collector);
            TestGetIntegers200(ref collector);
        }

        private static void TestGetZero(ref DataCollector collector) {
            DateTime counter = DateTime.Now;
            for (int i = 0; i < DataCollector.GetCount(); ++i)
                _service.GetZero(new Grpcservice.Void());
            collector.AddTest(new TestData(_testType + " GetZero", DateTime.Now.Subtract(counter)));
        }

        private static void TestGetInteger(ref DataCollector collector) {
            DateTime counter = DateTime.Now;
            for (int i = 0; i < DataCollector.GetCount(); ++i)
                _service.GetInteger(new Grpcservice.Void());
            collector.AddTest(new TestData(_testType + " GetInteger", DateTime.Now.Subtract(counter)));
        }

        private static void TestGetIntegers200(ref DataCollector collector) {
            DateTime counter = DateTime.Now;
            var val = new Value();
            val.Value_ = 200;
            for (int i = 0; i < DataCollector.GetCount(); ++i)
                _service.GetIntegers(val);
            collector.AddTest(new TestData(_testType + " GetIntegers200", DateTime.Now.Subtract(counter)));
        }
    }
}
