using System;
using System.Runtime.CompilerServices;
using ZStringX = Cysharp.Text.ZString;

namespace Serilog.ZString.Extensions.Logger
{
    // WARNING: This is a template class. Rest of ZLogging methods are computed by CodeGeneration project!!!
    
    // This class provides extension methods for Debug logs that are formatting arguments using ZString library
    public static class DebugLoggerExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ZDebug(this ILogger logger, string messageTemplate)
            => logger.Debug(messageTemplate);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ZDebug<T1>(this ILogger logger, ReadOnlySpan<char> messageTemplate, T1 arg1)
            => logger.Debug(ZStringX.Format(messageTemplate, arg1));
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ZDebug<T1, T2>(this ILogger logger, ReadOnlySpan<char> messageTemplate, T1 arg1, T2 arg2)
            => logger.Debug(ZStringX.Format(messageTemplate, arg1, arg2));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ZDebug<T1, T2, T3>(this ILogger logger, ReadOnlySpan<char> messageTemplate, T1 arg1, T2 arg2, T3 arg3)
            => logger.Debug(ZStringX.Format(messageTemplate, arg1, arg2, arg3));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ZDebug<T1, T2, T3, T4>(this ILogger logger, ReadOnlySpan<char> messageTemplate, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
            => logger.Debug(ZStringX.Format(messageTemplate, arg1, arg2, arg3, arg4));
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ZDebug<T1, T2, T3, T4, T5>(this ILogger logger, ReadOnlySpan<char> messageTemplate, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
            => logger.Debug(ZStringX.Format(messageTemplate, arg1, arg2, arg3, arg4, arg5));
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ZDebug<T1, T2, T3, T4, T5, T6>(this ILogger logger, ReadOnlySpan<char> messageTemplate, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
            => logger.Debug(ZStringX.Format(messageTemplate, arg1, arg2, arg3, arg4, arg5, arg6));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ZDebug<T1, T2, T3, T4, T5, T6, T7>(this ILogger logger, ReadOnlySpan<char> messageTemplate, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
            => logger.Debug(ZStringX.Format(messageTemplate, arg1, arg2, arg3, arg4, arg5, arg6, arg7));
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ZDebug<T1, T2, T3, T4, T5, T6, T7, T8>(this ILogger logger, ReadOnlySpan<char> messageTemplate, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
            => logger.Debug(ZStringX.Format(messageTemplate, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
        
    }
}