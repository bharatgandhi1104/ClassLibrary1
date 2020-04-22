namespace NLog.Layouts
{
    internal interface IRenderable
    {
        string Render(LogEventInfo logEvent);
    }
}