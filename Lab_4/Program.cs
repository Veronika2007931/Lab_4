using InternetConnectionClass;
using UserClass;
using AdminClass;
using Guestclass;
 using ProductsClass;
using InterfacesFile;
class Programe
{
    
    static void Main(string[] args)
    {
//         Console.OutputEncoding = System.Text.Encoding.UTF8;

//         InternetConnection sharedConnection = new InternetConnection("192.168.1.1", 100);
     

//         AdminUser adminTemplate = new AdminUser("Veronika", sharedConnection, "High");
//         GuestUser guestTemplate = new GuestUser("Vova", sharedConnection, DateTime.Now.AddHours(2));

//         AdminUser newAdmin = (AdminUser)adminTemplate.Clone();
//         newAdmin.Name = "Karina";
//         newAdmin.ShowInfo();

//         GuestUser newGuest = (GuestUser)guestTemplate.Clone();
//             newGuest.Name = "Natalia";
//             newGuest.ShowInfo();

// bool sameNet = ReferenceEquals(newAdmin.Connection, newGuest.Connection);
//             Console.WriteLine($"Інтернет спільний для Адміна і Гостя? -> {sameNet}");

IJewelryFactory budgetFactory = new BudgetJewelryFactory();
ProduceJewelrySet(budgetFactory);

IJewelryFactory middleFactory = new MiddleJewelryFactory();
ProduceJewelrySet(middleFactory);

IJewelryFactory luxuryFactory = new LuxuryJewelryFactory();
ProduceJewelrySet(luxuryFactory);


Console.ReadKey();
        }

        static void ProduceJewelrySet(IJewelryFactory factory)
    {
        var earrings = factory.CreateEarrings();
        var ring = factory.CreateRing();
        var chain = factory.CreateChain();
        var bracelet = factory.CreateBracelet();

        Console.WriteLine("Виготовлено сет:");
            earrings.ShowInfo();
            ring.ShowInfo();
            chain.ShowInfo();
            bracelet.ShowInfo();
    }
    }

