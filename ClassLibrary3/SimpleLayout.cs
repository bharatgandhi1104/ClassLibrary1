using System.Collections.ObjectModel;
using System.Text;
using NLog.Config;
using NLog.Internal;
using NLog.LayoutRenderers;

namespace NLog.Layouts
{
    public class SimpleLayout : Layout, IUsesStackTrace
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern SimpleLayout();
#pragma warning restore CS0824 // Constructor is marked external
        //
        // Summary:
        //     Initializes a new instance of the NLog.Layouts.SimpleLayout class.
        //
        // Parameters:
        //   txt:
        //     The layout string to parse.
#pragma warning disable CS0824 // Constructor is marked external
        public extern SimpleLayout(string txt);
#pragma warning restore CS0824 // Constructor is marked external
        //
        // Summary:
        //     Initializes a new instance of the NLog.Layouts.SimpleLayout class.
        //
        // Parameters:
        //   txt:
        //     The layout string to parse.
        //
        //   configurationItemFactory:
        //     The NLog factories to use when creating references to layout renderers.
#pragma warning disable CS0824 // Constructor is marked external
        public extern SimpleLayout(string txt, ConfigurationItemFactory configurationItemFactory);
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Get the fixed text. Only set when NLog.Layouts.SimpleLayout.IsFixedText is true
        public string FixedText { get; }
        //
        // Summary:
        //     Is the message fixed? (no Layout renderers used)
        public bool IsFixedText { get; }
        //
        // Summary:
        //     Gets or sets the layout text.
        public string Text { get; set; }
        //
        // Summary:
        //     Original text before compile to Layout renderes
        public string OriginalText { get; }
        //
        // Summary:
        //     Gets a collection of NLog.LayoutRenderers.LayoutRenderer objects that make up
        //     this layout.
        public ReadOnlyCollection<LayoutRenderer> Renderers { get; }
        //
        // Summary:
        //     Gets the level of stack trace information required for rendering.
        public StackTraceUsage StackTraceUsage { get; }


        //
        // Summary:
        //     Escapes the passed text so that it can be used literally in all places where
        //     layout is normally expected without being treated as layout.
        //
        // Parameters:
        //   text:
        //     The text to be escaped.
        //
        // Returns:
        //     The escaped text.
        //
        // Remarks:
        //     Escaping is done by replacing all occurrences of '${' with '${literal:text=${}'
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern string Escape(string text);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Evaluates the specified text by expanding all layout renderers in new NLog.LogEventInfo
        //     context.
        //
        // Parameters:
        //   text:
        //     The text to be evaluated.
        //
        // Returns:
        //     The input text with all occurrences of ${} replaced with values provided by the
        //     appropriate layout renderers.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern string Evaluate(string text);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Evaluates the specified text by expanding all layout renderers.
        //
        // Parameters:
        //   text:
        //     The text to be evaluated.
        //
        //   logEvent:
        //     Log event to be used for evaluation.
        //
        // Returns:
        //     The input text with all occurrences of ${} replaced with values provided by the
        //     appropriate layout renderers.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern string Evaluate(string text, LogEventInfo logEvent);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Returns a System.String that represents the current object.
        //
        // Returns:
        //     A System.String that represents the current object.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern override string ToString();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Renders the layout for the specified logging event by invoking layout renderers
        //     that make up the event.
        //
        // Parameters:
        //   logEvent:
        //     The logging event.
        //
        // Returns:
        //     The rendered layout.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern override string GetFormattedMessage(LogEventInfo logEvent);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Initializes the layout.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern override void InitializeLayout();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Renders the layout for the specified logging event by invoking layout renderers
        //     that make up the event.
        //
        // Parameters:
        //   logEvent:
        //     The logging event.
        //
        //   target:
        //     System.Text.StringBuilder for the result
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern override void RenderFormattedMessage(LogEventInfo logEvent, StringBuilder target);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Converts a text to a simple layout.
        //
        // Parameters:
        //   text:
        //     Text to be converted.
        //
        // Returns:
        //     A NLog.Layouts.SimpleLayout object.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern implicit operator SimpleLayout(string text);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}