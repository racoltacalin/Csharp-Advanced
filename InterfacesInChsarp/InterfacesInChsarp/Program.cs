using System;

namespace InterfacesInChsarp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car myCar = new Car();
            //Console.WriteLine(myCar);

            Phone myPhone = new Phone();
            myPhone.Name = "Iphone 11";
            myPhone.Call();

            SmartPhone mySmartPhone = new SmartPhone();
            mySmartPhone.Name = "Iphone 11 Pro Max";
            mySmartPhone.Call();
        }
    }
}
