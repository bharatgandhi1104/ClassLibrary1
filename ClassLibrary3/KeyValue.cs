namespace ClassLibrary3
{
    public class KeyValue
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern KeyValue();
#pragma warning restore CS0824 // Constructor is marked external

        public string Key { get; set; }
        public string Value { get; set; }
    }
}