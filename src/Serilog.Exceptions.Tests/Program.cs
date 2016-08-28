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

        public static Type[] GetLoadedTargetTypes()
        {
            return new[] { typeof(Microsoft.CSharp.RuntimeBinder.RuntimeBinderException),
                        typeof(Microsoft.CSharp.RuntimeBinder.RuntimeBinderInternalCompilerException),
                        typeof(Microsoft.SqlServer.Server.InvalidUdtException),
                        typeof(System.AccessViolationException),
                        typeof(System.AppDomainUnloadedException),
                        typeof(System.ApplicationException),
                        typeof(System.ArithmeticException),
                        typeof(System.ArrayTypeMismatchException),
                        typeof(System.CannotUnloadAppDomainException),
                        typeof(System.Collections.Generic.KeyNotFoundException),
                        typeof(System.ComponentModel.Design.CheckoutException),
                        typeof(System.ComponentModel.InvalidAsynchronousStateException),
                        typeof(System.ComponentModel.InvalidEnumArgumentException),
                        typeof(System.Configuration.SettingsPropertyIsReadOnlyException),
                        typeof(System.Configuration.SettingsPropertyNotFoundException),
                        typeof(System.Configuration.SettingsPropertyWrongTypeException),
                        typeof(System.ContextMarshalException),
                        typeof(System.Data.Common.DbException),
                        typeof(System.Data.ConstraintException),
                        typeof(System.Data.DataException),
                        typeof(System.Data.DeletedRowInaccessibleException),
                        typeof(System.Data.DuplicateNameException),
                        typeof(System.Data.EvaluateException),
                        typeof(System.Data.InRowChangingEventException),
                        typeof(System.Data.InvalidConstraintException),
                        typeof(System.Data.InvalidExpressionException),
                        typeof(System.Data.MissingPrimaryKeyException),
                        typeof(System.Data.NoNullAllowedException),
                        typeof(System.Data.OperationAbortedException),
                        typeof(System.Data.ReadOnlyException),
                        typeof(System.Data.RowNotInTableException),
                        typeof(System.Data.SqlTypes.SqlAlreadyFilledException),
                        typeof(System.Data.SqlTypes.SqlNotFilledException),
                        typeof(System.Data.SqlTypes.SqlNullValueException),
                        typeof(System.Data.SqlTypes.SqlTruncateException),
                        typeof(System.Data.SqlTypes.SqlTypeException),
                        typeof(System.Data.StrongTypingException),
                        typeof(System.Data.SyntaxErrorException),
                        typeof(System.Data.VersionNotFoundException),
                        typeof(System.DataMisalignedException),
                        typeof(System.Diagnostics.Eventing.Reader.EventLogInvalidDataException),
                        typeof(System.Diagnostics.Eventing.Reader.EventLogNotFoundException),
                        typeof(System.Diagnostics.Eventing.Reader.EventLogProviderDisabledException),
                        typeof(System.Diagnostics.Eventing.Reader.EventLogReadingException),
                        typeof(System.Diagnostics.Tracing.EventSourceException),
                        typeof(System.DivideByZeroException),
                        typeof(System.DllNotFoundException),
                        typeof(System.DuplicateWaitObjectException),
                        typeof(System.EntryPointNotFoundException),
                        typeof(System.Exception),
                        typeof(System.FieldAccessException),
                        typeof(System.FormatException),
                        typeof(System.IndexOutOfRangeException),
                        typeof(System.InsufficientExecutionStackException),
                        typeof(System.InsufficientMemoryException),
                        typeof(System.InvalidCastException),
                        typeof(System.InvalidOperationException),
                        typeof(System.InvalidProgramException),
                        typeof(System.InvalidTimeZoneException),
                        typeof(System.IO.DirectoryNotFoundException),
                        typeof(System.IO.DriveNotFoundException),
                        typeof(System.IO.EndOfStreamException),
                        typeof(System.IO.InternalBufferOverflowException),
                        typeof(System.IO.InvalidDataException),
                        typeof(System.IO.IOException),
                        typeof(System.IO.IsolatedStorage.IsolatedStorageException),
                        typeof(System.IO.PathTooLongException),
                        typeof(System.Management.Instrumentation.InstanceNotFoundException),
                        typeof(System.Management.Instrumentation.InstrumentationBaseException),
                        typeof(System.Management.Instrumentation.InstrumentationException),
                        typeof(System.MemberAccessException),
                        typeof(System.MethodAccessException),
                        typeof(System.MulticastNotSupportedException),
                        typeof(System.Net.CookieException),
                        typeof(System.Net.NetworkInformation.PingException),
                        typeof(System.Net.ProtocolViolationException),
                        typeof(System.NotImplementedException),
                        typeof(System.NotSupportedException),
                        typeof(System.NullReferenceException),
                        typeof(System.OutOfMemoryException),
                        typeof(System.OverflowException),
                        typeof(System.PlatformNotSupportedException),
                        typeof(System.RankException),
                        typeof(System.Reflection.AmbiguousMatchException),
                        typeof(System.Reflection.CustomAttributeFormatException),
                        typeof(System.Reflection.InvalidFilterCriteriaException),
                        typeof(System.Reflection.TargetException),
                        typeof(System.Reflection.TargetInvocationException),
                        typeof(System.Reflection.TargetParameterCountException),
                        typeof(System.Resources.MissingManifestResourceException),
                        typeof(System.Runtime.InteropServices.COMException),
                        typeof(System.Runtime.InteropServices.InvalidComObjectException),
                        typeof(System.Runtime.InteropServices.InvalidOleVariantTypeException),
                        typeof(System.Runtime.InteropServices.MarshalDirectiveException),
                        typeof(System.Runtime.InteropServices.SafeArrayRankMismatchException),
                        typeof(System.Runtime.InteropServices.SafeArrayTypeMismatchException),
                        typeof(System.Runtime.InteropServices.SEHException),
                        typeof(System.Runtime.Remoting.RemotingException),
                        typeof(System.Runtime.Remoting.RemotingTimeoutException),
                        typeof(System.Runtime.Remoting.ServerException),
                        typeof(System.Runtime.Serialization.SerializationException),
                        typeof(System.Security.Authentication.AuthenticationException),
                        typeof(System.Security.Authentication.InvalidCredentialException),
                        typeof(System.Security.Cryptography.CryptographicException),
                        typeof(System.Security.Cryptography.CryptographicUnexpectedOperationException),
                        typeof(System.Security.Policy.PolicyException),
                        typeof(System.Security.VerificationException),
                        typeof(System.Security.XmlSyntaxException),
                        typeof(System.StackOverflowException),
                        typeof(System.SystemException),
                        typeof(System.Threading.BarrierPostPhaseException),
                        typeof(System.Threading.LockRecursionException),
                        typeof(System.Threading.SemaphoreFullException),
                        typeof(System.Threading.SynchronizationLockException),
                        typeof(System.Threading.Tasks.TaskSchedulerException),
                        typeof(System.Threading.ThreadInterruptedException),
                        typeof(System.Threading.ThreadStartException),
                        typeof(System.Threading.ThreadStateException),
                        typeof(System.Threading.WaitHandleCannotBeOpenedException),
                        typeof(System.TimeoutException),
                        typeof(System.TimeZoneNotFoundException),
                        typeof(System.TypeAccessException),
                        typeof(System.TypeUnloadedException),
                        typeof(System.UnauthorizedAccessException),
                        typeof(System.UriFormatException)};
        }
    }
}
