// AUTHOR: Colin Brinton
// FILENAME: p2.cs
// DATE: 1/20/2016
// REVISION HISTORY: 1.0
using System;

namespace P2
{
    class P2Driver
    {
        const int TEST_DEBTS = 3;
        const int TEST_MAX = 3;
        const int ID_MIN = 100000;
        const int ID_MAX = 1000000;
        const int MONEY_MIN = 0;
        const int MONEY_MAX = 150000;
        const int MIN_DATE = 18000100;
        const int MAX_DATE = 30001231;
        static Random rnd = new Random();

        static void Main()
        {
           
            Console.Write("Generating an array of studentStat objects with capacity of ");
            Console.Write(TEST_MAX);
            Console.Write(": ");
            Console.WriteLine();

            studentStat[] studentCollection = new studentStat[TEST_MAX];
            int count = 0;
            foreach(studentStat element in studentCollection)
            {
                studentCollection[count] = new studentStat();
                ++count;
            }

            Console.Write("studentStat array of length ");
            Console.Write(studentCollection.Length);
            Console.Write(".");
            Console.WriteLine();

            studentStatSetup(ref studentCollection);

            testTotalBurden(ref studentCollection);

            testIndexMost(ref studentCollection);
          

            Console.ReadKey();
            
        }

        static void testIndexMost(ref studentStat[] studentCollection)
        {
            int count = 0;
            foreach (studentStat element in studentCollection)
            {
                Console.Write("Which degree carries the most debt for student #");
                Console.Write(count);
                Console.Write(": ");
                Console.Write("Debt Stat #");
                Console.Write(studentCollection[count].indexMostBurden() + 1);
                Console.WriteLine();
                ++count;
            }
        }

        static void testTotalBurden(ref studentStat[] studentCollection)
        {
            int count = 0;
            foreach (studentStat element in studentCollection)
            {
                int totalBurden = new int();
                totalBurden = studentCollection[count].totalBurden();
                Console.Write("Total Debt Burden for Student #");
                Console.Write(count + 1);
                Console.Write(" is : $");
                Console.Write(totalBurden);
                Console.WriteLine();
                ++count;

            }
        }

        static void studentStatSetup(ref studentStat[] studentCollection)
        {
            int count = 0;
            foreach (studentStat element in studentCollection)
            {
                Console.WriteLine();
                Console.Write("STUDENT ");
                Console.Write(count + 1);
                Console.WriteLine();
                Console.Write("Please enter a student ID: ");
                int testID = new int();
                testID = randomNum(ID_MIN, ID_MAX);
                Console.Write(testID);
                Console.WriteLine();
                Console.WriteLine();

                for (int index = 0; index < TEST_DEBTS; ++index)
                {

                    Console.Write("****Debt Stat #");
                    Console.Write(index + 1);
                    Console.Write("****");
                    Console.WriteLine();
                    Console.Write("Enter loan amount: $");
                    int testLoan = new int();
                    testLoan = randomNum(MONEY_MIN, MONEY_MAX);
                    Console.Write(testLoan);
                    Console.WriteLine();
                    Console.Write("Enter grant amount: $");
                    int testGrant = new int();
                    testGrant = randomNum(MONEY_MIN, MONEY_MAX);
                    Console.Write(testGrant);
                    Console.WriteLine();
                    Console.Write("Enter matriculation date (YYYYMMDD): ");
                    int testMatric = new int();
                    testMatric = randomNum(MIN_DATE, MAX_DATE);
                    Console.Write(testMatric);
                    Console.WriteLine();
                    Console.Write("Enter graduation date (YYYYMMDD): ");
                    int testGrad = new int();
                    testGrad = randomNum(MIN_DATE, MAX_DATE);
                    Console.Write(testGrad);
                    Console.WriteLine();

                    studentCollection[index].constructStats(testID, testLoan, testGrant, testMatric, testGrad);
                }
                ++count;
            }
            Console.WriteLine();
        }


        public static int randomNum(int min, int max)
        {
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
