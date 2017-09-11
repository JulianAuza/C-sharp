using System;
using System.Collections.Generic;

namespace boxunbox
{
    class Program
    {
        public static void oneToNum(int num=0){
            for(var i=0; i<num+1;i++){
                Console.WriteLine(i);
            }
        }

        public static void printOdd(int num=0){
            for(var i=0; i<num+1;i++){
                if(i%2!=0){
                    Console.WriteLine(i);
                }
            }
        }

        public static void countSum(int num=0){
            int sum=0;
            for(var i=0; i<num+1;i++){
                sum+=i;
              Console.Write(i); Console.WriteLine(" "+sum);
            }
        }

        public static void arrVal(int[] arr){
            for(int i=0;i<arr.Length;i++){
                Console.WriteLine(arr[i]);
            }
        }

        static void Main(string[] args)
        {
        //UNOBOXING
        // List<object> list = new List<object>();
        // list.Add(7);
        // list.Add(28);
        // list.Add(-1);
        // list.Add(true);
        // list.Add("chair");

        // foreach (var item in list){
        //     Console.WriteLine(item);

        // }
        //   int sum = 0;
        //     foreach (var item in list){
        //         if (item is int){
        //             sum += (int)item;
        //         }
        //     }
        //     Console.WriteLine(sum);

        //BASIC THIRTEEN
        arrVal(new int[] {5,2,1,2});
        

        }
    }
}
