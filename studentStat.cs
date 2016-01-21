// AUTHOR: Colin Brinton
// FILENAME: studentStat.cs
// DATE: 1/20/2016
// REVISION HISTORY: 1.0
using System;
using System.Collections.Generic;

namespace P2
{
    class studentStat
    {
        const int TEST_NUM = 3;
        private List<debtStat> student;

        public studentStat(int test = TEST_NUM)
        {
           // int count = 0;
            student = new List<debtStat>(test);
           
                

        }

        
        public void constructStats(int id, int loan, int grant, int matric, int grad)
        {
                debtStat addStat = new debtStat(id, loan, grant, matric, grad);
                student.Add(addStat);     
        }

        /*public void setID(int id)
        {
            int count = 0;
            foreach (debtStat element in student)
            {
                student[count].StudentID = id;
                ++count;
            }
        }*/

        public int indexMostBurden()
        {
            int maxBurden = 0;
            int most = new int();

            int count = 0;
            foreach (debtStat element in student)
            {
                int curBurden = 0;
                curBurden = student[count].getBurden();

                if (curBurden > maxBurden)
                {
                    maxBurden = curBurden;
                    most = count;
                }
                ++count;
            }

            return most;
        }

        public int numInactive()
        {
            int count = new int();
            count = 0;
            foreach (debtStat element in student)
            {
                int index = 0;
                if (student[index].isActive())
                    ++count;
            }
            return count;
        }

        public int totalBurden()
        {
            int total = new int();
            total = 0;
            foreach (debtStat element in student)
            {
                int index = 0;
                total += student[index].getBurden();
                ++index;
            }
            return total;
        }

        }
    }
