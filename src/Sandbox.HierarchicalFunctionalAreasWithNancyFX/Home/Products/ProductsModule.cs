using Sandbox.HierarchicalFunctionalAreasWithNancyFX.Nancy;

namespace Sandbox.HierarchicalFunctionalAreasWithNancyFX.Home.Products
{
    public class ProductsModule : FunctionalAreaModule
    {
        public ProductsModule()
        {
            Get["/"] = _ => View["Index", ProductModel.Index];
        }
    }
}