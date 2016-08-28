using Serilog.Exceptions.Destructurers;
using System;
using System.Collections.Generic;

namespace Serilog.Exceptions.Tests
{
    class Program
    {
        static void Main()
        {
            try
            {
                LoadTargetTypes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Environment.Exit(1);
            }
        }

        private static void LoadTargetTypes()
        {
            foreach (var destructurer in GetDestructurers())
            {
                Console.WriteLine(destructurer.Key);

                foreach (var targetType in destructurer.Value)
                {
                    Console.WriteLine(targetType);
                    Type.GetType(targetType);
                }

                Console.WriteLine();
            }
        }

        private static Dictionary<string, string[]> GetDestructurers()
        {
            return new Dictionary<string, string[]>
            {
                { "ExceptionDestructurer", GetExceptionDestructurerTargetTypes()},
                { "ArgumentExceptionDestructurer", new[] { "ArgumentException", "ArgumentNullException" } },
                { "ArgumentOutOfRangeExceptionDestructurer", new[] { "ArgumentOutOfRangeException" } },
                {"AggregateExceptionDestructurer", new[] { "AggregateException" } },
                { "ReflectionTypeLoadExceptionDestructurer", new[] { "ReflectionTypeLoadException" } },
                { "SqlExceptionDestructurer", new[] { "SqlException" } }
            };
        }

        private static string[] GetExceptionDestructurerTargetTypes()
        {
            return new[]
            {
            "Microsoft.CSharp.RuntimeBinder.RuntimeBinderException",
            "Microsoft.CSharp.RuntimeBinder.RuntimeBinderInternalCompilerException",
            "Microsoft.SqlServer.Server.InvalidUdtException",
            "System.AccessViolationException",
            "System.AppDomainUnloadedException",
            "System.ApplicationException",
            "System.ArithmeticException",
            "System.ArrayTypeMismatchException",
            "System.CannotUnloadAppDomainException",
            "System.Collections.Generic.KeyNotFoundException",
            "System.ComponentModel.Design.CheckoutException",
            "System.ComponentModel.InvalidAsynchronousStateException",
            "System.ComponentModel.InvalidEnumArgumentException",
            "System.Configuration.SettingsPropertyIsReadOnlyException",
            "System.Configuration.SettingsPropertyNotFoundException",
            "System.Configuration.SettingsPropertyWrongTypeException",
            "System.ContextMarshalException",
            "System.Data.Common.DbException",
            "System.Data.ConstraintException",
            "System.Data.DataException",
            "System.Data.DeletedRowInaccessibleException",
            "System.Data.DuplicateNameException",
            "System.Data.EvaluateException",
            "System.Data.InRowChangingEventException",
            "System.Data.InvalidConstraintException",
            "System.Data.InvalidExpressionException",
            "System.Data.MissingPrimaryKeyException",
            "System.Data.NoNullAllowedException",
            "System.Data.OperationAbortedException",
            "System.Data.ReadOnlyException",
            "System.Data.RowNotInTableException",
            "System.Data.SqlTypes.SqlAlreadyFilledException",
            "System.Data.SqlTypes.SqlNotFilledException",
            "System.Data.SqlTypes.SqlNullValueException",
            "System.Data.SqlTypes.SqlTruncateException",
            "System.Data.SqlTypes.SqlTypeException",
            "System.Data.StrongTypingException",
            "System.Data.SyntaxErrorException",
            "System.Data.VersionNotFoundException",
            "System.DataMisalignedException",
            "System.Diagnostics.Eventing.Reader.EventLogInvalidDataException",
            "System.Diagnostics.Eventing.Reader.EventLogNotFoundException",
            "System.Diagnostics.Eventing.Reader.EventLogProviderDisabledException",
            "System.Diagnostics.Eventing.Reader.EventLogReadingException",
            "System.Diagnostics.Tracing.EventSourceException",
            "System.DivideByZeroException",
            "System.DllNotFoundException",
            "System.DuplicateWaitObjectException",
            "System.EntryPointNotFoundException",
            "System.Exception",
            "System.FieldAccessException",
            "System.FormatException",
            "System.IndexOutOfRangeException",
            "System.InsufficientExecutionStackException",
            "System.InsufficientMemoryException",
            "System.InvalidCastException",
            "System.InvalidOperationException",
            "System.InvalidProgramException",
            "System.InvalidTimeZoneException",
            "System.IO.DirectoryNotFoundException",
            "System.IO.DriveNotFoundException",
            "System.IO.EndOfStreamException",
            "System.IO.InternalBufferOverflowException",
            "System.IO.InvalidDataException",
            "System.IO.IOException",
            "System.IO.IsolatedStorage.IsolatedStorageException",
            "System.IO.PathTooLongException",
            "System.Management.Instrumentation.InstanceNotFoundException",
            "System.Management.Instrumentation.InstrumentationBaseException",
            "System.Management.Instrumentation.InstrumentationException",
            "System.MemberAccessException",
            "System.MethodAccessException",
            "System.MulticastNotSupportedException",
            "System.Net.CookieException",
            "System.Net.NetworkInformation.PingException",
            "System.Net.ProtocolViolationException",
            "System.NotImplementedException",
            "System.NotSupportedException",
            "System.NullReferenceException",
            "System.OutOfMemoryException",
            "System.OverflowException",
            "System.PlatformNotSupportedException",
            "System.RankException",
            "System.Reflection.AmbiguousMatchException",
            "System.Reflection.CustomAttributeFormatException",
            "System.Reflection.InvalidFilterCriteriaException",
            "System.Reflection.TargetException",
            "System.Reflection.TargetInvocationException",
            "System.Reflection.TargetParameterCountException",
            "System.Resources.MissingManifestResourceException",
            "System.Runtime.InteropServices.COMException",
            "System.Runtime.InteropServices.InvalidComObjectException",
            "System.Runtime.InteropServices.InvalidOleVariantTypeException",
            "System.Runtime.InteropServices.MarshalDirectiveException",
            "System.Runtime.InteropServices.SafeArrayRankMismatchException",
            "System.Runtime.InteropServices.SafeArrayTypeMismatchException",
            "System.Runtime.InteropServices.SEHException",
            "System.Runtime.Remoting.RemotingException",
            "System.Runtime.Remoting.RemotingTimeoutException",
            "System.Runtime.Remoting.ServerException",
            "System.Runtime.Serialization.SerializationException",
            "System.Security.Authentication.AuthenticationException",
            "System.Security.Authentication.InvalidCredentialException",
            "System.Security.Cryptography.CryptographicException",
            "System.Security.Cryptography.CryptographicUnexpectedOperationException",
            "System.Security.Policy.PolicyException",
            "System.Security.VerificationException",
            "System.Security.XmlSyntaxException",
            "System.StackOverflowException",
            "System.SystemException",
            "System.Threading.BarrierPostPhaseException",
            "System.Threading.LockRecursionException",
            "System.Threading.SemaphoreFullException",
            "System.Threading.SynchronizationLockException",
            "System.Threading.Tasks.TaskSchedulerException",
            "System.Threading.ThreadInterruptedException",
            "System.Threading.ThreadStartException",
            "System.Threading.ThreadStateException",
            "System.Threading.WaitHandleCannotBeOpenedException",
            "System.TimeoutException",
            "System.TimeZoneNotFoundException",
            "System.TypeAccessException",
            "System.TypeUnloadedException",
            "System.UnauthorizedAccessException",
            "System.UriFormatException"
        };
        }
    }
}
