using System;
using System.Collections.Generic;
using System.Text;

namespace TechTalk.SpecFlow
{
#pragma warning disable CS0436 // Type conflicts with imported type
    public abstract class SpecFlowContext : Dictionary<string, object>, IDisposable
#pragma warning restore CS0436 // Type conflicts with imported type
    {
#pragma warning disable CS0824 // Constructor is marked external
        protected extern SpecFlowContext();
#pragma warning restore CS0824 // Constructor is marked external

#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern T Get<T>();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern T Get<T>(string key);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Set<T>(T data);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Set<T>(T data, string key);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Set<T>(Func<T> func);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern bool TryGetValue<TValue>(out TValue value);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern bool TryGetValue<TValue>(string key, out TValue value);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern virtual void Dispose();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

#pragma warning disable CS0436 // Type conflicts with imported type
        void IDisposable.Dispose()
#pragma warning restore CS0436 // Type conflicts with imported type
        {
            throw new NotImplementedException();
        }
    }
}
