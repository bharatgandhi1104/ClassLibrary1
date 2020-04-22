using System;
using System.Collections.Generic;
using System.Text;

using BoDi;

namespace TechTalk.SpecFlow.Infrastructure
{
    public interface IContainerDependentObject
    {
        void SetObjectContainer(IObjectContainer container);
    }
}
