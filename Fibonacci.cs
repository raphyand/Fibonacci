using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Fib
{
    public static class FibProgram{

        // Main
        public static void Main(string[] args){
            Fibonacci fib = new Fibonacci();

            Console.WriteLine("Fibonacci Dynamic-Programming: " + fib.Memoized(45));

            Console.WriteLine("Fibonacci Recursive: " + fib.recursive(45));

            
        }



        // Custom Class for Fibonacci Sequence
        public class Fibonacci {
            
            // Dictionary Data Structure for Memoization
            private Dictionary<int, int>memo;
           // Class Constructor 
            public Fibonacci(){
                memo = new Dictionary<int, int>();
            }

            // Recursive Call -  O(2^n) Complexity
            public int recursive(int n){

                // Base Case
                if (n == 1 || n == 2){
                    return 1;
                }
                // Base Case of Zero
                else if (n == 0){
                    return 0;
                }
                // Recursive Call
                else {
                    n--;
                    return recursive(n) + recursive(n - 1);
                }
                
            }


            // Memoized solutuion - O(n) Complexity
            public int Memoized(int n){

                int result = 0;

                // 
                if (memo.ContainsKey(n)){
                    return memo[n];
                }
                else if (n == 1 || n == 2){
                    result = 1;
                }
                else if (n == 0){
                    return 0;
                }
                else{
                   result = Memoized(n - 1) + Memoized(n - 2); 
                }

                memo.Add(n, result);
                return result;

            }

        }




    }


}