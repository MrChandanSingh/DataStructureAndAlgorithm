using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicConcept.LeetCode75Days
{
    public class Day8
    {
        public bool IsValidExpression(string str)
        {
            if(str == null)
                return false;
           var stack = new Stack<char>();
            foreach(var c in str)
            {
                if (c == '(')
                    stack.Push(c);
                if(c == ')')
                {
                    var element = stack.Peek();
                    if (element != '(')
                        continue;
                    else
                        stack.Pop();
                }

                if(c == '[')
                    stack.Push(c);
                if(c==']')
                {
                    var element = stack.Peek();
                    if (element != '[')
                        continue;
                    else 
                        stack.Pop();
                }

                if (c == '{')
                    stack.Push(c);
                if (c == '}')
                {
                    var element = stack.Peek();
                    if (element != '{')
                        continue;
                    else
                        stack.Pop();
                }
            }
            return stack.Count>0? false: true;

        }

        public void GetMaxCountOfElement(int [] arr)
        {
            
            var groupBy = arr.GroupBy(x => x).Select(x => new
            {
                x.Key,
                count = x.Count()
            }).OrderByDescending(x=>x.count).FirstOrDefault().Key;

            Console.WriteLine(groupBy);

            var str = "chandan";
            var result = str.ConcateTwoString("kumar");
            Console.WriteLine(result);

        }
    }

    public static  class StringExtension       

    {
        public static string ConcateTwoString(this string s1,string s2)
        {
            return $"{s1} : {s2}";
        }
    }
}
