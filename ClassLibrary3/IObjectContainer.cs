using System;
using System.Collections.Generic;
using System.Text;

namespace BoDi
{
    public interface IObjectContainer : IDisposable
    {
        event Action<object> ObjectCreated;

        bool IsRegistered<T>();
        bool IsRegistered<T>(string name);
        void RegisterFactoryAs<TInterface>(Func<IObjectContainer, TInterface> factoryDelegate, string name = null);
        void RegisterInstanceAs<TInterface>(TInterface instance, string name = null, bool dispose = false) where TInterface : class;
        void RegisterInstanceAs(object instance, Type interfaceType, string name = null, bool dispose = false);
        void RegisterTypeAs<TType, TInterface>(string name = null) where TType : class, TInterface;
        T Resolve<T>();
        T Resolve<T>(string name);
        object Resolve(Type typeToResolve, string name = null);
        IEnumerable<T> ResolveAll<T>() where T : class;
    }
}
