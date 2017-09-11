using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
           Person james= new Person();
           Console.WriteLine(james.strength);

           Person dude= new Person();
           Console.WriteLine(dude.strength);


           Console.WriteLine(james.health);
           dude.attack(james);
           Console.WriteLine(james.health);


        }
    }
}
