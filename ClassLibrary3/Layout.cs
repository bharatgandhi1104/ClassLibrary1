using System;
using System.ComponentModel;
using System.Text;
using NLog.Config;
using NLog.Internal;

namespace NLog.Layouts
{
    public abstract class Layout : ISupportsInitialize, IRenderable
    {
#pragma warning disable CS0824 // Constructor is marked external
        protected extern Layout();
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Gets the logging configuration this target is part of.
        protected LoggingConfiguration LoggingConfiguration { get; }


        //
        // Summary:
        //     Implicitly converts the specified string to a NLog.Layouts.SimpleLayout.
        //
        // Parameters:
        //   layoutText:
        //     The layout string.
        //
        // Returns:
        //     Instance of NLog.Layouts.SimpleLayout.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern Layout FromString(string layoutText);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Implicitly converts the specified string to a NLog.Layouts.SimpleLayout.
        //
        // Parameters:
        //   layoutText:
        //     The layout string.
        //
        //   configurationItemFactory:
        //     The NLog factories to use when resolving layout renderers.
        //
        // Returns:
        //     Instance of NLog.Layouts.SimpleLayout.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern Layout FromString(string layoutText, ConfigurationItemFactory configurationItemFactory);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Register a custom Layout.
        //
        // Parameters:
        //   name:
        //     Name of the Layout.
        //
        // Type parameters:
        //   T:
        //     Type of the Layout.
        //
        // Remarks:
        //     Short-cut for registing to default NLog.Config.ConfigurationItemFactory
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern void Register<T>(string name) where T : Layout;
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Register a custom Layout.
        //
        // Parameters:
        //   layoutType:
        //     Type of the Layout.
        //
        //   name:
        //     Name of the Layout.
        //
        // Remarks:
        //     Short-cut for registing to default NLog.Config.ConfigurationItemFactory
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern void Register(string name, Type layoutType);

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void Initialize(LoggingConfiguration configuration)
        {
            throw new NotImplementedException();
        }
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Precalculates the layout for the specified log event and stores the result in
        //     per-log event cache. Only if the layout doesn't have [ThreadAgnostic] and doens't
        //     contain layouts with [ThreadAgnostic].
        //
        // Parameters:
        //   logEvent:
        //     The log event.
        //
        // Remarks:
        //     Calling this method enables you to store the log event in a buffer and/or potentially
        //     evaluate it in another thread even though the layout may contain thread-dependent
        //     renderer.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public virtual extern void Precalculate(LogEventInfo logEvent);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Renders the event info in layout.
        //
        // Parameters:
        //   logEvent:
        //     The event info.
        //
        // Returns:
        //     String representing log event.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern string Render(LogEventInfo logEvent);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Closes the layout.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern virtual void CloseLayout();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Renders the layout for the specified logging event by invoking layout renderers.
        //
        // Parameters:
        //   logEvent:
        //     The logging event.
        //
        // Returns:
        //     The rendered layout.
        protected abstract string GetFormattedMessage(LogEventInfo logEvent);

        //
        // Summary:
        //     Initializes the layout.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern virtual void InitializeLayout();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Renders the layout for the specified logging event by invoking layout renderers.
        //
        // Parameters:
        //   logEvent:
        //     The logging event.
        //
        //   target:
        //     System.Text.StringBuilder for the result
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern virtual void RenderFormattedMessage(LogEventInfo logEvent, StringBuilder target);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Converts a given text to a NLog.Layouts.Layout.
        //
        // Parameters:
        //   text:
        //     Text to be converted.
        //
        // Returns:
        //     NLog.Layouts.SimpleLayout object represented by the text.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern implicit operator Layout([Localizable(false)] string text);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}