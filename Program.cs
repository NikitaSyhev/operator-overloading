using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_overloading
{
    class Staff
    {
        public Staff()  // создали класс
        {
            this.coins = 0;
            this.name = "Player";

        }
        private string _name; // поле нейм

        public string name // геттрер и сеттер
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _coin;

        public int coins
        {
            get { return _coin; }
            set { _coin = value; }
        }

        //перегрузка операторов
        public static bool operator <(Staff player1, Staff player2)
        {
            return player1._coin < player2._coin;
        }
        public static bool operator >(Staff player1, Staff player2)
        {
            return player1._coin > player2._coin;
        }
        public static Staff operator +(Staff player1, Staff player2)
        {
            Staff sum_player = new Staff();
            sum_player._coin = player1._coin + player2._coin;
            sum_player._name = $"{player1._name} and {player2._name} ";
            return sum_player;
        }
        public static int operator *(Staff player1, Staff player2)
        {
            return player1.coins + player2.coins;
        }
    }



    // пример другого класса
    class Gamers
    {
        static private int myRandom()
        {
            Random random = new Random();
            var currentTime = DateTime.Now.Millisecond;
            int Number = currentTime;
            Number *= Number;
            int _myRandom = 1 + random.Next(Number) % 100;
            return _myRandom;
        }
        public Gamers()
        {
            name = "Gamer";
            coin = 1;
            honor = 100;
        }
        private string name;
        public string _name
        {
            get { return name; }
            set { name = value; coin = myRandom(); }
        }
        private int coin;

        public int _coin
        {
            get { return coin; }
        }
        private int honor;

        public int _honor
        {
            get { return honor; }
            set { honor = value; }
        }

        public static bool operator <(Gamers player1, Gamers player2)
        {

            return player1._coin * player1._honor < player2._coin * player2._honor;
        }
        public static bool operator >(Gamers player1, Gamers player2)
        {
            return player1._coin * player1._honor > player2._coin * player2._honor;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {


            //работа с перегрузкой операторов
            var player01 = new Staff();
            var player02 = new Staff();
            player01.coins = 9;
            player01.name = "Бофур";
            player02.coins = 12;
            player02.name = "Бильбо";

            // вызываем  перегрузку операторов
            Console.WriteLine("Игрок {0} - {1} монет\nИгрок {2} - {3} монет", player01.name, player01.coins, player02.name, player02.coins);
            if (player01 > player02)
            {
                Console.WriteLine("Игрок {0} богаче игрока {1}", player01.name, player02.name);
            }
            else
            {
                Console.WriteLine("Игрок {1} богаче игрока {0}", player01.name, player02.name);
            }

            string name01, name02;
            try
            {
                name01 = args[0];
                name02 = args[1];
            }
            catch
            {
                Console.WriteLine("Введите имя 1-го игрока");
                name01 = Console.ReadLine();
                Console.WriteLine("Введите имя 2-го игрока");
                name02 = Console.ReadLine();
            }











            // работа с классом Gamers
            Gamers gamer01 = new Gamers();
            gamer01._name = name01;
            Gamers gamer02 = new Gamers();
            gamer02._name = name02;
            Console.WriteLine(
                "1-й игрок {0} имеет {2} монет\n" +
                "2-й игрок {1} имеет {3} монет",
                gamer01._name, gamer02._name, gamer01._coin, gamer02._coin);
            if (gamer01 > gamer02)
            {
                Console.WriteLine("Игрок {0} успешней игрока {1}", gamer01._name, gamer02._name);
            }
            else
            {
                if (gamer01 < gamer02)
                {
                    Console.WriteLine("Игрок {1} успешней игрока {0}", gamer01._name, gamer02._name);
                }
                else
                {
                    Console.WriteLine("Игрок {1} равен игроку {0}", gamer01._name, gamer02._name);
                }



                // индексатор
                //Индексаторы позволяют индексировать объекты и обращаться к данным по индексу. Фактически с помощью индексаторов мы можем работать с объектами как с массивами. По форме они напоминают свойства со стандартными блоками get и set, которые возвращают и присваивают значение.


                switch (switch_on)
                {
                    default:
                }
            }

        }
    }
}
