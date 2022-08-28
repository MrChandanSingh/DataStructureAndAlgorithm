using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept
{
    public abstract class AbstractProblem
    {
        public abstract string Name { get; }

        public abstract string VirtualMethod(string str1);

        public virtual string AbstractTest()
        {
            return "Chandan";
        }
        // This method is not going to be overriden in base class and it will be hidden.
        private void SetBaseModelDesignWithSystem()
        {
            Console.WriteLine("Hi this method added base model design");
        }
    }

    public class AbstractProblem2 : AbstractProblem
    {
        public override string Name => throw new NotImplementedException();

        public override string VirtualMethod(string str1)
        {
            throw new NotImplementedException();
        }

        public new string AbstractTest()
        {
            return string.Empty;
        }
    }

    public class CheckStaticClassFunctionality
    {
        public CheckStaticClassFunctionality(string name)
        {
            Console.WriteLine($"Base Constructor!!! {name}");
        }
    }

    public class DerivedClass: CheckStaticClassFunctionality
    {
        private string name = "chandan";
        public DerivedClass(string name): base(name){
            Console.WriteLine(name);
        }
    }
}
