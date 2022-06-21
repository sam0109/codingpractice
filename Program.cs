using System;

namespace codin
{
    class Program
    {
        static void Main(string[] args)
        {
            int stacks = 5;
            while (true) {
                if (stacks <= 0) {
                   break;
                }
                Console.WriteLine("Did 1 damage.");
                stacks = stacks - 1;
            }

            int stacks = 5;
            while (stacks > 0) {
                Console.WriteLine("Did 1 damage.");
                stacks = stacks - 1;
            }

            for (int stacks = 5; stacks > 0; stacks = stacks - 1) {
                Console.WriteLine("Did 1 damage.");
            }

/*
            int number_of_calls = 5;
            while (number_of_calls > 0) {
                Console.WriteLine("Unga Bunga");
                number_of_calls = number_of_calls - 1;
            }

            bool blah = number_of_calls > 0;
            while (blah) {
                Console.WriteLine("Unga Bunga");
                number_of_calls = number_of_calls - 1;
            }

            while (blah) {
                Console.WriteLine("Unga Bunga");
                number_of_calls = number_of_calls - 1;
                blah = number_of_calls > 0;
            }
            
            // 5 == 10 -> false
            // 5 == 5 -> true
            // == >= <= < > !=
            // 5 != 10 -> true
            // do stuff
            bool is_daniel_a_fuckler = true;
            bool is_grant_straight = false;

            x = 10;

            int x;
            x = 69;


            int a = 5;  //        5 -> a
            int b = 10; //       10 -> b
            a = a + b;  // (5 + 10) -> a
            b = 20;
            */
        }
    }
}
