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
                Console.WriteLine("Test1: instanciate default destructurers");
                IExceptionDestructurer[] DefaultDestructurers =
                {
                    new ExceptionDestructurer(),
                    new ArgumentExceptionDestructurer(),
                    new ArgumentOutOfRangeExceptionDestructurer(),
                    new AggregateExceptionDestructurer(),
                    new ReflectionTypeLoadExceptionDestructurer(),
                    new SqlExceptionDestructurer()
                };

                Console.WriteLine("Test2: instanciate logger");
                new LoggerConfiguration().Enrich.WithExceptionDetails().CreateLogger();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                Environment.Exit(1);
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
