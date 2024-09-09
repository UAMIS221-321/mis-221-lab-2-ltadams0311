class Program
{
    static void Main()
    {
        const double sandwichCost = 4.75;
        const double toppingCost = 0.55;
        const double discount = 0.10;

        Console.Write("How many sandwiches? ");
        int numberOfSandwiches = int.Parse(Console.ReadLine());

        Console.Write("How many total toppings? ");
        int numberOfToppings = int.Parse(Console.ReadLine());

        Console.Write("What is the tip? (Write in decimal form) ");
        double tipPercentage = double.Parse(Console.ReadLine());

        double totalSandwichCost = numberOfSandwiches * sandwichCost;
        double totalToppingCost = numberOfToppings * toppingCost;
        double baseCost = totalSandwichCost + totalToppingCost;
        double discountAmount = baseCost * discount;
        double discountedCost = baseCost - discountAmount;
        double tipAmount = discountedCost * tipPercentage;
        double finalOrderCost = discountedCost + tipAmount;

        Console.WriteLine($"Total Order Cost: ${finalOrderCost:F2}");
    }
}
