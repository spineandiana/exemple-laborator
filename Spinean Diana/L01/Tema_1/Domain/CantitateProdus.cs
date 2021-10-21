using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_1.Domain
{
    public record CantitateProdus
    {
        public decimal Value { get; }

        private CantitateProdus(decimal value)
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

        public CantitateProdus Round()
        {
            var roundedValue = Math.Round(Value);
            return new CantitateProdus(roundedValue);
        }

        public override string ToString()
        {
            return $"{Value:0.##}";
        }
    }
}
