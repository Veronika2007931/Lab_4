using InternetConnectionClass;
namespace UserClass
{
    public class User : ICloneable
    {
        public string Name { get; set; }
        public string Role {get; set;}
        
        public InternetConnection Connection {get; set;}

        public User(string name, string role, InternetConnection connection)
        {
            Name = name;
            Role = role;
            Connection = connection;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public void ShowInfo()
        {
            Console.WriteLine($"User: {Name} ({Role})");
            Connection.ShowStatus();
        }

        

            
        
    }
}