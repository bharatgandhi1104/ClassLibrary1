using System;

namespace NLog
{
    public sealed class MessageTemplateFormatMethodAttribute : Attribute
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern MessageTemplateFormatMethodAttribute(string parameterName);
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     The name of the parameter that should be as treated as message-template-string
        public string ParameterName { get; }

    }
}