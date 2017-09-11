using System;
using DbConnection;
using System.Collections.Generic;

namespace crud
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read();
            // Create();
            Delete(3);
        }
         public static void Read()
        {
            List<Dictionary<string, object>> currUsers = DbConnector.Query("select * from users");
            foreach (var user in currUsers){
                 Console.WriteLine("{0} {1}'s favorite number is {2}", user["Firstname"], user["Lastname"], user["FavoriteNumber"]);
            }
        }
        public static void Create()
            {Console.WriteLine("enter id");
            string id = Console.ReadLine();
            Console.WriteLine("Enter the user's first name");
            string ifirstName = Console.ReadLine();
            Console.WriteLine("Enter the user's last name");
            string ilastName = Console.ReadLine();
            Console.WriteLine("Enter the user's favorite number");
            int ifavoriteNumber = Int32.Parse(Console.ReadLine());
            DbConnector.Execute($"INSERT INTO users (idUsers,Firstname, Lastname, FavoriteNumber) VALUES (\"{id}\",\"{ifirstName}\", \"{ilastName}\", {ifavoriteNumber})");
            Read();
        }
        public static void Delete(params int[] id){
            int userID = id[0];
            DbConnector.Execute($"DELETE FROM users WHERE idUsers = {userID}");
            Read();
        }

        public static void Update(){
            Console.WriteLine("Enter the id of the user you wish to update");
            int userID = Int32.Parse(Console.ReadLine());
            Dictionary<string, object> user = DbConnector.Query($"select * from users where id = {userID}")[0];
            Console.WriteLine("Currently, this user information is as follows:");
            Console.WriteLine("{0} {1}'s favorite number is {2}", user["FirstName"], user["LastName"], user["FavoriteNumber"]);
            Console.WriteLine("Update the user's first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Update the user's last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Update the user's favorite number");
            int favoriteNumber = Int32.Parse(Console.ReadLine());
            DbConnector.Execute($"UPDATE users SET FirstName = \"{firstName}\", LastName = \"{lastName}\", FavoriteNumber = {favoriteNumber} WHERE id = {userID}");
            Read();
        }
 
    }
}
