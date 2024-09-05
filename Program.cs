internal class Program
{
    private static void Main(string[] args)
    {
        decimal pricePerApple = 32.50m;

        Console.Write("Enter the number of apples you want to purchase: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int qtyOfApples))
        {
            decimal totalPrice = qtyOfApples * pricePerApple;
            Console.WriteLine($"The total price of {qtyOfApples} is {totalPrice}.");

            int convertedPrice = (int)Math.Floor(totalPrice);
            Console.WriteLine($"The value of the converted price is {convertedPrice}.");
        }
    }
}