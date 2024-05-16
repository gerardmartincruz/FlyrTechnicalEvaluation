using FlyrTechnicalEvaluation.Utility;

Console.WriteLine("Hello Everyone!\r\n\r\n");
var productConstructor = new ProductConstructor();

var shoppingExperience = true;

while (shoppingExperience)
{
    var buyingProcess = true;
    var checkout = new Checkout(new PricingRules());

    while (buyingProcess)
    {
        Console.WriteLine("Please choose what product you want to add to your cart 1 for Green Tea, 2 for Strawberries or 3 for Coffe. If you want to checkout your order write 0\r\n");
        var product = Console.ReadLine();

        switch (product)
        {
            case "0":
                buyingProcess = false;
                break;

            case "1":
                checkout.Scan(productConstructor.GetGreenTea());
                break;

            case "2":
                checkout.Scan(productConstructor.GetStrawberries());
                break;

            case "3":
                checkout.Scan(productConstructor.GetCoffee());
                break;

            default:
                Console.WriteLine("I did not understood you please choose 1, 2, 3 or 0 only");
                break;
        }
    }

    Console.WriteLine($"Congratulations! For a total amount of {checkout.Total().ToString("0.00")}£ you will receive {checkout.GetAmountOfGreenTeas()} green teas, {checkout.GetAmountOfStrawberries()} strawberries and {checkout.GetAmountOfCoffees()} Coffees");
    var exit = false;
    while (!exit)
    {
        Console.WriteLine("do you want to continue? Y/N");
        var answer = Console.ReadLine();
        switch(answer)
        {
            case "y":
            case "Y":
                exit = true;
                Console.WriteLine("We've cleaned your cart, so you are starting all over again.\r\n");
                break;

            case "n":
            case "N":
                exit = true;
                shoppingExperience = false;
                break;

            default:
                Console.WriteLine("I did not understood you please choose Y to start again or N to quit");
                break;
        }
    }
 
}