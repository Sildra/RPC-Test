using System.Threading.Tasks;
using Grpcservice;
using Grpc.Core;
using System;

namespace RPCServer {
    public class GRPCServiceImpl : GRPCService.IGRPCService {
        Random generator = new Random(200);

        public Task<Value> GetZero(Grpcservice.Void request, ServerCallContext context) {
            Value val = new Value();
            val.Value_ = 0;
            return Task.FromResult(val);
        }
        public Task<Value> GetInteger(Grpcservice.Void request, ServerCallContext context) {
            Value val = new Value();
            val.Value_ = generator.Next();
            return Task.FromResult(val);
        }

        public Task<Values> GetIntegers(Value request, ServerCallContext context) {
            Values val = new Values();
            for (int i = 0; i < request.Value_; ++i)
                val.Value.Add(generator.Next());
            return Task.FromResult(val);
        }

    }
}