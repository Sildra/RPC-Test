namespace RPCClient {
    class Program {
        static void Main(string[] args) {
            DataCollector collector = new DataCollector();
            
            GRPCTestser.TestAll(ref collector);
            SOAPTester.TestAll(ref collector);
            NativeTester.TestAll(ref collector);
            collector.DisplayAll();
        }
    }
}
