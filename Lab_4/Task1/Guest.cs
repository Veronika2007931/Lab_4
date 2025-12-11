using UserClass;
using InternetConnectionClass;
namespace Guestclass{

   public class GuestUser : User
   {

     public DateTime ExpiryDate { get; set; }

    public GuestUser(string name, InternetConnection connection, DateTime expiry) 
            : base(name, connection)
        {
            ExpiryDate = expiry;
        }

    public override void ShowInfo()
        {
            Console.WriteLine($"[GUEST] {Name}, Expires: {ExpiryDate.ToShortTimeString()}");
            Connection.ShowStatus();
        }    
   }
}