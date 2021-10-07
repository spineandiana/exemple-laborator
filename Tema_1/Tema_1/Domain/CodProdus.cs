using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_1.Domain
{
    public record CodProdus
    {
        public decimal Value { get; }

        private CodProdus(decimal value)
        {
            if (value > 0 && value <=999)
            {
                Value = value;
            }
            else
            {
                throw new InvalidCodProdus($"{value:0.##} is an invalid grade value.");
            }
        }

        public CodProdus Round()
        {
            var roundedValue = Math.Round(Value);
            return new CodProdus(roundedValue);
        }

        public override string ToString()
        {
            return $"{Value:0.##}";
        }
    }
}
