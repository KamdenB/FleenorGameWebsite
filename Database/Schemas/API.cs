using System;

namespace FGWebsite.Schemas
{
    public class Users
    {
        public string UID { get; set; }
        public string Username { get; set; }
        public double Balance { get; set; }
    }

    public class Store 
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }

    public class Logs {
        public string UID { get; set; }
        public string Action { get; set; }
        public string Time { get; set; }
    }
}
