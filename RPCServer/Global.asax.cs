#define HELP_ME_LOCATE_THE_FOLDER

using Grpc.Core;
using Grpcservice;
using System;

namespace RPCServer {
    public class Global : System.Web.HttpApplication {
        // Because IIS is started in a folder like AppData\Local\Temp\Temporary ASP.NET Files\vs\0bc8bb81\2d2cdba0\assembly\dl3\d66cac4f\56191226_a077d101
        // and GRPC loads the grpc_csharp_ext.dll dynamically from its location, you might want to catch the exception
#if HELP_ME_LOCATE_THE_FOLDER
        static Server server;
#else
        static Server server = new Server {
            Services = { GRPCService.BindService(new GRPCServiceImpl()) },
            Ports = { new ServerPort("127.0.0.1", 52025, ServerCredentials.Insecure) }
        };
#endif

        protected void Application_Start(object sender, EventArgs e) {
#if HELP_ME_LOCATE_THE_FOLDER
            try {
                server = new Server {
                    Services = { GRPCService.BindService(new GRPCServiceImpl()) },
                    Ports = { new ServerPort("127.0.0.1", 52025, ServerCredentials.Insecure) }
                };
            } catch (Exception ex) {
                // Throw the exception with the complete message (FileNotFoundException is not enough)
                // The folder is reset on build so comment the define then build the server then copy the DLL
                string val = ex.ToString();
                throw new Exception(val);
            }
#endif

            server.Start();
        }

        protected void Application_End(object sender, EventArgs e) {
            server.ShutdownAsync().Wait();
        }

        protected void Session_Start(object sender, EventArgs e) {

        }

        protected void Application_BeginRequest(object sender, EventArgs e) {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e) {

        }

        protected void Application_Error(object sender, EventArgs e) {

        }

        protected void Session_End(object sender, EventArgs e) {

        }
    }
}
