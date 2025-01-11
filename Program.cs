namespace C_sharp_Problem_Solving
{
    internal class Program
    {
        // helping Functions

        #region Print Massage Function
        // Print Massage 
        public static void PrintMassage(string massage)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine(massage);
            Console.WriteLine("--------------------------------");
        }
        #endregion

        #region Welcome App Function
        public static void Welcome(string massage)
        {
            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine(massage);
            Console.WriteLine("********************************");
        }
        #endregion

        #region ReadNumder Function
        public static bool ReadNumder(string fieldNumber, out int number)
        {
            bool Flag;

            Console.Write($"Please Enter {fieldNumber} :");
            Flag = int.TryParse(Console.ReadLine(), out number);
            if (!Flag)
            {
                Console.WriteLine("Invalid Number Try Again");
                return false;
            }

            return true;
        }
        #endregion

        ////////////////////////////////////////////////////////////
        // main Functions

        #region Writeyourname Function
        //// 1- Writeyourname
        public static void PrintName()
        {
            Welcome("Welcome in Print Name App :");
            PrintMassage("Ahmed Shaaban");
        }
        #endregion

        #region Printnamefrom user Function
        public static void PrintNameFromUser()
        {
            Welcome("Welcome in Print User Name App :");
            Console.WriteLine("Please Enter Your Name :");
            string userName = Console.ReadLine();
            PrintMassage(userName);
        }
        #endregion

        #region Sum2numbers Function
        // 3- Sum2numbers
        public static void Sum2numbers()
        {
            Welcome("Welcome in Sum Two Numbers App :");
            int number1, number2;

            if (!ReadNumder("Number 1", out number1))
                return;

            if (!ReadNumder("Number 2", out number2))
                return;

            PrintMassage($"{number1} + {number2} = {number1 + number2}");
        }
        #endregion

        #region Avarage3numbers Function
        // 4- Avarage3numbers
        public static void Avarage3numbers()
        {
            Welcome("Welcome in Avarage Three Numbers App :");
            int number1, number2, number3;

            if (!ReadNumder("Number 1", out number1))
                return;

            if (!ReadNumder("Number 2", out number2))
                return;

            if (!ReadNumder("Number 3", out number3))
                return;

            PrintMassage($"{number1} + {number2} + {number3} / 3  = {(double)((number1 + number2 + number3) / 3)}");
        }
        #endregion

        static void Main(string[] args)
        {
            PrintMassage("Welcome in Problem Solving App Please Enter Your App From Choices");
            Console.WriteLine("""
                1- Write your Name
                2- Print Name From User
                3- Sum Two Numbers
                4- Avarage Three Numbers
                """) ;

            int userChoiceNumbr;

            if(!ReadNumder("User Choices" ,out userChoiceNumbr))
               return;
            
            switch (userChoiceNumbr) { 
                case 1:
                    PrintName();
                    break;
                case 2:
                    PrintNameFromUser();
                    break;
                case 3:
                    Sum2numbers();
                    break;
                case 4:
                    Avarage3numbers();
                    break;
            }
        }
    }
}
