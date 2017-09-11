using System;

namespace human
{
    public class Person
    {
        public string name;
        public int strength;
        public int intelligence;

        public int dexterity;

        public int health;
        
        public Person(string Name="", int Strength = 3,int Intelligence = 3, int Dexterity = 0,int Health = 100){
            strength = 3;
            intelligence=3;
            dexterity =3;
            health = 100;
        }

        public void attack(object obj)
    {
        Person enemy = obj as Person;

        if(enemy == null)
        {
            Console.WriteLine("Failed Attack");
        }
        else
        {
            enemy.health -= strength * 5;
        }
    }
    }
}
