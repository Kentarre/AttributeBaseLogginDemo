using System;

namespace AttributeBasedLogging.Attributes
{
    public class LogAttribute : Attribute
    {
        public string Message { get; set; }

        public LogAttribute(string message)
        {
            Message = message;
        }
    }
}