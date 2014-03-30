using System.Linq;

using Sandbox.HierarchicalFunctionalAreasWithNancyFX.Home.Products.Mens;
using Sandbox.HierarchicalFunctionalAreasWithNancyFX.Home.Products.Womens;

namespace Sandbox.HierarchicalFunctionalAreasWithNancyFX.Home.Products
{
    public abstract class ProductModel
    {
        static ProductModel[] _products;

        public static ProductModel[] Index
        {
            get
            {
                return _products ?? (_products = MensProductModel.Index
                                                                 .Concat(WomensProductModel.Index)
                                                                 .ToArray());
            }
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }

        public abstract string Category { get; }
    }
}