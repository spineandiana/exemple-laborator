using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_1.Domain
{
    public record CantitateProdus
    {
        public int Value { get; }

        private CantitateProdus(int value)
        {
            if (value > 0 && value <= 50)
            {
                Value = value;
            }
            else
            {
                throw new InvalidCodProdus($"{value:0.##} is an invalid quantity value.");
            }
        }
        public override string ToString()
        {
            return $"{Value}";
        }

        public static bool TryParse(string quantityString, out CantitateProdus
            quantity)
        {
            bool isValid = false;
            quantity = null;
            if (int.TryParse(quantityString, out int numericQuantity))
            {
                if (is_valid(numericQuantity))
                {
                    isValid = true;
                    quantity = new(numericQuantity);
                }
            }

            return isValid;
        }

        private static bool is_valid(int numericQuantity) => numericQuantity > 0;
    }
}
