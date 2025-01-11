namespace C_sharp_Problem_Solving
{
    internal class Program
    {
        #region Writeyourname Function
        //// 1- Writeyourname
        //public static void PrintName()
        //{
        //    Console.WriteLine("Welcome in Print Name App :");
        //    PrintMassage("Ahmed Shaaban");
        //} 
        #endregion

        #region Printnamefromuser Function
        //// 2- Printnamefromuser
        //public static void PrintNameFromUser()
        //{
        //    Console.WriteLine("Welcome in Print User Name App :");
        //    Console.WriteLine("Please Enter Your Name :");
        //    string userName = Console.ReadLine();
        //    PrintMassage(userName);
        //} 
        #endregion

        #region Print Massage Function
        // Print Massage 
        public static void PrintMassage(string massage)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine(massage);
            Console.WriteLine("--------------------------------");
        }
        #endregion

        ////////////////////////////////////////////////////////////

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

        #region Sum2numbers Function
        // 3- Sum2numbers
        //public static void Sum2numbers()
        //{
        //    Console.WriteLine("Welcome in Sum Two Numbers App :");
        //    int number1, number2;

        //    if (!ReadNumder("Number 1", out number1))
        //        return;

        //    if (!ReadNumder("Number 2", out number2))
        //        return;

        //    PrintMassage($"{number1} + {number2} = {number1 + number2}");
        //} 
        #endregion

        #region Avarage3numbers Function
        // 4- Avarage3numbers
        //public static void Avarage3numbers()
        //{
        //    Console.WriteLine("Welcome in Avarage Three Numbers App :");
        //    int number1, number2, number3;

        //    if (!ReadNumder("Number 1", out number1))
        //        return;

        //    if (!ReadNumder("Number 2", out number2))
        //        return;

        //    if (!ReadNumder("Number 3", out number3))
        //        return;

        //    PrintMassage($"{number1} + {number2} + {number3} / 3  = {(double)((number1 + number2 + number3) / 3)}");
        //} 
        #endregion

        static void Main(string[] args)
        {
            // 1- Writeyourname
            //PrintName();

            // 2- Printnamefromuser
            //PrintNameFromUser();

            ///////////////////////////////////////////////////////

            // 3 - Sum2numbers
            //Sum2numbers();

            // 4- Avarage3numbers
            //Avarage3numbers();
        }
    }
}
