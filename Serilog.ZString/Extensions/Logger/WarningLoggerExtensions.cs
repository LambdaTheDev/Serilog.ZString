using System;
using System.Runtime.CompilerServices;
using Serilog.Events;
using ZStringX = Cysharp.Text.ZString;

namespace Serilog.ZString.Extensions.Logger
{
    // WARNING: This is a template class. Rest of ZLogging methods are computed by CodeGeneration project!!!
    
    // This class provides extension methods for Warning logs that are formatting arguments using ZString library
    public static class WarningLoggerExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ZWarning(this ILogger logger, string messageTemplate)
        {
            if (!logger.IsEnabled(LogEventLevel.Warning)) return;
            logger.Warning(messageTemplate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ZWarning<T1>(this ILogger logger, ReadOnlySpan<char> messageTemplate, T1 arg1)
        {
            if (!logger.IsEnabled(LogEventLevel.Warning)) return;
            logger.Warning(ZStringX.Format(messageTemplate, arg1));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ZWarning<T1, T2>(this ILogger logger, ReadOnlySpan<char> messageTemplate, T1 arg1, T2 arg2)
        {
            if (!logger.IsEnabled(LogEventLevel.Warning)) return;
            logger.Warning(ZStringX.Format(messageTemplate, arg1, arg2));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ZWarning<T1, T2, T3>(this ILogger logger, ReadOnlySpan<char> messageTemplate, T1 arg1, T2 arg2, T3 arg3)
        {
            if (!logger.IsEnabled(LogEventLevel.Warning)) return;
            logger.Warning(ZStringX.Format(messageTemplate, arg1, arg2, arg3));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ZWarning<T1, T2, T3, T4>(this ILogger logger, ReadOnlySpan<char> messageTemplate, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            if (!logger.IsEnabled(LogEventLevel.Warning)) return;
            logger.Warning(ZStringX.Format(messageTemplate, arg1, arg2, arg3, arg4));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ZWarning<T1, T2, T3, T4, T5>(this ILogger logger, ReadOnlySpan<char> messageTemplate, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            if (!logger.IsEnabled(LogEventLevel.Warning)) return;
            logger.Warning(ZStringX.Format(messageTemplate, arg1, arg2, arg3, arg4, arg5));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ZWarning<T1, T2, T3, T4, T5, T6>(this ILogger logger, ReadOnlySpan<char> messageTemplate, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            if (!logger.IsEnabled(LogEventLevel.Warning)) return;
            logger.Warning(ZStringX.Format(messageTemplate, arg1, arg2, arg3, arg4, arg5, arg6));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ZWarning<T1, T2, T3, T4, T5, T6, T7>(this ILogger logger, ReadOnlySpan<char> messageTemplate, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            if (!logger.IsEnabled(LogEventLevel.Warning)) return;
            logger.Warning(ZStringX.Format(messageTemplate, arg1, arg2, arg3, arg4, arg5, arg6, arg7));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ZWarning<T1, T2, T3, T4, T5, T6, T7, T8>(this ILogger logger, ReadOnlySpan<char> messageTemplate, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            if (!logger.IsEnabled(LogEventLevel.Warning)) return;
            logger.Warning(ZStringX.Format(messageTemplate, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
        }
    }
}