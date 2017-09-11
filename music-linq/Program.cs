using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

            // var artist = from match in Artists 
            //             orderby match. ArtistName ascending
            //             select new{match.ArtistName};
            
            // foreach (object name in artist){
            //     Console.WriteLine(name);
            // }

            // IEnumerable<Artist> artist = Artists.Where( name => name.Hometown == "Mount Vernon");

            // foreach(JsonData.Artist person in artist){
            //     Console.WriteLine($"Name of artist from {person.Hometown} is {person.RealName} and their age is {person.Age}.");
            // }
            
            // var artist = from match in Artists orderby match.Age ascending select new{match.ArtistName};

            // var youngestArtist = (from match in Artists orderby match.Age ascending select new {match.ArtistName, match.Age}).First();
            // Console.WriteLine($"The youngest Artist is {youngestArtist.ArtistName} and his age is {youngestArtist.Age}.");

            // var artist = (from match in Artists 
            //              where match.RealName.Contains("William")
            //              select new{match.ArtistName, match.RealName});

            // foreach (object name in artist){
            //     Console.WriteLine(name);
            // }

            // var artist = (from match in Artists 
            //              where match.RealName.Contains("William")
            //              select new{match.ArtistName, match.RealName});
            
            // IEnumerable<Artist> artist = Artists.Where( name => name.ArtistName.Length < 8);

            // foreach (JsonData.Artist name in artist){
            //     Console.WriteLine(name.ArtistName);
            // }

            // List<Artist> oldAtlanta = Artists.Where(match=> match.Hometown=="Atlanta").OrderByDescending(match => match.Age).Take(3).ToList();
            // foreach(var artist in oldAtlanta){
            //     Console.WriteLine($"{artist.ArtistName} is {artist.Age}");
            // }

            List<Group> WuTang = Groups.Where(match=> match.GroupName=="Wu-Tang Clan").OrderByDescending(match => match.Members).ToList();
            foreach(JsonData.Group artist in WuTang){
                Console.WriteLine($"{artist.GroupName}");
            }
                         

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?

            //Who is the youngest artist in our collection of artists?

            //Display all artists with 'William' somewhere in their real name

            //Display the 3 oldest artist from Atlanta

            //(Optional) Display the Group Name of all groups that have members that are not from New York City

            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
        }
    }
}
