using DotNetNuke.Web.Api;

namespace MyDnn.Modules.Support.LiveChat
{
    public class RouteMapper : IServiceRouteMapper
    {
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {
            mapRouteManager.MapHttpRoute("MyDnnSupport.LiveChat", "default", "{controller}/{action}", new[] { "MyDnn.Modules.Support.LiveChat" });
        }
    }
}