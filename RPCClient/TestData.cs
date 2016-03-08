using System;
using System.Collections.Generic;

namespace RPCClient {
    internal class TestData {
        internal string _testName;
        internal TimeSpan _testData;

        public TestData(string testName, TimeSpan timeSpan) {
            _testName = testName;
            _testData = timeSpan;
        }

        public void Display() {
            Console.WriteLine(_testName);
            Console.WriteLine(_testData);
        }
    }
}