using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;

namespace System.Diagnostics
{
    public class StackTrace
    {

        //
        // Summary:
        //     Defines the default for the number of methods to omit from the stack trace. This
        //     field is constant.
        public const int METHODS_TO_SKIP = 0;


        //
        // Summary:
        //     Initializes a new instance of the System.Diagnostics.StackTrace class from the
        //     caller's frame.
#pragma warning disable CS0824 // Constructor is marked external
        public extern StackTrace();
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Initializes a new instance of the System.Diagnostics.StackTrace class from the
        //     caller's frame, optionally capturing source information.
        //
        // Parameters:
        //   fNeedFileInfo:
        //     true to capture the file name, line number, and column number; otherwise, false.
#pragma warning disable CS0824 // Constructor is marked external
        public extern StackTrace(bool fNeedFileInfo);
#pragma warning restore CS0824 // Constructor is marked external
        //
        // Summary:
        //     Initializes a new instance of the System.Diagnostics.StackTrace class from the
        //     caller's frame, skipping the specified number of frames.
        //
        // Parameters:
        //   skipFrames:
        //     The number of frames up the stack from which to start the trace.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     The skipFrames parameter is negative.
#pragma warning disable CS0824 // Constructor is marked external
        public extern StackTrace(int skipFrames);
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Initializes a new instance of the System.Diagnostics.StackTrace class using the
        //     provided exception object.
        //
        // Parameters:
        //   e:
        //     The exception object from which to construct the stack trace.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     The parameter e is null.
#pragma warning disable CS0824 // Constructor is marked external
        public extern StackTrace(Exception e);
#pragma warning restore CS0824 // Constructor is marked external
        //
        // Summary:
        //     Initializes a new instance of the System.Diagnostics.StackTrace class that contains
        //     a single frame.
        //
        // Parameters:
        //   frame:
        //     The frame that the System.Diagnostics.StackTrace object should contain.
#pragma warning disable CS0824 // Constructor is marked external
        public extern StackTrace(StackFrame frame);
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Initializes a new instance of the System.Diagnostics.StackTrace class from the
        //     caller's frame, skipping the specified number of frames and optionally capturing
        //     source information.
        //
        // Parameters:
        //   skipFrames:
        //     The number of frames up the stack from which to start the trace.
        //
        //   fNeedFileInfo:
        //     true to capture the file name, line number, and column number; otherwise, false.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     The skipFrames parameter is negative.
#pragma warning disable CS0824 // Constructor is marked external
        public extern StackTrace(int skipFrames, bool fNeedFileInfo);
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Initializes a new instance of the System.Diagnostics.StackTrace class, using
        //     the provided exception object and optionally capturing source information.
        //
        // Parameters:
        //   e:
        //     The exception object from which to construct the stack trace.
        //
        //   fNeedFileInfo:
        //     true to capture the file name, line number, and column number; otherwise, false.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     The parameter e is null.
#pragma warning disable CS0824 // Constructor is marked external
        public extern StackTrace(Exception e, bool fNeedFileInfo);
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Initializes a new instance of the System.Diagnostics.StackTrace class using the
        //     provided exception object and skipping the specified number of frames.
        //
        // Parameters:
        //   e:
        //     The exception object from which to construct the stack trace.
        //
        //   skipFrames:
        //     The number of frames up the stack from which to start the trace.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     The parameter e is null.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     The skipFrames parameter is negative.
#pragma warning disable CS0824 // Constructor is marked external
        public extern StackTrace(Exception e, int skipFrames);
#pragma warning restore CS0824 // Constructor is marked external
        //
        // Summary:
        //     Initializes a new instance of the System.Diagnostics.StackTrace class for a specific
        //     thread, optionally capturing source information. Do not use this constructor
        //     overload.
        //
        // Parameters:
        //   targetThread:
        //     The thread whose stack trace is requested.
        //
        //   needFileInfo:
        //     true to capture the file name, line number, and column number; otherwise, false.
        //
        // Exceptions:
        //   T:System.Threading.ThreadStateException:
        //     The thread targetThread is not suspended.
        [Obsolete("This constructor has been deprecated.  Please use a constructor that does not require a Thread parameter.  http://go.microsoft.com/fwlink/?linkid=14202")]
        public extern StackTrace(Thread targetThread, bool needFileInfo);

        //
        // Summary:
        //     Initializes a new instance of the System.Diagnostics.StackTrace class using the
        //     provided exception object, skipping the specified number of frames and optionally
        //     capturing source information.
        //
        // Parameters:
        //   e:
        //     The exception object from which to construct the stack trace.
        //
        //   skipFrames:
        //     The number of frames up the stack from which to start the trace.
        //
        //   fNeedFileInfo:
        //     true to capture the file name, line number, and column number; otherwise, false.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     The parameter e is null.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     The skipFrames parameter is negative.
#pragma warning disable CS0824 // Constructor is marked external
        public extern StackTrace(Exception e, int skipFrames, bool fNeedFileInfo);
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Gets the number of frames in the stack trace.
        //
        // Returns:
        //     The number of frames in the stack trace.
        public virtual int FrameCount { get; }


