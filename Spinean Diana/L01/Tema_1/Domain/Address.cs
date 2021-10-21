using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_1.Domain
{
    public record Address
    {

        public string Value { get; }

        public Address(string value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
