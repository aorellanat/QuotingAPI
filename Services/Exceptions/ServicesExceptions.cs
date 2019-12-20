using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Exceptions
{
    [Serializable]
    public class QuoteNameInvalid : Exception
    {
        public int Code { get { return 515; } }

        public QuoteNameInvalid(string message) : base(message) { }
    }

    public class QuoteNameAlreadyExists : Exception
    {
        public int Code { get { return 516; } }
        public QuoteNameAlreadyExists(string message) : base(message) { }
    }

    public class QuoteNameDoesNotExist : Exception
    {
        public int Code { get { return 517; } }

        public QuoteNameDoesNotExist(string message) : base(message) { }
    }
    public class QuoteNotFound : Exception
	  {
		    public int Code { get { return 577; } }

		    public QuoteNotFound(string message) : base(message) { }
	}
}
