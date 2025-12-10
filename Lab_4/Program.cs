using InternetConnectionClass;
using UserClass;

class Programe
{
    
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        InternetConnection sharedConnection = new InternetConnection("192.168.1.1", 100);
        User admin = new User("Veronika", "Admin", sharedConnection);

        admin.ShowInfo();

        User guest = (User)admin.Clone();
        guest.Name = "Volodymyr";
        guest.Role = "Visitor";

        admin.ShowInfo();
        guest.ShowInfo();

        bool isSameConnection = ReferenceEquals(admin.Connection, guest.Connection);
        Console.WriteLine($"Чи є з'єднання одним і тим самим об'єктом? -> {isSameConnection}");
        if (isSameConnection)
        {
            Console.WriteLine("Успіх! З'єднання не дублювалося.");
        }
        else
        {
            Console.WriteLine("Помилка! З'єднання було скопійовано.");
        }

        
    }
}
