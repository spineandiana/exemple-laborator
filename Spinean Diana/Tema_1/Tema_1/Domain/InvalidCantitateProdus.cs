using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Tema_1.Domain
{
    [Serializable]
    internal class InvalidCantitateProdus : Exception
    {
        public InvalidCantitateProdus()
        {
        }

        public InvalidCantitateProdus(string? message) : base(message)
        {
        }

        public InvalidCantitateProdus(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidCantitateProdus(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
