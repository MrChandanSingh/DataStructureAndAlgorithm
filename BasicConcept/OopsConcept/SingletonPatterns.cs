using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept.OopsConcept
{
    public sealed class SingletonPatterns
    {
        public static SingletonPatterns singletonPattern;

        private SingletonPatterns()
        { }

        public static SingletonPatterns singletonPatterns {
            get
            {
                lock (singletonPattern)
                { 
                if (singletonPattern == null)
                    singletonPattern = new SingletonPatterns();
                }
                return singletonPattern;
            }
        }
        
    }
}
