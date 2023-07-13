using NewDelegateExample;

internal class Program
{
    public delegate void MyDelegate(int num);
    private static void Main(string[] args)
    {
        //MyDelegate del = new MyDelegate(ShopClass.Choose);
        //del(12);
        //del = ShopClass.Order;
        //del = ShopClass.Pay;
        //del = ShopClass.Packaging;
        //del = ShopClass.Shipping;
        //del = ShopClass.OnBoarding;
        //del.Invoke(12);

        ShopClass shopClass = new ShopClass(15);

        ShopClass.ShopDelegate shopDel = shopClass.Choose;
        shopDel += shopClass.Order;
        shopDel += shopClass.Pay;
        shopDel += shopClass.Packaging;
        shopDel += shopClass.Shipping;
        shopDel += shopClass.OnBoarding;
        shopDel += shopClass.Delivered;
        shopDel();

        ////////Event example for ShopDelegate/////////
        EventClass myEvent = new EventClass();
        myEvent.ShopEvent += shopClass.Order;
        myEvent.ShopEvent += shopClass.Delivered;
        myEvent.StartShopEvent();

        int x = 10;
        int y = 20;
        Class1.Class1Delegate classDel = Class1.Method1;
        classDel += Class1.Method2;
        classDel += Class1.Method3;
        classDel(ref x);

        //////  Event example for Class1Delegate   //////////
       
        myEvent.ProcessEvent += Class1.Method1;
        myEvent.ProcessEvent += Class1.Method2;
        myEvent.ProcessEvent += Class1.Method3;
        myEvent.StartProcess(ref y);



        Console.WriteLine("Hello, World!");
    }

    public static void myEvent_ProcessEvent()
    {
        Console.WriteLine("Process Completed!");

    }
}