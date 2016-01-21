// AUTHOR: Colin Brinton
// FILENAME: debtStat.cs
// DATE: 1/20/2016
// REVISION HISTORY: 2.0
using System;

namespace P2
{
    class debtStat
    {
        const int LOAN_INCREASE = 1;
        const int LOAN_DECREASE = -1;
        const int NO_LOAN_CHNG = 0;
        const bool DEFAULT_THRESH = false;
        const bool OVER_THRESH = true;
        const int INACTVE_VALUE = -1;
        const int ID_MIN = 100000;
        const int ID_MAX = 1000000;
        const int MIN_LOAN = 0;
        const int MIN_GRANT = 0;
        const int MIN_DATE = 18000100;
        const int MAX_DATE = 30001231;
        const int MIN_THRESHOLD = 0;
        const int MONTH_MOD = 10000;
        const int DAY_MOD = 100;
        const int MONTH_MAX = 1231;
        const int MONTH_MIN = 101;
        const int DAY_MAX = 31;
        const int DAY_MIN = 1;

        readonly int studentID;
        readonly int origLoan;
        private int currLoan;
        readonly int origGrant;
        private int currGrant;
        readonly int matriculation;
        private int anticGrad;
        readonly int origGrad;
        private bool active;

        public debtStat()
        {
            active = false;
        }

        public debtStat(int id, int loan, int grant, int matric, int grad)
        {
            studentID = id;
            origLoan = loan;
            currLoan = loan;
            origGrant = grant;
            currGrant = grant;
            matriculation = matric;
            origGrad = grad;
            active = true;
        }

        /*void generateID()
         {
            Random rndID = new Random();
            studentID = rndID.Next(ID_MIN, ID_MAX);
         }*/


        public void increaseLoan(int amount)
        {
            CurrLoan = (currLoan += amount);
        }

        public void decreaseLoan(int amount)
        {
            CurrLoan = (currLoan -= amount);

        }

        public bool gradExten()
        {
            if (anticGrad > origGrad)
                return true;
            return false;
        }
        public int loanChange()
        {
            if (currLoan > origLoan)
                return LOAN_INCREASE;
            if (currLoan < origLoan)
                return LOAN_DECREASE;
            return NO_LOAN_CHNG;
        }

        public void deactivate()
        {
            active = false;
        }

        public bool debtExceed(int debtCap)
        {
            if (currLoan > debtCap)
                return true;
            return false;
        }

        public bool idMatch(int sID)
        {
            if (sID == studentID)
                return true;
            return false;
        }

     


        private int CurrLoan
        {
            set
            {
                currLoan = value;
            }
        }

       

        public int AnticGrad
        {
            set
            {
                anticGrad = value;
            }
        }


        public int getBurden()
        {
            return currLoan;
        }

        public bool isActive()
        {
            return active;
        }
    }
}
