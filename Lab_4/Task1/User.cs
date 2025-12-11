using InternetConnectionClass;
namespace UserClass
{
    public abstract class User : ICloneable
    {
        public string Name { get; set; }
        public InternetConnection Connection {get; set;}
   

        public User(string name,  InternetConnection connection)
        {
            Name = name;
            Connection = connection;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public abstract void ShowInfo();
            
    }
}