namespace ClassLibrary3
{
    public class Credentials
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern Credentials();
#pragma warning restore CS0824 // Constructor is marked external

        public string Env { get; set; }
        public string Role { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
    }
}