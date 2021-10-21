using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tema_1.Domain;
using static Tema_1.Domain.Cart;

namespace Tema_1
{
     public static class ShoppingCartsOperations
    {
        private static object paidShoppingCarts;

        public static IShoppingCarts ValidateShoppingCarts(Func<CodProdus, bool> checkProductExists, EmptyCart shoppingCarts)
        {
            List<ValidatedCart> validatedShoppingCarts = new();
            bool isValidList = true;
            string invalidReson = string.Empty;
            foreach (var emptyShoppingCart in shoppingCarts.ShoppingCartList)
            {
                if (!CodProdus.TryParse(emptyShoppingCart.productCode, out CodProdus productCode))
                {
                    invalidReson = $"Invalid product code ({emptyShoppingCart.productCode})";
                    isValidList = false;
                    break;
                }
                if (!CantitateProdus.TryParse(emptyShoppingCart.quantity, out CantitateProdus quantity))
                {
                    invalidReson = $"Invalid quantity ({emptyShoppingCart.productCode}, {emptyShoppingCart.quantity})";
                    isValidList = false;
                    break;
                }
                if (!Address.TryParse(emptyShoppingCart.address, out Address address))
                {
                    invalidReson = $"Invalid address ({emptyShoppingCart.productCode}, {emptyShoppingCart.address})";
                    isValidList = false;
                    break;
                }
                if (!Price.TryParse(emptyShoppingCart.price, out Price price))
                {
                    invalidReson = $"Invalid price ({emptyShoppingCart.productCode}, {emptyShoppingCart.price})";
                    isValidList = false;
                    break;
                }
                ValidatedCart validShoppingCart = new(productCode, quantity , address, price);
                validatedShoppingCarts.Add(validShoppingCart);
            }

            if (isValidList)
            {
                return new ValidatedCart(validatedShoppingCarts);
            }
            else
            {
                return new UnvalidatedCart(shoppingCarts.ShoppingCartList, invalidReson);
            }

        }

        public static IShoppingCarts CalculateFinalPrice(IShoppingCarts shoppingCarts) => shoppingCarts.Match(
            whenEmptyCart: emptyShoppingCart => emptyShoppingCart,
            whenUnvalidatedCart: unvalidatedShoppingCart => unvalidatedShoppingCart,
            whenCalculatedCart: calculatedShoppingCart => calculatedShoppingCart,
            whenPaidShoppingCarts: paidShoppingCart => paidShoppingCart,
            whenValidatedShoppingCarts: validShoppingCarts =>
            {
                var calculatedGrade = validShoppingCarts.ShoppingCartList.Select(validShoppingCart =>
                                            new CalculatedShoppingCart(validShoppingCart.productCode,
                                                                      validShoppingCart.quantity,
                                                                      validShoppingCart.address,
                                                                      validShoppingCart.price,
                                                                      validShoppingCart.price * validShoppingCart.quantity));
                return new CalculatedShoppingCart(calculatedGrade.ToList().AsReadOnly());
            }
        );

        public static IShoppingCarts PayShoppingCart(IShoppingCarts shoppingCarts) => shoppingCarts.Match(
            whenEmptyCart: emptyShoppingCart => emptyShoppingCart,
            whenUnvalidatedCart: unvalidatedShoppingCart => unvalidatedShoppingCart,
            whenPaidShoppingCarts: paidShoppingCart => paidShoppingCart,
            whenValidatedCart: validShoppingCarts => validShoppingCarts,
            whenCalculatedShoppingCarts: calculatedShoppingCart =>
            {
                StringBuilder csv = new();
                calculatedShoppingCart.ShoppingCartList.Aggregate(csv, (export, shoppingCart) => export.AppendLine($"{shoppingCart.productCode}, {shoppingCart.quantity}, {shoppingCart.address}, , {shoppingCart.finalPrice}"));

                return paidShoppingCarts;
            });
    }
}
