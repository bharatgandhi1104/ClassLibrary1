using System;
using System.Globalization;
using System.Text;
using NLog.Config;
using NLog.Internal;
using NLog.Layouts;

namespace NLog.LayoutRenderers
{
    public class LayoutRenderer : ISupportsInitialize, IRenderable, IDisposable
    {
#pragma warning disable CS0824 // Constructor is marked external
        protected extern LayoutRenderer();
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Gets the logging configuration this target is part of.
        protected LoggingConfiguration LoggingConfiguration { get; }


        //
        // Summary:
        //     Register a custom layout renderer.
        //
        // Parameters:
        //   name:
        //     Name of the layout renderer - without ${}.
        //
        // Type parameters:
        //   T:
        //     Type of the layout renderer.
        //
        // Remarks:
        //     Short-cut for registing to default NLog.Config.ConfigurationItemFactory
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern void Register<T>(string name) where T : LayoutRenderer;
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Register a custom layout renderer.
        //
        // Parameters:
        //   layoutRendererType:
        //     Type of the layout renderer.
        //
        //   name:
        //     Name of the layout renderer - without ${}.
        //
        // Remarks:
        //     Short-cut for registing to default NLog.Config.ConfigurationItemFactory
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern void Register(string name, Type layoutRendererType);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Register a custom layout renderer with a callback function func. The callback
        //     recieves the logEvent.
        //
        // Parameters:
        //   name:
        //     Name of the layout renderer - without ${}.
        //
        //   func:
        //     Callback that returns the value for the layout renderer.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern void Register(string name, Func<LogEventInfo, object> func);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Register a custom layout renderer with a callback function func. The callback
        //     recieves the logEvent and the current configuration.
        //
        // Parameters:
        //   name:
        //     Name of the layout renderer - without ${}.
        //
        //   func:
        //     Callback that returns the value for the layout renderer.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern void Register(string name, Func<LogEventInfo, LoggingConfiguration, object> func);

        public void Close()
        {
            throw new NotImplementedException();
        }
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Performs application-defined tasks associated with freeing, releasing, or resetting
        //     unmanaged resources.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Dispose();

        public void Initialize(LoggingConfiguration configuration)
        {
            throw new NotImplementedException();
        }
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Renders the the value of layout renderer in the context of the specified log
        //     event.
        //
        // Parameters:
        //   logEvent:
        //     The log event.
        //
        // Returns:
        //     String representation of a layout renderer.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern string Render(LogEventInfo logEvent);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Returns a System.String that represents this instance.
        //
        // Returns:
        //     A System.String that represents this instance.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern override string ToString();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Renders the specified environmental information and appends it to the specified
        //     System.Text.StringBuilder.
        //
        // Parameters:
        //   builder:
        //     The System.Text.StringBuilder to append the rendered data to.
        //
        //   logEvent:
        //     Logging event.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern void Append(StringBuilder builder, LogEventInfo logEvent);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Closes the layout renderer.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern virtual void CloseLayoutRenderer();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Releases unmanaged and - optionally - managed resources.
        //
        // Parameters:
        //   disposing:
        //     True to release both managed and unmanaged resources; false to release only unmanaged
        //     resources.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern virtual void Dispose(bool disposing);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Get the System.Globalization.CultureInfo for rendering the messages to a System.String,
        //     needed for date and number formats
        //
        // Parameters:
        //   logEvent:
        //     LogEvent with culture
        //
        //   layoutCulture:
        //     Culture in on Layout level
        //
        // Remarks:
        //     NLog.LayoutRenderers.LayoutRenderer.GetFormatProvider(NLog.LogEventInfo,System.IFormatProvider)
        //     is preferred
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern CultureInfo GetCulture(LogEventInfo logEvent, CultureInfo layoutCulture = null);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Get the System.IFormatProvider for rendering the messages to a System.String
        //
        // Parameters:
        //   logEvent:
        //     LogEvent with culture
        //
        //   layoutCulture:
        //     Culture in on Layout level
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern IFormatProvider GetFormatProvider(LogEventInfo logEvent, IFormatProvider layoutCulture = null);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Initializes the layout renderer.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern virtual void InitializeLayoutRenderer();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}