        //
        // Summary:
        //     Gets the specified stack frame.
        //
        // Parameters:
        //   index:
        //     The index of the stack frame requested.
        //
        // Returns:
        //     The specified stack frame.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern virtual StackFrame GetFrame(int index);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Returns a copy of all stack frames in the current stack trace.
        //
        // Returns:
        //     An array of type System.Diagnostics.StackFrame representing the function calls
        //     in the stack trace.
        [ComVisible(false)]
        public extern virtual StackFrame[] GetFrames();

        //
        // Summary:
        //     Builds a readable representation of the stack trace.
        //
        // Returns:
        //     A readable representation of the stack trace.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern override string ToString();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

    }

    public class StackFrame
    {
        public const int OFFSET_UNKNOWN = -1;


        //
        // Summary:
        //     Initializes a new instance of the System.Diagnostics.StackFrame class.
#pragma warning disable CS0824 // Constructor is marked external
        public extern StackFrame();
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Initializes a new instance of the System.Diagnostics.StackFrame class, optionally
        //     capturing source information.
        //
        // Parameters:
        //   fNeedFileInfo:
        //     true to capture the file name, line number, and column number of the stack frame;
        //     otherwise, false.
#pragma warning disable CS0824 // Constructor is marked external
        public extern StackFrame(bool fNeedFileInfo);
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Initializes a new instance of the System.Diagnostics.StackFrame class that corresponds
        //     to a frame above the current stack frame.
        //
        // Parameters:
        //   skipFrames:
        //     The number of frames up the stack to skip.
#pragma warning disable CS0824 // Constructor is marked external
        public extern StackFrame(int skipFrames);
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Initializes a new instance of the System.Diagnostics.StackFrame class that corresponds
        //     to a frame above the current stack frame, optionally capturing source information.
        //
        // Parameters:
        //   skipFrames:
        //     The number of frames up the stack to skip.
        //
        //   fNeedFileInfo:
        //     true to capture the file name, line number, and column number of the stack frame;
        //     otherwise, false.
#pragma warning disable CS0824 // Constructor is marked external
        public extern StackFrame(int skipFrames, bool fNeedFileInfo);
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Initializes a new instance of the System.Diagnostics.StackFrame class that contains
        //     only the given file name and line number.
        //
        // Parameters:
        //   fileName:
        //     The file name.
        //
        //   lineNumber:
        //     The line number in the specified file.
#pragma warning disable CS0824 // Constructor is marked external
        public extern StackFrame(string fileName, int lineNumber);
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Initializes a new instance of the System.Diagnostics.StackFrame class that contains
        //     only the given file name, line number, and column number.
        //
        // Parameters:
        //   fileName:
        //     The file name.
        //
        //   lineNumber:
        //     The line number in the specified file.
        //
        //   colNumber:
        //     The column number in the specified file.
#pragma warning disable CS0824 // Constructor is marked external
        public extern StackFrame(string fileName, int lineNumber, int colNumber);
#pragma warning restore CS0824 // Constructor is marked external


        //
        // Summary:
        //     Gets the column number in the file that contains the code that is executing.
        //     This information is typically extracted from the debugging symbols for the executable.
        //
        // Returns:
        //     The file column number, or 0 (zero) if the file column number cannot be determined.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern virtual int GetFileColumnNumber();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Gets the line number in the file that contains the code that is executing. This
        //     information is typically extracted from the debugging symbols for the executable.
        //
        // Returns:
        //     The file line number, or 0 (zero) if the file line number cannot be determined.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern virtual int GetFileLineNumber();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Gets the file name that contains the code that is executing. This information
        //     is typically extracted from the debugging symbols for the executable.
        //
        // Returns:
        //     The file name, or null if the file name cannot be determined.
        [SecuritySafeCritical]
        public extern virtual string GetFileName();

        //
        // Summary:
        //     Gets the offset from the start of the Microsoft intermediate language (MSIL)
        //     code for the method that is executing. This offset might be an approximation
        //     depending on whether or not the just-in-time (JIT) compiler is generating debugging
        //     code. The generation of this debugging information is controlled by the System.Diagnostics.DebuggableAttribute.
        //
        // Returns:
        //     The offset from the start of the MSIL code for the method that is executing.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern virtual int GetILOffset();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Gets the method in which the frame is executing.
        //
        // Returns:
        //     The method in which the frame is executing.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern virtual MethodBase GetMethod();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Gets the offset from the start of the native just-in-time (JIT)-compiled code
        //     for the method that is being executed. The generation of this debugging information
        //     is controlled by the System.Diagnostics.DebuggableAttribute class.
        //
        // Returns:
        //     The offset from the start of the JIT-compiled code for the method that is being
        //     executed.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern virtual int GetNativeOffset();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Builds a readable representation of the stack trace.
        //
        // Returns:
        //     A readable representation of the stack trace.
        [SecuritySafeCritical]
        public extern override string ToString();
    }
}