using System;
using System.Collections.Generic;

namespace LiveCoding2
{
    class Program
    {
        static void Main(string[] args)
        {
                        {
                string longstring = "bdsagbgagggaaatttyyyyau";
                int i = 0;
                int count = 0;
                int count2 = 0;
                
                foreach (char character in longstring)
                {
                    char x = longstring[i];
                    if (longstring[i] == longstring[i + 1] && i<longstring.Length-1){
                        count++;
                        i++;

                    }
                    else
                    {
                        i++;
                    }
                    count2 = count;
                    if (count2 > count){
                        Console.WriteLine(longstring[i]);
                    }
                }
                Console.WriteLine($"Welp Count2:{count2} Count: {count}");
            }


        }
    }
}
