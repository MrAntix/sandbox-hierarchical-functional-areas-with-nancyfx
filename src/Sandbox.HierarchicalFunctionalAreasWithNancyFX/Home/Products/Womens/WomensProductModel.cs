namespace Sandbox.HierarchicalFunctionalAreasWithNancyFX.Home.Products.Womens
{
    public class WomensProductModel : ProductModel
    {
        public new static ProductModel[] Index
        {
            get
            {
                return new ProductModel[]
                    {
                        new WomensProductModel
                            {
                                Id = 1,
                                Name = "Red Shoe",
                                Description = "A lovely red shoe, perfect for putting on your foot",
                                Code = "RED-SHOE",
                                Price = 11.49M
                            },
                                                    new WomensProductModel
                            {
                                Id = 1,
                                Name = "Black Shoe",
                                Description = "A nice black dancing shoe, when you want to cut a rug",
                                Code = "BLACK-SHOE",
                                Price = 15.29M
                            }

                    };
            }
        }

        public override string Category
        {
            get { return "Womens"; }
        }
    }
}