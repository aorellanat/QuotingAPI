using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Exceptions
{
    [Serializable]
    public class QuoteNameInvalid : Exception
    {
        public int Code { get { return 515; } }
        private static readonly string defaultMessage = "Nombre de cotización inválido. Por favor revise el nombre.";

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
        public int Code { get { return 516; } }
        private static readonly string defaultMessage = "Nombre de cotización ya existente. Por favor cambie el nombre.";

        public QuoteNameAlreadyExists() : base(defaultMessage) { }
        public QuoteNameAlreadyExists(string message) : base(message) { }
        public QuoteNameAlreadyExists(string message, Exception inner) : base(message, inner) { }
        protected QuoteNameAlreadyExists(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }

    }
    [Serializable]
    public class QuoteNameDoesNotExist : Exception
    {
        public int Code { get { return 517; } }
        private static readonly string defaultMessage = "Nombre de cotización no encontrado. Por favor vuelva a intentarlo.";

        public QuoteNameDoesNotExist() : base(defaultMessage) { }
        public QuoteNameDoesNotExist(string message) : base(message) { }
        public QuoteNameDoesNotExist(string message, Exception inner) : base(message, inner) { }
        protected QuoteNameDoesNotExist(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }

    }
}
