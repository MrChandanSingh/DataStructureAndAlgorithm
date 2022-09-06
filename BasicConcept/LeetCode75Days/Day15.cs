using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BasicConcept.LeetCode75Days
{
    public class Day15
    {
        public string ValidIPAddress()
        {
            var queryIP = "192.0.0.1";
            bool isValid = true;
            if (!queryIP.Contains(':') && queryIP.Split('.').Length==4)
            {
                foreach (var str in queryIP.Split('.'))
                {
                    if (!(str.StartsWith("0") && str.Length>1) && int.TryParse(str, out int number))
                    {
                        if (number < 0 || number > 255)
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
                return isValid ? "IPv4" : "Neither";
            }
            else if(queryIP.Split(':').Length == 8)
            {
                foreach (var str in queryIP.Split(':'))
                {
                    if ((str.Length <= 4 && str.Length >= 1) &&
                        Regex.IsMatch(str, "^[0-9a-f0-9A-F0-9]+$"))
                    {
                        continue;
                    }
                    else
                    {
                        isValid = false;
                        break;
                    }

                }
                return isValid ? "IPv6" : "Neither";
            }
            else
            return "Neither";
        }
    }
}
