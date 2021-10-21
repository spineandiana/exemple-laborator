using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Tema_1.Domain
{
    [Serializable]
    internal class InvalidCodProdus : Exception
    {
        public InvalidCodProdus()
        {
        }

        public InvalidCodProdus(string? message) : base(message)
        {
        }

        public InvalidCodProdus(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidCodProdus(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
