namespace Web.Example.S3.Framework.Exceptions
{
    public class BrowserNotSupportedException : System.Exception
    {
        public BrowserNotSupportedException() : base() { }
        public BrowserNotSupportedException(string message) : base(message) { }
        public BrowserNotSupportedException(string message, System.Exception inner) : base(message, inner) { }
    }
}
