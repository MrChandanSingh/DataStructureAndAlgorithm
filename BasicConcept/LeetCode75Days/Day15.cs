using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BasicConcept.LeetCode75Days
{
    public class Day15
    {
        public void ValidIPAddress()
        {
            var queryIP = "2001:db8:85a3:0:0:8A2eb:0370:7334";
            bool isValid = true;
            if (!queryIP.Contains(':'))
            {
                if(queryIP.Split('.').Length ==4)
                {
                    foreach (var str in queryIP.Split('.'))
                    {
                        if (str.StartsWith("0") && int.TryParse(str, out int number))
                        {
                            if (number < 0 && number > 255)
                            {
                                isValid = false;
                                break;
                            }
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }

                    }
                }
            }
            else
            {
                if (queryIP.Split(':').Length == 8)
                {
                    foreach (var str in queryIP.Split(':'))
                    {
                        if ((str.Length <= 4 && str.Length >= 1) && Regex.IsMatch(str, "^[0-9a-f0-9A-F0-9]+$"))
                        {
                            continue;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }

                    }

                }
                
            }
            

           Console.WriteLine(isValid);
        }
    }
}
