namespace FlyrTechnicalEvaluation.Contract
{
    internal interface IProductConstructor
    {
        IProduct GetCoffee();
        IProduct GetGreenTea();
        IProduct GetStrawberries();
    }
}