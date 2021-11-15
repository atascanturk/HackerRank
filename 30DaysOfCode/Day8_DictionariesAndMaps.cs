using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        
        var n =Int32.Parse(Console.ReadLine());
        
        for(var i = 0 ; i<n; i++){
            
            string[] nameAndPhoneNumber = Console.ReadLine().Split(' ');
            phoneBook[nameAndPhoneNumber[0]] = nameAndPhoneNumber[1];            
            
        }
        string name;
           while (( name = Console.ReadLine()) != null) {
                    
              
               
                if(phoneBook.ContainsKey(name)){                                     
                   Console.WriteLine($"{name}={phoneBook[name]}"); 
                }
                else
                {
                Console.WriteLine("Not found");
                }
            
           } 
        
         
    }
}
