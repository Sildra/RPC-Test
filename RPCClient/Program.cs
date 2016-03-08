namespace RPCClient {
    class Program {
        static void Main(string[] args) {
            DataCollector collector = new DataCollector();

            SOAPTester.TestAll(ref collector);
            NativeTester.TestAll(ref collector);
            collector.DisplayAll();
        }
    }
}
