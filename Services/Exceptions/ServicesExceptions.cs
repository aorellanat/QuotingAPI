using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Exceptions
{
    [Serializable]
    public class QuoteNameInvalid : Exception
    {
        private static readonly string defaultMessage = "Quote name invalid. Please check it.";

        public QuoteNameInvalid() : base(defaultMessage) { }
        public QuoteNameInvalid(string message) : base(message) { }
        public QuoteNameInvalid(string message, Exception inner) : base(message, inner) { }
        protected QuoteNameInvalid(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }

    }

    [Serializable]
    public class QuoteNameAlreadyExists : Exception
    {
        private static readonly string defaultMessage = "Quote name already exists. Please change the name.";

        public QuoteNameAlreadyExists() : base(defaultMessage) { }
        public QuoteNameAlreadyExists(string message) : base(message) { }
        public QuoteNameAlreadyExists(string message, Exception inner) : base(message, inner) { }
        protected QuoteNameAlreadyExists(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }

    }

}
