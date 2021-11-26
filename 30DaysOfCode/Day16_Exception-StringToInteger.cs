using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    public static void Main(string[] args)
    {
        string S = Console.ReadLine();
        Convert(S);
    }
    
    private static void Convert(string value){
        try{
           int intValue = Int32.Parse(value);
            Console.WriteLine(intValue);
        }
        catch(Exception ex){
            Console.WriteLine("Bad String");
        }
    }
}
