using FlyrTechnicalEvaluation.Contract;
using FlyrTechnicalEvaluation.Enum;

namespace FlyrTechnicalEvaluation.Utility
{
    internal class Checkout : ICheckout
    {
        private ICollection<IProduct> _products;
        private IPricingRules _rules;

        public Checkout(IPricingRules rules)
        {
            _products = new List<IProduct>();
            _rules = rules;
        }

        public void Scan(IProduct product)
        {
            var productExists = _products.Where(internalproduct => internalproduct.GetProductType() == product.GetProductType()).FirstOrDefault();
            if (productExists != null)
            {
                productExists.AddProduct();
                return;
            }
            _products.Add(product);
        }

        public decimal Total()
        {
            ApplyOffers();
            return _products.Sum(product => product.GetProductPrice() * product.GetProductQuantity());
        }

        public int GetAmountOfGreenTeas()
        {
            var greanTeas = _products.Where(product => product.GetProductType() == ProductType.GreenTea).SingleOrDefault();
            if (greanTeas != null)
            {
                return greanTeas.GetProductQuantity();
            }

            return 0;
        }
        
        public int GetAmountOfStrawberries()
        {
            var strawberrys = _products.Where(product => product.GetProductType() == ProductType.Strawberry).SingleOrDefault();
            if (strawberrys != null)
            {
                return strawberrys.GetProductQuantity();
            }

            return 0;
        }
        
        public int GetAmountOfCoffees()
        {
            var coffee = _products.Where(product => product.GetProductType() == ProductType.Coffee).SingleOrDefault();
            if (coffee != null)
            {
                return coffee.GetProductQuantity();
            }

            return 0;
        }

        private void ApplyOffers()
        {
            foreach (var product in _products)
            {
                _rules.ApplyOffer(product);
            }
        }
    }
}
