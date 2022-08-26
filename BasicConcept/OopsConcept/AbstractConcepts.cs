using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept.OopsConcept
{
    public abstract class AbstractConcepts
    {
        // This method is going to be mandatorly implemented in derived class..
        public abstract string GetConnection();

        // this virtual method can be override in derived class with override key word...
        // It is not mandatory to be implemented in derieved class. it is totally optional.
        public virtual string GetVirtualConnection()
        {
            Console.WriteLine("Base class virtual function GetVirtualConnection");
            return null;
        }

        //This is non virutal, abstract method. So this method can't be override in derived class.
        public string GetNonAbstractClass()
        {
            Console.WriteLine("Base class non virtual, abstract function GetNonAbstractClass");
            return null;
        }
    }

    public class DerivedClass : AbstractConcepts
    {
        public override string GetConnection()
        {
            Console.WriteLine("Derived class: override virtual function GetConnection.");
            return string.Empty;
        }

        public override string GetVirtualConnection()
        {
            Console.WriteLine("Derived class: override virtual function GetVirtualConnection.");
            return string.Empty;
        }
    }
}
