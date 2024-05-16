namespace FlyrTechnicalEvaluation.Contract
{
    internal interface ICheckout
    {
        void Scan(IProduct product);

        decimal Total();

        int GetAmountOfGreenTeas();

        int GetAmountOfStrawberries();

        int GetAmountOfCoffees();
    }
}
