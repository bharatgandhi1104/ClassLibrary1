using NLog.Config;

namespace NLog.Internal
{
    public interface ISupportsInitialize
    {
        void Close();
        void Initialize(LoggingConfiguration configuration);
    }
}