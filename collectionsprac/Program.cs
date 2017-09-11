using System;
using System.Collections.Generic;

namespace collectionsprac
{
    class Program
    {
        static void Main(string[] args)
        {
        //    int[] numArray = {0,1,2,3,4,5,6,7,8,9};
        //    for(int i=0;i<10;i++){
        //       Console.WriteLine(numArray[i]);
        //    }
        //    Console.WriteLine(numArray);

        //    Boolean[] Arr= new Boolean[10];
        //    for(int i=0;i<Arr.Length;i++){
        //        if(i%2==0){
        //            Arr[i]=false;
        //            Console.WriteLine(Arr[i]);
        //        }else{
        //            Arr[i]=true;
        //            Console.WriteLine(Arr[i]);
        //        }
        //         Console.WriteLine("[{0}]", string.Join(", ", Arr));
          // }

        //   int[,]array = new int[10,10]
        //   {
        //       {1,2,3,4,5,6,7,8,9,10},
        //       {2,2,3,4,5,6,7,8,9,10},
        //       {3,2,3,4,5,6,7,8,9,10},
        //       {4,2,3,4,5,6,7,8,9,10},
        //       {5,2,3,4,5,6,7,8,9,10},
        //       {6,2,3,4,5,6,7,8,9,10},
        //       {7,2,3,4,5,6,7,8,9,10},
        //       {8,2,3,4,5,6,7,8,9,10},
        //       {8,2,3,4,5,6,7,8,9,10},
        //       {10,2,3,4,5,6,7,8,9,10},
        //   };

        //   for(int i=0;i<10;i++){
        //     for(int j=0;j<10;j++){
        //         if(j>0){
        //         array[i,j]=((array[i,j])*(i+1));
        //         }
        //         Console.Write(string.Format("{0}"+",", array[i,j]));
        //     }
        //     Console.Write(Environment.NewLine);
        //   }


    
            string[] arr2 = {"Ted", "Maryn", "Marc", "Aaron"};
            foreach (var name in arr2){
                Console.WriteLine(name);
            }

            List<string> flavors = new List<string>();
            flavors.Add("Vanilla");
            flavors.Add("Chocolate");
            flavors.Add("Salted Caramel");
            flavors.Add("Coconut");
            flavors.Add("Mint Chip");
            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine(flavors.Count);

            Dictionary<string,string> user = new Dictionary<string,string>();
            user.Add("Ted", null);
            user.Add("Maryn", null);
            user.Add("Marc", null);
            user.Add("Aaron", null);
            Random rand = new Random();

            foreach (string name in arr2){
                user[name] = flavors[rand.Next(0,4)];
            }

            foreach (KeyValuePair<string,string> entry in user){
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }

        }
    }
}
