using System;

namespace P2
{
    class P2Driver
    {
        const int TEST_MIN = 3;
        const int TEST_MAX = 6;

        static void Main()
        {
           
            Console.Write("Generating an array of studentStat objects with random capacity between ");
            Console.Write(TEST_MIN);
            Console.Write(" and ");
            Console.Write(TEST_MAX);
            Console.Write(".");
            Console.WriteLine();

            studentStat[] studentCollection;
            studentCollection = generateStuArray();

            Console.Write("studentStat array of length ");
            Console.Write(studentCollection.Length);
            Console.Write(".");
            Console.WriteLine();

            Console.ReadKey();
            
        }

        

        static studentStat[] generateStuArray()
        {
            studentStat[] studentCollection = new studentStat[randomNum(TEST_MIN, TEST_MAX)];
            return studentCollection;
        }

        public static int randomNum(int min, int max)
        {
            Random rnd = new Random();
            return rnd.Next(min, max);
        }

        void studentDriver()
        {
            int selection = 0;
            while (selection != 7)
            {
                switch (selection)
                {
                    case 1:

                        break;
                }
            }
            Console.WriteLine("Please chose a number from the menu: ");

        }
    }
}
