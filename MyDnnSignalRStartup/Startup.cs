using Microsoft.Owin;
using MyDnn.SignalRStartup;
using Owin;


[assembly: OwinStartup("MyDnnOwinStartupForSignalR", typeof(Startup))]
namespace MyDnn.SignalRStartup
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}