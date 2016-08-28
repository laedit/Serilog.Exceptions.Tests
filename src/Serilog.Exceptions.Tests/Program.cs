using Serilog.Exceptions.Destructurers;
using System;

namespace Serilog.Exceptions.Tests
{
    class Program
    {
        static void Main()
        {
            try
            {
                LoadTargetTypes(TestExceptionDestructurer());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                Environment.Exit(1);
            }
        }

        private static void LoadTargetTypes(ExceptionDestructurer destructurer)
        {
            foreach (var targetType in destructurer.TargetTypes)
            {
                Console.WriteLine(targetType);
            }
        }

        private static ExceptionDestructurer TestExceptionDestructurer()
        {
            return new ExceptionDestructurer();
        }

        private static ExceptionDestructurer TestArgumentExceptionDestructurer()
        {
            return new ArgumentExceptionDestructurer();
        }

        private static ExceptionDestructurer TestArgumentOutOfRangeExceptionDestructurer()
        {
            return new ArgumentOutOfRangeExceptionDestructurer();
        }

        private static ExceptionDestructurer TestAggregateExceptionDestructurer()
        {
            return new AggregateExceptionDestructurer();
        }

        private static ExceptionDestructurer TestReflectionTypeLoadExceptionDestructurer()
        {
            return new ReflectionTypeLoadExceptionDestructurer();
        }

        private static ExceptionDestructurer TestSqlExceptionDestructurer()
        {
            return new SqlExceptionDestructurer();
        }
    }
}
