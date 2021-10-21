using CSharp.Choices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_1.Domain
{
    [AsChoice]
    public static partial class Cart
    {
        public interface ICart { }

        public record ValidatedCart(IReadOnlyCollection<ValidatedProduct> ProductsList) : ICart;

        public record UnvalidatedCart(IReadOnlyCollection<UnvalidatedProduct> ProductsList) : ICart;

        public record InvalidCart(IReadOnlyCollection<UnvalidatedProduct> ProductsList, string reason) : ICart;

        public record EmptyCart(IReadOnlyCollection<UnvalidatedProduct> ProductsList) : ICart;

        public record PaidCart(IReadOnlyCollection<ValidatedProduct> ProductsList) : ICart;

    }
}
