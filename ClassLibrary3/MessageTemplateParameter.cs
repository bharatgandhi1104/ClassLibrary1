using System;

namespace NLog
{
    public class MessageTemplateParameter
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern MessageTemplateParameter([NotNullAttribute] string name, object value, string format, CaptureType captureType);
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Parameter Name extracted from NLog.LogEventInfo.Message This is everything between
        //     "{" and the first of ",:}".
        [NotNullAttribute]
        public string Name { get; }
        //
        // Summary:
        //     Parameter Value extracted from the NLog.LogEventInfo.Parameters-array
        [CanBeNullAttribute]
        public object Value { get; }
        //
        // Summary:
        //     Format to render the parameter. This is everything between ":" and the first
        //     unescaped "}"
        [CanBeNullAttribute]
        public string Format { get; }
        //
        // Summary:
        //     Parameter method that should be used to render the parameter See also NLog.IValueFormatter
        public CaptureType CaptureType { get; }
        //
        // Summary:
        //     Returns index for NLog.LogEventInfo.Parameters, when NLog.MessageTemplates.MessageTemplateParameters.IsPositional
        public int? PositionalIndex { get; }
    }

    internal class CanBeNullAttribute : Attribute
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern CanBeNullAttribute();
#pragma warning restore CS0824 // Constructor is marked external
    }
}