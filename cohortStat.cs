using System;
using System.Collections.Generic;

namespace P2
{
    class cohortStat
    {
        private List<debtStat> cohort;

        public int indexLargestLoan()
        {
            int maxLoan = 0;
            int most = new int();

            foreach (debtStat element in cohort)
            {
                int count = 0;
                int curLoan = 0;
                curLoan = cohort[count].getBurden();

                if (curLoan > maxLoan)
                {
                    maxLoan = curLoan;
                    most = count;
                }
                ++count;
            }

            return most;
        }

        public int indexSmallestLoan()
        {
            int minLoan = cohort[0].getBurden();
            int least = new int();

            foreach (debtStat element in cohort)
            {
                int count = 0;
                int curLoan = cohort[count].getBurden();

                if (curLoan < minLoan)
                {
                    minLoan = curLoan;
                    least = count;
                }
                ++count;
            }

            return least;
        }

        public int numInactive()
        {
            int count = new int();
            count = 0;
            foreach (debtStat element in cohort)
            {
                int index = 0;
                if (cohort[index].isActive())
                    ++count;
            }
            return count;
        }
    }
}