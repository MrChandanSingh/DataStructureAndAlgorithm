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
}
