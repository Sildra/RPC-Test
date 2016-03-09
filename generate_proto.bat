packages\Google.Protobuf.3.0.0-beta2\tools\protoc.exe -Iprotos --csharp_out GRPCService --grpc_out GRPCService --plugin=protoc-gen-grpc=packages\Grpc.Tools.0.13.0\tools\grpc_csharp_plugin.exe protos\service.proto
pause
