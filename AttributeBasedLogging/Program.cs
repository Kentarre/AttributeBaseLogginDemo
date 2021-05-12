using System;
using AttributeBasedLogging.Models;

namespace AttributeBasedLogging
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskEntity
                .Create("SomeName")
                .SetExecutionTime(DateTime.Now);
        }
    }
}