
using InterfacesFile;
namespace ProductsClass
{
    class SilverEarrings : IEarrings {public void ShowInfo()=>Console.WriteLine("Сережки: Срібло з цирконієм");}
    class SilverRings : IRing {public void ShowInfo()=>Console.WriteLine("Кільце : Срібло з цирконієм");}
    class SilverChain : IChain {public void ShowInfo()=>Console.WriteLine("Ланцюжок: Срібло з цирконієм");}
    class SilverBracelet : IBracelet {public void ShowInfo()=>Console.WriteLine("Браслет: Срібло з цирконієм");}


    class GoldEarrings : IEarrings {public void ShowInfo()=>Console.WriteLine("Сережки: Жовте золото з цирконієм");}
    class GoldRing : IRing {public void ShowInfo()=>Console.WriteLine("Кільце : Жовте золото з цирконієм");}
    class GoldChain : IChain {public void ShowInfo()=>Console.WriteLine("Ланцюжок: Жовте золото з цирконієм");}
    class GoldBracelet : IBracelet {public void ShowInfo()=>Console.WriteLine("Браслет: Жовте золото з цирконієм");}

    class DiamondEarrings : IEarrings {public void ShowInfo()=>Console.WriteLine("Сережки: Біле золото з діамантами");}
    class DiamondRing : IRing {public void ShowInfo()=>Console.WriteLine("Кільце : Біле золото з діамантами");}
    class DiamondChain : IChain {public void ShowInfo()=>Console.WriteLine("Ланцюжок: Біле золото з діамантами");}
    class DiamondBracelet : IBracelet {public void ShowInfo()=>Console.WriteLine("Браслет: Біле золото з діамантами");}



    public class BudgetJewelryFactory : IJewelryFactory
    {
        public IEarrings CreateEarrings() => new SilverEarrings();
        public IRing CreateRing() => new SilverRings();
        public IChain CreateChain() => new SilverChain();
        public IBracelet CreateBracelet() => new SilverBracelet();
    }

    public class MiddleJewelryFactory : IJewelryFactory
    {
        public IEarrings CreateEarrings() => new GoldEarrings();
        public IRing CreateRing() => new GoldRing();
        public IChain CreateChain() => new GoldChain();
        public IBracelet CreateBracelet() => new GoldBracelet();
    }
    
    public class LuxuryJewelryFactory : IJewelryFactory
    {
        public IEarrings CreateEarrings() => new DiamondEarrings();
        public IRing CreateRing() => new DiamondRing();
        public IChain CreateChain() => new DiamondChain();
        public IBracelet CreateBracelet() => new DiamondBracelet();
    }
    
}
