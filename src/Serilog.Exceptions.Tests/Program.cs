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
                    var type = Type.GetType(targetType);
                    if (type == null)
                    {
                        Console.WriteLine("not loaded");
                    }
                }

                Console.WriteLine();
            }
        }

        private static Dictionary<string, string[]> GetDestructurers()
        {
            return new Dictionary<string, string[]>
            {
                { "ExceptionDestructurer", GetExceptionDestructurerTargetTypes()},
                { "ArgumentExceptionDestructurer", new[] { "System.ArgumentException", "System.ArgumentNullException" } },
                { "ArgumentOutOfRangeExceptionDestructurer", new[] { "System.ArgumentOutOfRangeException" } },
                {"AggregateExceptionDestructurer", new[] { "System.AggregateException" } },
                { "ReflectionTypeLoadExceptionDestructurer", new[] { "System.Reflection.ReflectionTypeLoadException" } },
                { "SqlExceptionDestructurer", new[] { "System.Data.SqlClient.SqlException, System.Data, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" } }
            };
        }

        private static string[] GetExceptionDestructurerTargetTypes()
        {
            return new[]
            {
            "Microsoft.CSharp.RuntimeBinder.RuntimeBinderException, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
            "Microsoft.CSharp.RuntimeBinder.RuntimeBinderInternalCompilerException, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
            "Microsoft.SqlServer.Server.InvalidUdtException, System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.AccessViolationException",
            "System.AppDomainUnloadedException",
            "System.ApplicationException",
            "System.ArithmeticException",
            "System.ArrayTypeMismatchException",
            "System.CannotUnloadAppDomainException",
            "System.Collections.Generic.KeyNotFoundException",
            "System.ComponentModel.Design.CheckoutException, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.ComponentModel.InvalidAsynchronousStateException, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.ComponentModel.InvalidEnumArgumentException, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.Configuration.SettingsPropertyIsReadOnlyException, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.Configuration.SettingsPropertyNotFoundException, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.Configuration.SettingsPropertyWrongTypeException, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.ContextMarshalException",
            "System.Data.Common.DbException, System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.Data.ConstraintException, System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.Data.DataException, System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.Data.DeletedRowInaccessibleException, System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.Data.DuplicateNameException, System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.Data.EvaluateException, System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.Data.InRowChangingEventException, System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.Data.InvalidConstraintException, System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.Data.InvalidExpressionException, System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.Data.MissingPrimaryKeyException, System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.Data.NoNullAllowedException, System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.Data.OperationAbortedException, System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.Data.ReadOnlyException, System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.Data.RowNotInTableException, System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.Data.SqlTypes.SqlAlreadyFilledException, System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.Data.SqlTypes.SqlNotFilledException, System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.Data.SqlTypes.SqlNullValueException, System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.Data.SqlTypes.SqlTruncateException, System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.Data.SqlTypes.SqlTypeException, System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.Data.StrongTypingException, System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.Data.SyntaxErrorException, System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.Data.VersionNotFoundException, System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.DataMisalignedException",
            "System.Diagnostics.Eventing.Reader.EventLogInvalidDataException, System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.Diagnostics.Eventing.Reader.EventLogNotFoundException, System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.Diagnostics.Eventing.Reader.EventLogProviderDisabledException, System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.Diagnostics.Eventing.Reader.EventLogReadingException, System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
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
            "System.IO.InternalBufferOverflowException, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.IO.InvalidDataException, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.IO.IOException",
            "System.IO.IsolatedStorage.IsolatedStorageException",
            "System.IO.PathTooLongException",
            "System.Management.Instrumentation.InstanceNotFoundException, System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.Management.Instrumentation.InstrumentationBaseException, System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.Management.Instrumentation.InstrumentationException, System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.MemberAccessException",
            "System.MethodAccessException",
            "System.MulticastNotSupportedException",
            "System.Net.CookieException, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.Net.NetworkInformation.PingException, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.Net.ProtocolViolationException, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
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
            "System.Security.Authentication.AuthenticationException, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.Security.Authentication.InvalidCredentialException, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
            "System.Security.Cryptography.CryptographicException",
            "System.Security.Cryptography.CryptographicUnexpectedOperationException",
            "System.Security.Policy.PolicyException",
            "System.Security.VerificationException",
            "System.Security.XmlSyntaxException",
            "System.StackOverflowException",
            "System.SystemException",
            "System.Threading.BarrierPostPhaseException, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
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
            "System.UriFormatException, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
        };
        }
    }
}
