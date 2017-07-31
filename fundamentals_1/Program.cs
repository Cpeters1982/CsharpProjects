using System;

namespace fundamentals_1
{
    class Program
    {
        static void Main(string[] args){

        
            for (int i = 1; i <= 255; i++){
                System.Console.WriteLine(i);
            }
            for (int i = 1; i <=100; i++){
                if((i % 3 == 0) || (i % 5 == 0)){
                    if((i % 15 == 0)){
                        continue;
                    }
                    System.Console.WriteLine(i);
                }
            } 
            for (int i = 1; i <= 100; i++){
                if((i % 15 == 0)){
                    System.Console.WriteLine("Fizzbuzz");
                } else if ((i % 3 == 0)){
                    System.Console.WriteLine("Fizz");
                } else if ((i % 5 == 0)){
                    System.Console.WriteLine("Buzz");
                } else {
                    System.Console.WriteLine(i);
                }
            }
            
        }
    }
}
