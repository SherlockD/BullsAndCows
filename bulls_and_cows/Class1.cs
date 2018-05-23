using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bulls_and_cows
{

    class BullsandCows
    {
        private string playerNumber;
        private Char[] startNumberArr = new char[4];
        private Char[] playerNumberArr;
        private int bulls = 0;
        private int cows;
        private int[] mamory = new int[4];

        public bool isInArr(int[] mam,int i)
        {
            if (mam != null)
            {
                for (int t = 0; t < 4; t++)
                {
                    if (mam[t] == i)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public BullsandCows()
        {
            Random rand = new Random();

            char[] numbers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for(int i = 0; i < 4; i++)
            {
                
                int index = rand.Next(0, 9);
                while (isInArr(mamory, index))
                {
                    index = rand.Next(0, 9);
                };
                startNumberArr[i] = numbers[index];
                mamory[i] = index;
            }   
            
            
        }
        public void game_start()
        {
            while (bulls != 4)
            {
                Console.Clear();
                Console.WriteLine(bulls+" Быков "+cows+ " Коров ");         
                bulls = 0;
                cows = 0;
                Console.WriteLine("Введите число\n");
               playerNumber =Console.ReadLine();
                if (playerNumber != "")
                {
                    playerNumberArr = playerNumber.ToCharArray();

                    for (int i = 0; i < 4; i++)
                    {
                        if (playerNumberArr[i] == startNumberArr[i])
                        {
                            bulls++;
                        }
                        else
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                if (playerNumberArr[i] == startNumberArr[j])
                                {
                                    cows++;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Вы победили!");
        }
    }

    class Class1
    {
        static void Main()
        {
            int menu = 0;        
            while (menu != 2)
            {
                Console.WriteLine("Выберите пункт меню\n");
                Console.WriteLine("1)Начать игру\n2)Выход\n");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        BullsandCows Game = new BullsandCows();
                        Game.game_start();
                        break;
                    case 2: 
                        break;
                }
            }
            Console.ReadKey();
        }    
    }
}
