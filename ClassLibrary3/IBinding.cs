using TechTalk.SpecFlow.Bindings.Reflection;

namespace TechTalk.SpecFlow.Bindings
{
    public interface IBinding
    {
        IBindingMethod Method { get; }
    }
}