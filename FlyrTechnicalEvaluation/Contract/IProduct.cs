using FlyrTechnicalEvaluation.Enum;

namespace FlyrTechnicalEvaluation.Contract
{
    internal interface IProduct
    {
        ProductType GetProductType();
        decimal GetProductPrice();
        public int GetProductQuantity();
        void UpdatePrice(decimal newPrice);
        void AddProduct();
    }
}
