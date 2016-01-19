using System;

namespace P2
{
    class debtStat
    {
        private static int debtCap;
        const string LOAN_INCREASE = "Increase.";
        const string LOAN_DECREASE = "Decrease.";
        const string NO_LOAN_CHNG = "None.";
        const int DEFAULT_DEBT_CAP = -1;
        const bool DEFAULT_THRESH = false;
        const bool OVER_THRESH = true;
        const int DEFAULT_LOAN = -1;
        const int DEFAULT_GRANT = -1;
        const int DEFAULT_MATRIC = -1;
        const int DEFAULT_GRAD = -1;
        const int DEFAULT_ID = -1;
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

        private int studentID;
        private int origLoan;
        private int currLoan;
        private int origGrant;
        private int matriculation;
        private int anticGrad;
        private int origGrad;
        private bool overThreshold;
        private bool active;

        public debtStat(int id = DEFAULT_ID, int loan = DEFAULT_LOAN, int grant = DEFAULT_GRANT,
            int matric = DEFAULT_MATRIC, int grad = DEFAULT_GRAD, int dCap = DEFAULT_DEBT_CAP, bool thresh = DEFAULT_THRESH)
        {

            studentID = id;
            origLoan = loan;
            origGrant = grant;
            matriculation = matric;
            origGrad = grad;
            currLoan = origLoan;
            anticGrad = origGrad;
            debtCap = dCap;
            overThreshold = thresh;
        }

        /*void generateID()
         {
            Random rndID = new Random();
            studentID = rndID.Next(ID_MIN, ID_MAX);
         }*/



        public bool isOverThreshold()
        {
            return overThreshold;
        }

        public void increaseLoan(int amount)
        {
            Console.Write("Increase loan by: $");
            Console.Write(amount);
            Console.WriteLine();
            CurrLoan = (currLoan += amount);

            if (currLoan >= debtCap)
                overThreshold = OVER_THRESH;
        }

        public void decreaseLoan(int amount)
        {
            Console.Write("Decrease loan by: $");
            Console.Write(amount);
            Console.WriteLine();
            CurrLoan = (currLoan -= amount);

            //if (currLoan < debtCap)
            overThreshold = false;
        }

        public bool gradExten()
        {
            if (anticGrad > origGrad)
                return true;
            return false;
        }
        public string loanChange()
        {
            if (currLoan > origLoan)
                return LOAN_INCREASE;
            if (currLoan < origLoan)
                return LOAN_DECREASE;
            return NO_LOAN_CHNG;
        }

        public void deactivate()
        {
            studentID = DEFAULT_ID;
            origLoan = DEFAULT_LOAN;
            currLoan = DEFAULT_LOAN;
            origGrant = DEFAULT_GRANT;
            matriculation = DEFAULT_MATRIC;
            anticGrad = DEFAULT_GRAD;
            origGrad = DEFAULT_GRAD;
            active = false;
        }

        public bool debtExceed()
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

        public int StudentID
        {
            set
            {
                if (studentID == DEFAULT_ID)
                {
                    while (value >= ID_MAX || value < ID_MIN)
                    {
                        Console.WriteLine("Error. ID must be a six digit, positive number.");
                        Console.Write("Please reenter ID: ");
                        value = Convert.ToInt32(Console.ReadLine());
                    }
                    studentID = value;
                }
                else
                    Console.WriteLine("Error. Student ID has already been set.");
            }
        }

        public int OrigLoan
        {
            set
            {
                if (origLoan == DEFAULT_LOAN)
                {
                    while (value < MIN_LOAN)
                    {
                        Console.WriteLine("Error. Loan must be positive.");
                        Console.Write("Please reenter loan: $");
                        value = Convert.ToInt32(Console.ReadLine());
                    }
                    origLoan = value;
                    currLoan = value;
                    Console.WriteLine("FIRST");
                    Console.WriteLine(currLoan);
                }
                else
                    Console.WriteLine("Error. Original Loan value has already been set.");

                Console.Write("HEREEEE");
                Console.WriteLine(debtCap);
                //if (origLoan >= debtCap)
                // overThreshold = OVER_THRESH;
            }
        }

        private int CurrLoan
        {
            set
            {
                while (value < MIN_LOAN)
                {
                    Console.WriteLine("Error. Loan must be positive.");
                    Console.Write("Please reenter loan: $");
                    value = Convert.ToInt32(Console.ReadLine());
                }
                currLoan = value;

                if (currLoan >= debtCap)
                    overThreshold = OVER_THRESH;
            }
        }

        public int OrigGrant
        {
            set
            {
                while (value < MIN_GRANT)
                {
                    Console.WriteLine("Error. Grant must be positive.");
                    Console.Write("Please reenter grant: $");
                    value = Convert.ToInt32(Console.ReadLine());
                }
                origGrad = value;
            }
        }

        public int Matriculation
        {
            set
            {
                if (matriculation == DEFAULT_MATRIC)
                {
                    while (((value < MIN_DATE || value > MAX_DATE) &&
                        ((value % MONTH_MOD) < MONTH_MIN) || (value % MONTH_MOD) > MONTH_MAX) &&
                        ((value % DAY_MOD) < DAY_MIN) || ((value % DAY_MOD) > DAY_MAX))
                    {
                        Console.WriteLine("Error. Date must be in YYYYMMDD format.");
                        Console.Write("Please reenter date: ");
                        value = Convert.ToInt32(Console.ReadLine());
                    }
                    matriculation = value;
                }
                else
                    Console.WriteLine("Error. Matriculation date has already been set.");
            }
        }

        public int AnticGrad
        {
            set
            {
                while (((value < MIN_DATE || value > MAX_DATE) &&
                        ((value % MONTH_MOD) < MONTH_MIN) || (value % MONTH_MOD) > MONTH_MAX) &&
                        ((value % DAY_MOD) < DAY_MIN) || ((value % DAY_MOD) > DAY_MAX))
                {
                    Console.WriteLine("Error. Date must be in YYYYMMDD format.");
                    Console.Write("Please reenter date: ");
                    value = Convert.ToInt32(Console.ReadLine());
                }
                anticGrad = value;
            }
        }

        public int OrigGrad
        {
            set
            {
                if (origGrad == DEFAULT_GRAD)
                {
                    while (((value < MIN_DATE || value > MAX_DATE) &&
                        ((value % MONTH_MOD) < MONTH_MIN) || (value % MONTH_MOD) > MONTH_MAX) &&
                        ((value % DAY_MOD) < DAY_MIN) || ((value % DAY_MOD) > DAY_MAX))
                    {
                        Console.WriteLine("Error. Date must be in YYYYMMDD format.");
                        Console.Write("Please reenter date: ");
                        value = Convert.ToInt32(Console.ReadLine());
                    }
                    origGrad = value;
                    anticGrad = value;
                }
                else
                    Console.WriteLine("Error. Original graduation date has already been set.");
            }
        }

        public int DebtCap
        {
            set
            {
                while (value < MIN_THRESHOLD)
                {
                    Console.WriteLine("Error. Threshold must be positive.");
                    Console.Write("Please reenter threshhold: $");
                    value = Convert.ToInt32(Console.ReadLine());
                }
                debtCap = value;
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
