﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace System
{
    //
    // Summary:
    //     Provides a mechanism for releasing unmanaged resources.To browse the .NET Framework
    //     source code for this type, see the Reference Source.
    [ComVisible(true)]
    public interface IDisposable
    {
        //
        // Summary:
        //     Performs application-defined tasks associated with freeing, releasing, or resetting
        //     unmanaged resources.
        void Dispose();
    }
}
