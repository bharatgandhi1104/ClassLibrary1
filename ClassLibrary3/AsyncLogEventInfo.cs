using System;

namespace NLog
{
    public struct AsyncLogEventInfo
    {
#pragma warning disable CS0824 // Constructor is marked external
#pragma warning disable CS0436 // Type conflicts with imported type
        public extern AsyncLogEventInfo(LogEventInfo logEvent, AsyncContinuation continuation);
#pragma warning restore CS0436 // Type conflicts with imported type
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Gets the log event.
#pragma warning disable CS0436 // Type conflicts with imported type
        public LogEventInfo LogEvent { get; }
#pragma warning restore CS0436 // Type conflicts with imported type
        //
        // Summary:
        //     Gets the continuation.
        public AsyncContinuation Continuation { get; }


        //
        // Summary:
        //     Determines whether the specified System.Object is equal to this instance.
        //
        // Parameters:
        //   obj:
        //     The System.Object to compare with this instance.
        //
        // Returns:
        //     A value of true if the specified System.Object is equal to this instance; otherwise,
        //     false.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern override bool Equals(object obj);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Returns a hash code for this instance.
        //
        // Returns:
        //     A hash code for this instance, suitable for use in hashing algorithms and data
        //     structures like a hash table.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern override int GetHashCode();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it


        //
        // Summary:
        //     Implements the operator ==.
        //
        // Parameters:
        //   eventInfo1:
        //     The event info1.
        //
        //   eventInfo2:
        //     The event info2.
        //
        // Returns:
        //     The result of the operator.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern static bool operator ==(AsyncLogEventInfo eventInfo1, AsyncLogEventInfo eventInfo2);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Implements the operator ==.
        //
        // Parameters:
        //   eventInfo1:
        //     The event info1.
        //
        //   eventInfo2:
        //     The event info2.
        //
        // Returns:
        //     The result of the operator.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern static bool operator !=(AsyncLogEventInfo eventInfo1, AsyncLogEventInfo eventInfo2);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }

    public class AsyncContinuation
    {
        public delegate void AsyncContinuation1(Exception exception);
    }
}