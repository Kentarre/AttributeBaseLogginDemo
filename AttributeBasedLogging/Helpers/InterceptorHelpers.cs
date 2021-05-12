using System.Reflection;
using AttributeBasedLogging.Attributes;

namespace AttributeBasedLogging.Helpers
{
    public static class InterceptorHelpers
    {
        public static string GetMessageFromAttribute(MethodInfo method)
        {
            var attrs = method.GetCustomAttribute<LogAttribute>();

            return attrs?.Message;
        }
    }
}