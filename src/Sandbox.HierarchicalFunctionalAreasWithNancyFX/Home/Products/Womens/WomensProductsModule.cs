using Sandbox.HierarchicalFunctionalAreasWithNancyFX.Nancy;

namespace Sandbox.HierarchicalFunctionalAreasWithNancyFX.Home.Products.Womens
{
    public class WomensProductsModule : FunctionalAreaModule
    {
        public WomensProductsModule()
        {
            Get["/"] = _ => View["Index", WomensProductModel.Index];
        }
    }
}