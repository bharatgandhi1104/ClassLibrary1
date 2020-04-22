using System;
using System.Collections.Generic;
using NLog.Config;
using NLog.Internal;
using NLog.Layouts;


namespace NLog.Config
{
#pragma warning disable CS0436 // Type conflicts with imported type
    public abstract class Target : ISupportsInitialize, IDisposable
#pragma warning restore CS0436 // Type conflicts with imported type
    {
#pragma warning disable CS0824 // Constructor is marked external
        protected extern Target();
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Target supports reuse of internal buffers, and doesn't have to constantly allocate
        //     new buffers Required for legacy NLog-targets, that expects buffers to remain
        //     stable after Write-method exit
        public bool OptimizeBufferReuse { get; set; }
        //
        // Summary:
        //     Gets or sets the name of the target.
        public string Name { get; set; }
        //
        // Summary:
        //     Gets a value indicating whether the target has been initialized.
        protected bool IsInitialized { get; }
        //
        // Summary:
        //     Gets the object which can be used to synchronize asynchronous operations that
        //     must rely on the .
        protected object SyncRoot { get; }
        //
        // Summary:
        //     Gets the logging configuration this target is part of.
        protected LoggingConfiguration LoggingConfiguration { get; }


        //
        // Summary:
        //     Register a custom Target.
        //
        // Parameters:
        //   targetType:
        //     Type of the Target.
        //
        //   name:
        //     Name of the Target.
        //
        // Remarks:
        //     Short-cut for registing to default NLog.Config.ConfigurationItemFactory
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern void Register(string name, Type targetType);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Register a custom Target.
        //
        // Parameters:
        //   name:
        //     Name of the Target.
        //
        // Type parameters:
        //   T:
        //     Type of the Target.
        //
        // Remarks:
        //     Short-cut for registing to default NLog.Config.ConfigurationItemFactory
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern void Register<T>(string name) where T : Target;

        public void Close()
        {
            throw new NotImplementedException();
        }
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Closes the target.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Dispose();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Flush any pending log messages (in case of asynchronous targets).
        //
        // Parameters:
        //   asyncContinuation:
        //     The asynchronous continuation.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Flush(AsyncContinuation asyncContinuation);

        public void Initialize(LoggingConfiguration configuration)
        {
            throw new NotImplementedException();
        }
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Calls the NLog.Layouts.Layout.Precalculate(NLog.LogEventInfo) on each volatile
        //     layout used by this target. This method won't prerender if all layouts in this
        //     target are thread-agnostic.
        //
        // Parameters:
        //   logEvent:
        //     The log event.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void PrecalculateVolatileLayouts(LogEventInfo logEvent);

        //
        // Summary:
        //     Returns a System.String that represents this instance.
        //
        // Returns:
        //     A System.String that represents this instance.


        //
        // Summary:
        //     Writes the log to the target.
        //
        // Parameters:
        //   logEvent:
        //     Log event to write.
        public extern void WriteAsyncLogEvent(AsyncLogEventInfo logEvent);
        //
        // Summary:
        //     Writes the array of log events.
        //
        // Parameters:
        //   logEvents:
        //     The log events.
        public extern void WriteAsyncLogEvents(params AsyncLogEventInfo[] logEvents);
        //
        // Summary:
        //     Writes the array of log events.
        //
        // Parameters:
        //   logEvents:
        //     The log events.
        public extern void WriteAsyncLogEvents(IList<AsyncLogEventInfo> logEvents);
        //
        // Summary:
        //     Closes the target and releases any unmanaged resources.
        protected extern virtual void CloseTarget();
        //
        // Summary:
        //     Releases unmanaged and - optionally - managed resources.
        //
        // Parameters:
        //   disposing:
        //     True to release both managed and unmanaged resources; false to release only unmanaged
        //     resources.
        protected extern virtual void Dispose(bool disposing);
        //
        // Summary:
        //     Flush any pending log messages asynchronously (in case of asynchronous targets).
        //
        // Parameters:
        //   asyncContinuation:
        //     The asynchronous continuation.
        protected extern virtual void FlushAsync(AsyncContinuation asyncContinuation);
        //
        // Summary:
        //     Initializes the target. Can be used by inheriting classes to initialize logging.
        protected extern virtual void InitializeTarget();
        //
        // Summary:
        //     Merges (copies) the event context properties from any event info object stored
        //     in parameters of the given event info object.
        //
        // Parameters:
        //   logEvent:
        //     The event info object to perform the merge to.
        [Obsolete("Logger.Trace(logEvent) now automatically captures the logEvent Properties. Marked obsolete on NLog 4.6")]
        protected extern void MergeEventProperties(LogEventInfo logEvent);
        //
        // Summary:
        //     Renders the event info in layout.
        //
        // Parameters:
        //   layout:
        //     The layout.
        //
        //   logEvent:
        //     The event info.
        //
        // Returns:
        //     String representing log event.
        protected abstract string RenderLogEvent(Layout layout, LogEventInfo logEvent);
        //
        // Summary:
        //     Writes an array of logging events to the log target. By default it iterates on
        //     all events and passes them to "Write" method. Inheriting classes can use this
        //     method to optimize batch writes.
        //
        // Parameters:
        //   logEvents:
        //     Logging events to be written out.
        protected extern virtual void Write(IList<AsyncLogEventInfo> logEvents);
        //
        // Summary:
        //     NOTE! Obsolete, instead override Write(IList{AsyncLogEventInfo} logEvents) Writes
        //     an array of logging events to the log target. By default it iterates on all events
        //     and passes them to "Write" method. Inheriting classes can use this method to
        //     optimize batch writes.
        //
        // Parameters:
        //   logEvents:
        //     Logging events to be written out.
        [Obsolete("Instead override Write(IList<AsyncLogEventInfo> logEvents. Marked obsolete on NLog 4.5")]
        protected extern virtual void Write(AsyncLogEventInfo[] logEvents);
        //
        // Summary:
        //     Writes async log event to the log target.
        //
        // Parameters:
        //   logEvent:
        //     Async Log event to be written out.
        protected extern virtual void Write(AsyncLogEventInfo logEvent);
        //
        // Summary:
        //     Writes logging event to the log target. Must be overridden in inheriting classes.
        //
        // Parameters:
        //   logEvent:
        //     Logging event to be written out.
        protected extern virtual void Write(LogEventInfo logEvent);
        //
        // Summary:
        //     Writes an array of logging events to the log target, in a thread safe manner.
        //     Any override of this method has to provide their own synchronization mechanism.
        //     !WARNING! Custom targets should only override this method if able to provide
        //     their own synchronization mechanism. NLog.Layouts.Layout-objects are not guaranteed
        //     to be threadsafe, so using them without a SyncRoot-object can be dangerous.
        //
        // Parameters:
        //   logEvents:
        //     Logging events to be written out.
        protected extern virtual void WriteAsyncThreadSafe(IList<AsyncLogEventInfo> logEvents);
        //
        // Summary:
        //     NOTE! Obsolete, instead override WriteAsyncThreadSafe(IList{AsyncLogEventInfo}
        //     logEvents) Writes an array of logging events to the log target, in a thread safe
        //     manner. !WARNING! Custom targets should only override this method if able to
        //     provide their own synchronization mechanism. NLog.Layouts.Layout-objects are
        //     not guaranteed to be threadsafe, so using them without a SyncRoot-object can
        //     be dangerous.
        //
        // Parameters:
        //   logEvents:
        //     Logging events to be written out.
        [Obsolete("Instead override WriteAsyncThreadSafe(IList<AsyncLogEventInfo> logEvents. Marked obsolete on NLog 4.5")]
        protected extern virtual void WriteAsyncThreadSafe(AsyncLogEventInfo[] logEvents);
        //
        // Summary:
        //     Writes a log event to the log target, in a thread safe manner. Any override of
        //     this method has to provide their own synchronization mechanism. !WARNING! Custom
        //     targets should only override this method if able to provide their own synchronization
        //     mechanism. NLog.Layouts.Layout-objects are not guaranteed to be threadsafe, so
        //     using them without a SyncRoot-object can be dangerous.
        //
        // Parameters:
        //   logEvent:
        //     Log event to be written out.
        protected extern virtual void WriteAsyncThreadSafe(AsyncLogEventInfo logEvent);
    }
}