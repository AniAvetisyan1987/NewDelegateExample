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


        int x = 10;
        Class1.Class1Delegate classDel = Class1.Method1;
        classDel += Class1.Method2;
        classDel += Class1.Method3;
        classDel(ref x);



        Console.WriteLine("Hello, World!");
    }
}