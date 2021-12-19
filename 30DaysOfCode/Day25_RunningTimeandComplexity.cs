using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
     
     int N = Convert.ToInt32(Console.ReadLine());
        int i, j,number;
        string output;

        for (i = 1; i <= N; i++) {
            number = Convert.ToInt32(Console.ReadLine());

            for (j = 2; j <= number / j; j++) {
                if (number % j == 0) {
                    number = 1;
                }
            }
            output = number == 1 ? "Not prime": "Prime";
            Console.WriteLine(output);
        }
        
    }
    
}
