namespace InterfacesFile
{
  public  interface IEarrings
    {
        void ShowInfo();
    }
    public  interface IRing
    {
        void ShowInfo();
    }
    public  interface IChain
    {
        void ShowInfo();
    }
    public  interface IBracelet
    {
        void ShowInfo();
    }

    public interface IJewelryFactory
    {
        IEarrings CreateEarrings();
        IRing CreateRing();

        IChain CreateChain();

        IBracelet CreateBracelet();
    }
}