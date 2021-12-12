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



static class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        // Write your code here
        bubbleSort(n,a);
        
       
      
    }
    
     static void printArray(int numSwaps, List<int> toBeSortedList) {
        Console.WriteLine($"Array is sorted in {numSwaps} swaps.");       
        Console.WriteLine($"First Element: {toBeSortedList.FirstOrDefault()}");
        Console.WriteLine($"Last Element: {toBeSortedList.LastOrDefault()}");
         }
        static void bubbleSort(int length,List<int> toBeSortedList) {        
                        
          int numSwaps = 0;

            for(int i = 0; i < length; i++) {
                
            for (int j = 0; j < length - 1; j++) {
                
                if( toBeSortedList[j] > toBeSortedList[j + 1] ){
                    // Swap elements 'j' and 'j + 1':
                    int tmp = toBeSortedList[j];
                    toBeSortedList[j] = toBeSortedList[j + 1];
                    toBeSortedList[j + 1] = tmp;

                    numSwaps++;                                       
                } // end if
                
                }
               
            } 
             printArray(numSwaps,toBeSortedList);
    }
    
        
}
