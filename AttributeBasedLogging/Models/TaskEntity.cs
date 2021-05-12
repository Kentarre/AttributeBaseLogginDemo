using System;
using System.Threading.Tasks;
using AttributeBasedLogging.Attributes;
using AttributeBasedLogging.Interceptors;
using Castle.DynamicProxy;

namespace AttributeBasedLogging.Models
{
    public class TaskEntity
    {
        public TaskEntity(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public DateTime ExecutionTime { get; private set; }

        public static TaskEntity Create(string name)
        {
            var pr = new ProxyGenerator();
            var entity =
                (TaskEntity) pr.CreateClassProxy(typeof(TaskEntity), new object[] { name }, new TaskEntityInterceptor());

            return entity;
        }

        [Log("{0}: Execution time set to: {1}")]
        public virtual void SetExecutionTime(DateTime time)
        {
            ExecutionTime = time;
        }
    }
}