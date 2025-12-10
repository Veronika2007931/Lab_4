namespace InternetConnectionClass
{
    public class InternetConnection
{
    public string IPAdress { get; set; }
    public int Speed { get; set; }

    public InternetConnection(string IP, int speed)
    {
        IPAdress = IP;
        Speed = speed;
    }

    public void ShowStatus()
    {
        Console.WriteLine($"IP: {IPAdress}, Speed: {Speed} Mb/s");
    }
    
}
}