namespace Sandbox.HierarchicalFunctionalAreasWithNancyFX.Home.Products.Mens
{
    public class MensProductModel : ProductModel
    {
        public new static ProductModel[] Index
        {
            get
            {
                return new ProductModel[]
                    {
                        new MensProductModel
                            {
                                Id = 1,
                                Name = "Black Shoe",
                                Description = "A handsome black shoe for wearing inside and out",
                                Code = "BLACK-SHOE",
                                Price = 10.99M
                            }
                    };
            }
        }

        public override string Category
        {
            get { return "Mens"; }
        }
    }
}