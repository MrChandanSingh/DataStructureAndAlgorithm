using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept
{
    internal class ArrayAndString
    {

        public bool IsUniqueString(string input)
        {
            if (input == null)
                return false;
            if (input.Length == 0)
                return false;
            bool [] char_arr = new bool [input.Length];
            for (int i = 0; i < char_arr.Length; i++)
                char_arr [i] = false;
            for(int i = 0;i < input.Length;i++)
            {
                int index = (int)input[i];
                if (char_arr[i] == true)
                    return false;

                char_arr[i] = true;
            }
            return true;
        }
    }
}
