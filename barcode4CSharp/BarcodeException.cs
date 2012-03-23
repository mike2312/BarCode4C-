using System;


namespace MKS.barcode4CS
{
    public class BarcodeException: Exception
    {
        public BarcodeException()
        { }
        public BarcodeException(string message)
            : base(message)
        { }
        public BarcodeException(string message, Exception inner)
            : base(message)
        { }
    }
}
