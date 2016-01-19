using System;
using System.Collections.Generic;

namespace P2
{
    class studentStat
    {
        private List<debtStat> student;
        private int totalDebt;

        public int indexMostBurden()
        {
            int maxBurden = 0;
            int most = new int();

            foreach (debtStat element in student)
            {
                int count = 0;
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
    }
}