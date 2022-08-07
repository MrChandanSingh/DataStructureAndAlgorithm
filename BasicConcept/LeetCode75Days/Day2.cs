using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicConcept.LeetCode75Days
{
    public class Day2
    {
        public bool IsIsoMorphic(string s, string t)
        {
            Hashtable hashTable = new Hashtable();
            var length = s.Length;
            if(length != t.Length)
                return false;
            Hashtable mappingSecondString = new Hashtable();
            for(int i = 0; i < length; i++)
            {
                if(!mappingSecondString.ContainsKey(t[i]))
                    mappingSecondString.Add(t[i], false);
            }
            for(int i = 0; i < length; i++)
            {
                if(hashTable.Count ==0)
                {
                    hashTable[s[i]] = t[i];
                    mappingSecondString[t[i]] = true;
                }
                  
                else
                {
                    if (hashTable.ContainsKey(s[i]))
                    {
                        if (t[i] == Convert.ToChar(hashTable[s[i]]))
                            continue;
                        else
                            return false;
                    }
                    else if (Convert.ToBoolean(mappingSecondString[t[i]]) == false)
                    {

                        hashTable[s[i]] = t[i];
                        mappingSecondString[t[i]] = true;
                    }
                    else
                        return false;
                }
            }

            return true;
        }

        public bool IsSubsequence(string s, string t)
        {
            if (s == "")
                return true;
            
            var tempTString = string.Empty;
            for(int i=0;i<s.Length;i++)
            {
                for(int j=0;j<t.Length;j++)
                {
                    if(t[j] == s[i])
                    {
                        tempTString+=t[j];
                       t = t.Remove(j,1);
                       break;
                    }
                    else
                    {
                       t= t.Remove(j, 1);
                        j--;
                    }
                }
            }
            if(s == tempTString)
                return true;
            return false;
        }
    }
}
