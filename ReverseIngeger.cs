using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Solution result=new Solution();
            Console.WriteLine("{0}", result.Reverse(-321));
            
            Console.WriteLine("Hello, world!");
        }
    }
    
    public class Solution 
    {
        public int Reverse(int x) 
        {
            try
                {
                char[] charArray= x.ToString().ToCharArray();
                if(charArray[0]!='-')
                {
                    List<char> charList=new List<char>();
                    for (var i=0; i<charArray.Length;i++)
                    {
                        charList.Add(charArray[charArray.Length-i-1]);
                    }
                    
                    char[] charArrayAfter=charList.ToArray();
                    StringBuilder builder=new StringBuilder();
                    foreach(var value in charArrayAfter)
                    {
                        builder.Append(value);
                    }
                    return Int32.Parse(builder.ToString());
                }else{
                    List<char> charList=new List<char>();
                    for (var i=1; i<charArray.Length;i++)
                    {
                        charList.Add(charArray[charArray.Length-i]);
                    }
                    
                    char[] charArrayAfter=charList.ToArray();
                    StringBuilder builder=new StringBuilder();
                    foreach(var value in charArrayAfter)
                    {
                        builder.Append(value);
                    }
                    int number=Int32.Parse(builder.ToString());
                    return number-2*number;
                }
            }
            catch(OverflowException)
            {
                return 0;
            }
            
        }
    }
    
}
