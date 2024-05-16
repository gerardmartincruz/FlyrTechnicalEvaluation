using FlyrTechnicalEvaluation.Contract;
using FlyrTechnicalEvaluation.Enum;

namespace FlyrTechnicalEvaluation.Utility
{
    internal class Product : IProduct
    {
        private ProductType ProductType;
        private decimal _price;
        private int _quantity;
        public Product(ProductType productType, decimal price)
        {
            ProductType = productType;
            _price = price;
            _quantity = 1;
        }

        public void AddProduct()
        {
            _quantity++;
        }

        public decimal GetProductPrice()
        {
            return _price;
        }

        public int GetProductQuantity()
        {
            return _quantity;
        }

        public ProductType GetProductType()
        {
            return ProductType;
        }

        public void UpdatePrice(decimal newPrice)
        {
            _price = newPrice;
        }
    }
}
