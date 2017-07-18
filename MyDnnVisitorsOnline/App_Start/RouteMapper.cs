using DotNetNuke.Web.Api;

namespace MyDnn.VisitorsOnline
{
    public class RouteMapper : IServiceRouteMapper
    {
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {
            mapRouteManager.MapHttpRoute("MyDnnVisitorsOnline", "default", "{controller}/{action}", new[] { "MyDnn.VisitorsOnline.Services" });
        }
    }
}