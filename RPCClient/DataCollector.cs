using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPCClient {
    class DataCollector {
        const int count = 1000;
        List<TestData> _tests = new List<TestData>();

        static internal int GetCount() {
            return count;
        }

        internal void DisplayAll() {
            foreach (TestData data in _tests)
                data.Display();
        }

        internal void AddTest(TestData test) {
            _tests.Add(test);
        }
    }
}
