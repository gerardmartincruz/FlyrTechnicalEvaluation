using FlyrTechnicalEvaluation.Contract;

namespace FlyrTechnicalEvaluation.Utility
{
    internal class PricingRules : IPricingRules
    {
        public void ApplyOffer(IProduct products)
        {

            switch (products.GetProductType())
            {
                case Enum.ProductType.GreenTea:
                    GreenTeaOffer(products);
                    break;

                case Enum.ProductType.Strawberry:
                    StrawberriesOffer(products);
                    break;

                case Enum.ProductType.Coffee:
                    CoffeeOffer(products);
                    break;

                default:
                    throw new Exception("the offer does not exist");
            }
        }

        private void GreenTeaOffer(IProduct products)
        {
            var initialAmountOfGreenTea = products.GetProductQuantity();
            for (var i = 0; i < initialAmountOfGreenTea; i++)
            {
                products.AddProduct();
            }

            products.UpdatePrice(products.GetProductPrice()/2m);
        }

        private void StrawberriesOffer(IProduct products)
        {
            if (products.GetProductQuantity() < 3)
            {
                return;
            }

            products.UpdatePrice(4.50m);
        }

        private void CoffeeOffer(IProduct products)
        {
            if (products.GetProductQuantity() < 3)
            {
                return;
            }

            products.UpdatePrice(products.GetProductPrice() * (2m/3m));
        }
    }
}
