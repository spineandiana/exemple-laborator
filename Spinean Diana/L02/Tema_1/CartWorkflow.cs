using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema_1.Domain;

namespace Tema_1
{
    public class CartWorkflow
    {
        /*
        public IShoppingCartsPaidEvent Execute(PayShoppingCart command, Func<CodProdus, bool> checkProductExists)
        {
            EmptyCart emptyShoppingCarts = new EmptyCart(command.InputShoppingCarts);
            IShoppingCarts shoppingCarts = ValidateCart(checkProductExists, emptyShoppingCarts);
            
           

            return shoppingCarts.Match(
                    whenEmptyCart: EmptyCart => new ShoppingCartsPaidFailedEvent("Unexpected unvalidated state") as IShoppingCartsPaidEvent,
                    whenUnvalidatedCart: UnvalidatedCart => new ShoppingCartsPaidFailedEvent(unvalidatedShoppingCarts.Reason),
                    whenValidatedCart: ValidatedCart => new ShoppingCartsPaidFailedEvent("Unexpected validated state"),
                    whenCalculatedShoppingCart: calculatedShoppingCarts => new ShoppingCartsPaidFailedEvent("Unexpected calculated state"),
                    whenPaidCart: paidShoppingCarts => new ShoppingCartsPaidScucceededEvent(paidShoppingCarts.Csv, paidShoppingCarts.PublishedDate)
                );
        }*/
    }
}
