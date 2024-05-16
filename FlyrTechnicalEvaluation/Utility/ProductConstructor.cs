using FlyrTechnicalEvaluation.Contract;
using FlyrTechnicalEvaluation.Enum;

namespace FlyrTechnicalEvaluation.Utility
{
    internal class ProductConstructor : IProductConstructor
    {
        public IProduct GetGreenTea()
        {
            return new Product(ProductType.GreenTea, 3.11m);
        }

        public IProduct GetStrawberries()
        {
            return new Product(ProductType.Strawberry, 5.00m);
        }

        public IProduct GetCoffee()
        {
            return new Product(ProductType.Coffee, 11.23m);
        }
    }
}
