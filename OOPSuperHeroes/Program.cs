using System;

namespace OOPSuperHeroes
{
    class Program
    {
        class player
        {
            string name;
            int hp;

            public player(string _name)
            {
                name = _name;
                Random rnd = new Random();
                hp = rnd.Next(100, 151);
            }

            public void SayHello()
            {
                Console.WriteLine($"{name} Says hola me kill you!!!!");
            }
            public void ShowYourHp()
            {
                Console.WriteLine($"{name}'s HP: {hp}");
            }
            public int MakeDamage()
            {
                Random rnd = new Random();
                return rnd.Next(10, 51);
            }
            public void TakeDamage(int damage)
            {
                if(hp < 0)
                {
                    hp = 0;
                } else
                {
                    hp = hp - damage;
                }
            }
            public int HP
            {
                get { return hp;}
            } 
            public string Name
            {
                get { return name; }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hey Kid!");
            Console.WriteLine("Name Your Character");
            string CharacterName = Console.ReadLine();
            Console.WriteLine("Name your Second Character");
            string CharacterNameTwo = Console.ReadLine();

            player PlayerOne = new player(CharacterName);
            player PlayerTwo = new player(CharacterName);
            PlayerOne.SayHello();
            PlayerOne.ShowYourHp();
            PlayerTwo.SayHello();
            PlayerTwo.ShowYourHp();

            for(int i = 0; i < 3; i++)
            {
                PlayerOne.TakeDamage(PlayerTwo.MakeDamage());
                PlayerTwo.TakeDamage(PlayerOne.MakeDamage());
                PlayerOne.ShowYourHp();
                PlayerTwo.ShowYourHp();

            }

            if(PlayerOne.HP > PlayerTwo.HP)
            {
                Console.WriteLine("Player One Won ");
            }else if (PlayerOne.HP < PlayerTwo.HP)
            {
                Console.WriteLine("Player Two Won");
            }else
            {
                Console.WriteLine("It's a Tie");
            }

            

        }
    }
}
