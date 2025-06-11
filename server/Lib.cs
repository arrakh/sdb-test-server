using SpacetimeDB;

public static partial class Module
{
    public static void Main()
    {
        
    }

    [Table(Name = "user", Public = true)]
    public partial class User
    {
        [PrimaryKey] public Identity Identity;
        public string? Name;
        public bool Online;
    }

    [Table(Name = "user", Public = true)]
    public partial class Message
    {
        public Identity Sender;
        public Timestamp Sent;
        public string Text = "";
    }
}
