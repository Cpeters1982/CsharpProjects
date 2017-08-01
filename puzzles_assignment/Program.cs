using System;
using System.Linq;

namespace puzzles_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            RandomArray(r);
            TossCoin(r);
            TossMultipleCoins(r, 10);
        }
        static int[] RandomArray(Random r){
            int[] myArray = new int[10];
            System.Console.WriteLine(myArray);
            for (int i = 0; i < myArray.Length; i++){
                myArray[i] = r.Next(5,26);
            }
            System.Console.WriteLine(myArray.Min());
            System.Console.WriteLine(myArray.Sum());
            return myArray;
        }

        static string TossCoin(Random r){
            System.Console.WriteLine("Tossing a coin...");
            int CoinToss = r.Next(0,2);
            string res = "";
            if (CoinToss == 0){
                System.Console.WriteLine("Heads");
                return res = "Heads";
            } else {
                System.Console.WriteLine("Tails");
            }
            return res;
        }
        static Double TossMultipleCoins(Random r, int Num){
            int CountHeads = 0;
            for (int i =  0; i < Num; i++){
                if (TossCoin(r) == "Heads"){
                    CountHeads++;
                }
            }
            System.Console.WriteLine((Double)CountHeads/Num);
            return (Double)CountHeads/Num;
        }

            
    }
}
