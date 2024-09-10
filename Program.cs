namespace PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // object intializer
            //User user = new() { Age = 10, Name = "" };
            //var user = new { Age = 10, Name = "" };
            //User user = new();



        }
    }

    //partal classes

    partial class User
    {
        public int Age { get; set; }
        public void Welcome() { }
    }

    partial class User
    {
        public string Name { get; set; }
        public void HI() { }
    }
}
