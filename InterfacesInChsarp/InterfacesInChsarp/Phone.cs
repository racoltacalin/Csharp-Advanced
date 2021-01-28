using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesInChsarp
{
    interface IMobile
    {
        public string Name { get; }
        void Call();
    }
    public class Phone : IMobile
    {
        public virtual string Name { get; set; }
        public virtual void Call()
        {
            Console.WriteLine("This is Phone class with name {0} implements IMobile interface!", Name);
        }
    }

    public class SmartPhone : Phone
    {
        public override string Name { get; set; }
        public override void Call()
        {
            Console.WriteLine("This is SmartPhone class withn name {0} inherit from Phone class which implements the IMobile interface!", Name);
        }
    }
}
