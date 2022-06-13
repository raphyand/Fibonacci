using System;

namespace Fib
{
    public static class FibProgram{

        public static void Main(string[] args){
            Fibonacci fib = new Fibonacci();

            Console.WriteLine("Fibonacci:");
            Console.WriteLine(fib.recursive(3) );
        }




        public class Fibonacci {
            
            public Fibonacci(){}

            public int recursive(int n){

                if (n == 1 || n == 2){
                    return 1;
                }
                else if (n == 0){
                    return 0;
                }
                else {
                    n--;
                    return recursive(n) + recursive(n - 1);
                }
                
            }

        }




    }


}