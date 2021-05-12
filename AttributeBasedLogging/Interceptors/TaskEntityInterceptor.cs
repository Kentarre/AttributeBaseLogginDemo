using System;
using AttributeBasedLogging.Helpers;
using AttributeBasedLogging.Models;
using Castle.DynamicProxy;

namespace AttributeBasedLogging.Interceptors
{
    public class TaskEntityInterceptor : Interceptor
    {
        protected override void ExecuteAfter(IInvocation invocation)
        {
            var message = InterceptorHelpers.GetMessageFromAttribute(invocation.Method);

            if (string.IsNullOrEmpty(message))
                return;

            var target = invocation.InvocationTarget as TaskEntity;
            var method = invocation.Method;
            
            //Here can be any logging method you like. E.g. log4net, NLog, etc
            Console.WriteLine(string.Format(message, target.Name, target.ExecutionTime));
        }
    }
}