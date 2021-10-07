using System;

namespace Tema_1
{
    class Program
    {
        private static readonly Random random = new Random();
        static void Main(string[] args)
        {
            //var listOfProducts = ReadListOfProducts().ToArray();
           // UnvalidatedCart unvalidatedCart = new(ProductsList);
            ICart result = CheckCart(nvalidatedCart);
            result.Match(
                whenUnvalidatedCart: unvalidatedCart => unvalidatedCart,
                whenEmptyCart: invalidResult => invalidResult,
                whenInvalidCart: invalidResult => invalidResult,
                whenValidatedCart: validatedCart => PaidCart,
                whenPaidCart: PaidCart => PaidCart
            );

            Console.WriteLine("Hello World!");
        }

        private static string? ReadValue(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}
