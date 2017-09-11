using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
      
        public static int[] randArr(int num=0){
            Random ranNum;
            int[] array= new int[3];
            ranNum= new Random();
            for(int i=0;i<array.Length;i++){
                int x =ranNum.Next(num);
                array[i]=x;
                Console.WriteLine(array[i]);
            }
            
            return array;
        }
         public static string toss(){
            Console.WriteLine("Tossing A Coin");
            Random ranNum;
            ranNum= new Random();
            int chance=ranNum.Next(101);
            if(chance>50){
                 Console.WriteLine("Result is Heads");
                 return "Heads";
            }else{
                Console.WriteLine("Result is Tails");
                return "Tails";
            }


        }

        public static string numToss(int num=0){
            string result="";
            for( int i=0;i<num;i++){
                result +=" "+(toss());
            }

            return result;
        }

        public static string[] reshuffle(string[] texts){
            // Knuth shuffle algorithm :: courtesy of Wikipedia :)
            for (int t = 0; t < texts.Length; t++ )
            {
            Random ranNum;
            ranNum= new Random();
            string tmp = texts[t];
            int r = ranNum.Next(t, texts.Length);
            texts[t] = texts[r];
            texts[r] = tmp;
            }
            for( int i=0;i<texts.Length;i++){
                Console.WriteLine(texts[i]);
            }

            return texts;
        }
        public static string[] names(){
            String[] names =new String[] {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            String[] names2;
            // Random ranNum;
            // ranNum= new Random()

            return names;
            
        }


        static void Main(string[] args)
        {
        String[] names =new String[] {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
        //  randArr(3);
        // Console.WriteLine(toss());
        // Console.WriteLine(numToss(3));
        Console.WriteLine(reshuffle(names)[0]);
    }
    }
}
