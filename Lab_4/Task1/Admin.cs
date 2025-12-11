using System.Reflection.Metadata;
using UserClass;
using InternetConnectionClass;

namespace AdminClass
{
    
    public class AdminUser : User
    {
        public string AccessLevel {get; set;}

        public AdminUser(string name, InternetConnection connection, string accesLevel) : base(name, connection)
        {
            AccessLevel = accesLevel;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"[ADMIN] {Name}, Level: {AccessLevel}");
            Connection.ShowStatus();
        }
    }
    }