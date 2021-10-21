using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_1.Domain
{
    public record CalculatedShoppingCart(CodProdus productCode, CantitateProdus quantity, Address address, Price price, Price finalPrice);
}
