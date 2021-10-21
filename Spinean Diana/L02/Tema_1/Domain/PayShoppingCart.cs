using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_1.Domain
{
    public record PayShoppingCart
    {
        public PayShoppingCart(IReadOnlyCollection<EmptyCart> inputShoppingCarts)
        {
            InputShoppingCarts = inputShoppingCarts;
        }

        public IReadOnlyCollection<EmptyCart> InputShoppingCarts { get; }
    }
}
