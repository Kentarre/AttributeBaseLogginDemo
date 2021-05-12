using Castle.DynamicProxy;

namespace AttributeBasedLogging.Interceptors
{
    public abstract class Interceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            invocation.Proceed();
            
            ExecuteAfter(invocation);
        }

        protected abstract void ExecuteAfter(IInvocation invocation);
    }
}