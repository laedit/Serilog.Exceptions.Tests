using Serilog.Exceptions.Destructurers;

namespace Serilog.Exceptions.Tests
{
    class Program
    {
        static void Main()
        {
            TestExceptionDestructurer();
            TestArgumentExceptionDestructurer();
            TestArgumentOutOfRangeExceptionDestructurer();
            TestAggregateExceptionDestructurer();
            TestReflectionTypeLoadExceptionDestructurer();
            TestSqlExceptionDestructurer();
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
