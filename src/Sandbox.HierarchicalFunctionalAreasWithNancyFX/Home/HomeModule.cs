
using Sandbox.HierarchicalFunctionalAreasWithNancyFX.Nancy;

namespace Sandbox.HierarchicalFunctionalAreasWithNancyFX.Home
{
    public class HomeModule:FunctionalAreaModule
    {
        public HomeModule()
        {
            Get["/"] = _ => View["Index"];
        }         
    }
}