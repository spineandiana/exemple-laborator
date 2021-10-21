using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tema_1.Domain
{
    public record CodProdus
    {
        private static readonly Regex ValidPattern = new("^.*$");
        public string Code { get; }

        private CodProdus(string value)
        {
            if (ValidPattern.IsMatch(value))
            {
                Code = value;
            }
            else
            {
                throw new InvalidCodProdus($"{value:0.##} is an invalid grade value.");
            }
        }
        public override string ToString()
        {
            return Code;
        }

        private static bool is_valid(string stringValue) => ValidPattern.IsMatch(stringValue);

        public static bool TryParse(string productCodeString, out CodProdus productCode)
        {
            bool isValid = false;
            productCode = null;
            if (is_valid(productCodeString))
            {
                isValid = true;
                productCode = new(productCodeString);
            }
            return isValid;
        }
    }
}
