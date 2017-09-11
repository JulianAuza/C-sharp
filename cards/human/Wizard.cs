using System;

namespace human
{
    public class Wizard : Person
    {
        public Wizard(string person, int str = 3, int dex = 3) : base(person, str, 25, dex, 50){}

        public void heal(){
            health += intelligence * 10;
        }

        public void fireball(object obj){
            Person enemy = obj as Person;
            if(enemy == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                Random rand = new Random();
                enemy.health -= rand.Next(20,51); 
            }

        }
    }
}