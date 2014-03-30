using Sandbox.HierarchicalFunctionalAreasWithNancyFX.Nancy;

namespace Sandbox.HierarchicalFunctionalAreasWithNancyFX.Home.Products.Mens
{
    public class MensProductsModule : FunctionalAreaModule
    {
        public MensProductsModule()
        {
            Get["/"] = _ => View["Index", MensProductModel.Index];
        }
    }
}