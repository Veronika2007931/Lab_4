using System.Reflection.Metadata;
using UserClass;

namespace AdminClass
{
    
    public class AdminUser : User
    {
        public string AccessLevel {get; set;}

        public AdminUser(string name, InternetConnection connection, string accesLevel) : base(name, connection)
        {
            AccessLevel = AccessLevelLevel;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"[ADMIN] {Name}, Level: {AccessLevel}");
            Connection.ShowStatus();
        }
    }
    }