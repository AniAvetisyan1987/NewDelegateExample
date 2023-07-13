using static NewDelegateExample.Class1;
using static NewDelegateExample.ShopClass;

namespace NewDelegateExample
{
    internal class EventClass
    {
        public event Class1Delegate ProcessEvent;

        public event ShopDelegate ShopEvent;

        public void StartProcess(ref int num)
        {
            Console.WriteLine("Process started");
            OnProcessEvent(ref num);
        }

        public virtual void OnProcessEvent(ref int num)
        {
            ProcessEvent?.Invoke(ref num);
        }

        public void StartShopEvent()
        {
            Console.WriteLine("Shop Event Process Started");
            OnShopEvent();
        }
        
        public virtual void OnShopEvent()
        {
            ShopEvent?.Invoke();
        }
    }
}
