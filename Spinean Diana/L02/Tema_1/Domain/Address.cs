using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tema_1.Domain
{
    public record Address
    {
        private static readonly Regex ValidPattern = new("{str, nr}");
        public string Value { get; }

        public Address(string value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value;
        }
        private static bool is_valid(string stringValue) => ValidPattern.IsMatch(stringValue);
        public static bool TryParse(string addressString, out Address address)
        {
            bool valid = false;
            address = null;
            if (is_valid(addressString))
            {
                valid = true;
                address = new(addressString);
            }
            return valid;
        }
    }
}
