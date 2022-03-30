using System.ComponentModel.DataAnnotations;

namespace TiposReflection
{
    public class IValidaObject
    {
        //
        // Resumo:
        //     Provides a way for an object to be invalidated.
        public interface IValidatableObject
        {
            //
            // Resumo:
            //     Determines whether the specified object is valid.
            //
            // Parâmetros:
            //   validationContext:
            //     The validation context.
            //
            // Devoluções:
            //     A collection that holds failed-validation information.
            IEnumerable<ValidationResult> Validate(ValidationContext validationContext);
        }
    }
#if false // Log de descompilação
'143' itens no cache
------------------
Resolver: 'netstandard, Version=2.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Foi encontrado um assembly: 'netstandard, Version=2.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\netstandard.dll'
------------------
Resolver: 'System.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Runtime, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.2.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Runtime.dll'
------------------
Resolver: 'System.IO.MemoryMappedFiles, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.IO.MemoryMappedFiles, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.IO.MemoryMappedFiles.dll'
------------------
Resolver: 'System.IO.Pipes, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.IO.Pipes, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.IO.Pipes.dll'
------------------
Resolver: 'System.Diagnostics.Process, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Diagnostics.Process, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.2.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Diagnostics.Process.dll'
------------------
Resolver: 'System.Security.Cryptography.X509Certificates, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Security.Cryptography.X509Certificates, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.2.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Security.Cryptography.X509Certificates.dll'
------------------
Resolver: 'System.Runtime.Extensions, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Runtime.Extensions, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.2.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Runtime.Extensions.dll'
------------------
Resolver: 'System.Diagnostics.Tools, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Diagnostics.Tools, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Diagnostics.Tools.dll'
------------------
Resolver: 'System.Collections, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Collections, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Collections.dll'
------------------
Resolver: 'System.Collections.NonGeneric, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Collections.NonGeneric, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Collections.NonGeneric.dll'
------------------
Resolver: 'System.Collections.Concurrent, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Collections.Concurrent, Version=4.0.14.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.0.14.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Collections.Concurrent.dll'
------------------
Resolver: 'System.ObjectModel, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.ObjectModel, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.ObjectModel.dll'
------------------
Resolver: 'System.Collections.Specialized, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Collections.Specialized, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Collections.Specialized.dll'
------------------
Resolver: 'System.ComponentModel.TypeConverter, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.ComponentModel.TypeConverter, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.2.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.ComponentModel.TypeConverter.dll'
------------------
Resolver: 'System.ComponentModel.EventBasedAsync, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.ComponentModel.EventBasedAsync, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.ComponentModel.EventBasedAsync.dll'
------------------
Resolver: 'System.ComponentModel.Primitives, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.ComponentModel.Primitives, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.2.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.ComponentModel.Primitives.dll'
------------------
Resolver: 'System.ComponentModel, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.ComponentModel, Version=4.0.3.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.0.3.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.ComponentModel.dll'
------------------
Resolver: 'Microsoft.Win32.Primitives, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'Microsoft.Win32.Primitives, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\Microsoft.Win32.Primitives.dll'
------------------
Resolver: 'System.Console, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Console, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Console.dll'
------------------
Resolver: 'System.Data.Common, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Data.Common, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.2.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Data.Common.dll'
------------------
Resolver: 'System.Runtime.InteropServices, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Runtime.InteropServices, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.2.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Runtime.InteropServices.dll'
------------------
Resolver: 'System.Diagnostics.TraceSource, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Diagnostics.TraceSource, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Diagnostics.TraceSource.dll'
------------------
Resolver: 'System.Diagnostics.Contracts, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Diagnostics.Contracts, Version=4.0.3.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.0.3.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Diagnostics.Contracts.dll'
------------------
Resolver: 'System.Diagnostics.Debug, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Diagnostics.Debug, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Diagnostics.Debug.dll'
------------------
Resolver: 'System.Diagnostics.TextWriterTraceListener, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Diagnostics.TextWriterTraceListener, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Diagnostics.TextWriterTraceListener.dll'
------------------
Resolver: 'System.Diagnostics.FileVersionInfo, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Diagnostics.FileVersionInfo, Version=4.0.3.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.0.3.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Diagnostics.FileVersionInfo.dll'
------------------
Resolver: 'System.Diagnostics.StackTrace, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Diagnostics.StackTrace, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Diagnostics.StackTrace.dll'
------------------
Resolver: 'System.Diagnostics.Tracing, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Diagnostics.Tracing, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.2.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Diagnostics.Tracing.dll'
------------------
Resolver: 'System.Drawing.Primitives, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Drawing.Primitives, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.2.0.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Drawing.Primitives.dll'
------------------
Resolver: 'System.Linq.Expressions, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Linq.Expressions, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.2.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Linq.Expressions.dll'
------------------
Resolver: 'System.IO.Compression, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Foi encontrado um assembly: 'System.IO.Compression, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.2.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.IO.Compression.dll'
------------------
Resolver: 'System.IO.Compression.ZipFile, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Foi encontrado um assembly: 'System.IO.Compression.ZipFile, Version=4.0.4.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.0.4.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.IO.Compression.ZipFile.dll'
------------------
Resolver: 'System.IO.FileSystem, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.IO.FileSystem, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.IO.FileSystem.dll'
------------------
Resolver: 'System.IO.FileSystem.DriveInfo, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.IO.FileSystem.DriveInfo, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.IO.FileSystem.DriveInfo.dll'
------------------
Resolver: 'System.IO.FileSystem.Watcher, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.IO.FileSystem.Watcher, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.IO.FileSystem.Watcher.dll'
------------------
Resolver: 'System.IO.IsolatedStorage, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.IO.IsolatedStorage, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.IO.IsolatedStorage.dll'
------------------
Resolver: 'System.Linq, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Linq, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.2.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Linq.dll'
------------------
Resolver: 'System.Linq.Queryable, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Linq.Queryable, Version=4.0.3.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.0.3.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Linq.Queryable.dll'
------------------
Resolver: 'System.Linq.Parallel, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Linq.Parallel, Version=4.0.3.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.0.3.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Linq.Parallel.dll'
------------------
Resolver: 'System.Threading.Thread, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Threading.Thread, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Threading.Thread.dll'
------------------
Resolver: 'System.Net.Requests, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Net.Requests, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Net.Requests.dll'
------------------
Resolver: 'System.Net.Primitives, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Net.Primitives, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Net.Primitives.dll'
------------------
Resolver: 'System.Net.HttpListener, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Foi encontrado um assembly: 'System.Net.HttpListener, Version=4.0.1.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.0.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Net.HttpListener.dll'
------------------
Resolver: 'System.Net.ServicePoint, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Foi encontrado um assembly: 'System.Net.ServicePoint, Version=4.0.1.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.0.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Net.ServicePoint.dll'
------------------
Resolver: 'System.Net.NameResolution, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Net.NameResolution, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Net.NameResolution.dll'
------------------
Resolver: 'System.Net.WebClient, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Foi encontrado um assembly: 'System.Net.WebClient, Version=4.0.1.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.0.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Net.WebClient.dll'
------------------
Resolver: 'System.Net.Http, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Net.Http, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.2.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Net.Http.dll'
------------------
Resolver: 'System.Net.WebHeaderCollection, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Net.WebHeaderCollection, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Net.WebHeaderCollection.dll'
------------------
Resolver: 'System.Net.WebProxy, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Foi encontrado um assembly: 'System.Net.WebProxy, Version=4.0.1.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.0.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Net.WebProxy.dll'
------------------
Resolver: 'System.Net.Mail, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Foi encontrado um assembly: 'System.Net.Mail, Version=4.0.1.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.0.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Net.Mail.dll'
------------------
Resolver: 'System.Net.NetworkInformation, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Net.NetworkInformation, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.2.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Net.NetworkInformation.dll'
------------------
Resolver: 'System.Net.Ping, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Net.Ping, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Net.Ping.dll'
------------------
Resolver: 'System.Net.Security, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Net.Security, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Net.Security.dll'
------------------
Resolver: 'System.Net.Sockets, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Net.Sockets, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.2.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Net.Sockets.dll'
------------------
Resolver: 'System.Net.WebSockets.Client, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Net.WebSockets.Client, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Net.WebSockets.Client.dll'
------------------
Resolver: 'System.Net.WebSockets, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Net.WebSockets, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Net.WebSockets.dll'
------------------
Resolver: 'System.Runtime.Numerics, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Runtime.Numerics, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Runtime.Numerics.dll'
------------------
Resolver: 'System.Threading.Tasks, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Threading.Tasks, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Threading.Tasks.dll'
------------------
Resolver: 'System.Reflection.Primitives, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Reflection.Primitives, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Reflection.Primitives.dll'
------------------
Resolver: 'System.Resources.ResourceManager, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Resources.ResourceManager, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Resources.ResourceManager.dll'
------------------
Resolver: 'System.Resources.Writer, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Resources.Writer, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Resources.Writer.dll'
------------------
Resolver: 'System.Runtime.CompilerServices.VisualC, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Runtime.CompilerServices.VisualC, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Runtime.CompilerServices.VisualC.dll'
------------------
Resolver: 'System.Runtime.InteropServices.RuntimeInformation, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Runtime.InteropServices.RuntimeInformation, Version=4.0.3.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.0.3.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Runtime.InteropServices.RuntimeInformation.dll'
------------------
Resolver: 'System.Runtime.Serialization.Primitives, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Runtime.Serialization.Primitives, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.2.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Runtime.Serialization.Primitives.dll'
------------------
Resolver: 'System.Runtime.Serialization.Xml, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Runtime.Serialization.Xml, Version=4.1.4.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.4.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Runtime.Serialization.Xml.dll'
------------------
Resolver: 'System.Runtime.Serialization.Json, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Runtime.Serialization.Json, Version=4.0.4.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.0.4.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Runtime.Serialization.Json.dll'
------------------
Resolver: 'System.Runtime.Serialization.Formatters, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Runtime.Serialization.Formatters, Version=4.0.3.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.0.3.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Runtime.Serialization.Formatters.dll'
------------------
Resolver: 'System.Security.Claims, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Security.Claims, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Security.Claims.dll'
------------------
Resolver: 'System.Security.Cryptography.Algorithms, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Security.Cryptography.Algorithms, Version=4.3.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.3.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Security.Cryptography.Algorithms.dll'
------------------
Resolver: 'System.Security.Cryptography.Csp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Security.Cryptography.Csp, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Security.Cryptography.Csp.dll'
------------------
Resolver: 'System.Security.Cryptography.Encoding, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Security.Cryptography.Encoding, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Security.Cryptography.Encoding.dll'
------------------
Resolver: 'System.Security.Cryptography.Primitives, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Security.Cryptography.Primitives, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Security.Cryptography.Primitives.dll'
------------------
Resolver: 'System.Security.Principal, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Security.Principal, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Security.Principal.dll'
------------------
Resolver: 'System.Text.Encoding.Extensions, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Text.Encoding.Extensions, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Text.Encoding.Extensions.dll'
------------------
Resolver: 'System.Text.RegularExpressions, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Text.RegularExpressions, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.2.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Text.RegularExpressions.dll'
------------------
Resolver: 'System.Threading, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Threading, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Threading.dll'
------------------
Resolver: 'System.Threading.Overlapped, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Threading.Overlapped, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Threading.Overlapped.dll'
------------------
Resolver: 'System.Threading.ThreadPool, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Threading.ThreadPool, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Threading.ThreadPool.dll'
------------------
Resolver: 'System.Threading.Tasks.Parallel, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Threading.Tasks.Parallel, Version=4.0.3.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.0.3.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Threading.Tasks.Parallel.dll'
------------------
Resolver: 'System.Threading.Timer, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Threading.Timer, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Threading.Timer.dll'
------------------
Resolver: 'System.Transactions.Local, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Foi encontrado um assembly: 'System.Transactions.Local, Version=4.0.1.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.0.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Transactions.Local.dll'
------------------
Resolver: 'System.Web.HttpUtility, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Foi encontrado um assembly: 'System.Web.HttpUtility, Version=4.0.1.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.0.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Web.HttpUtility.dll'
------------------
Resolver: 'System.Xml.ReaderWriter, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Xml.ReaderWriter, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.2.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Xml.ReaderWriter.dll'
------------------
Resolver: 'System.Xml.XDocument, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Xml.XDocument, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Xml.XDocument.dll'
------------------
Resolver: 'System.Xml.XmlSerializer, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Xml.XmlSerializer, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Xml.XmlSerializer.dll'
------------------
Resolver: 'System.Xml.XPath.XDocument, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Xml.XPath.XDocument, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Xml.XPath.XDocument.dll'
------------------
Resolver: 'System.Xml.XPath, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Xml.XPath, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '4.1.1.0'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Xml.XPath.dll'
------------------
Resolver: 'System.Runtime, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Runtime, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Runtime.dll'
------------------
Resolver: 'System.Runtime.Extensions, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Runtime.Extensions, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Runtime.Extensions.dll'
------------------
Resolver: 'System.ComponentModel.Primitives, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.ComponentModel.Primitives, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.ComponentModel.Primitives.dll'
------------------
Resolver: 'System.Net.WebHeaderCollection, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Net.WebHeaderCollection, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Net.WebHeaderCollection.dll'
------------------
Resolver: 'System.Runtime.Serialization.Primitives, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Runtime.Serialization.Primitives, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Runtime.Serialization.Primitives.dll'
------------------
Resolver: 'System.Xml.ReaderWriter, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Xml.ReaderWriter, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Carregar de: 'C:\Users\DanielRodriguesCarva\.nuget\packages\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\System.Xml.ReaderWriter.dll'
#endif
}

