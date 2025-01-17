﻿using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        #region SelectProgram Function
        public static void SelectProgram(int userChoiceNumbr)
        {
            switch (userChoiceNumbr)
            {
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
                case 5:
                    Areaofrectangle();
                    break;
                case 6:
                    Areaoftriangle();
                    break;
                case 7:
                    CircleAreaThroughDiameter();
                    break;
                case 8:
                    PrintUserInfo();
                    break;
                case 9:
                    HelfNumber();
                    break;
                case 10:
                    SwapTwoNumbers();
                    break;
                case 11:
                    PassOrFail();
                    break;
                case 12:
                    CanEnterColledge();
                    break;
                case 13:
                    OddOrEven();
                    break;
                case 14:
                    CentureOfTheYear();
                    break;
                case 15:
                    ValidatePercentage();
                    break;
                case 16:
                    CompareTwoNumbers();
                    break;
                case 17:
                    CompareThreeNumbers();
                    break;
                case 18:
                    SalesSalary();
                    break;
                case 19:
                    PrintSumFrom1To99();
                    break;
                case 20:
                    MultiplyFrom1ToN();
                    break;
                case 21:
                    SumFromNto1();
                    break;
                case 22:
                    SubtractFrom1toN();
                    break;
                case 23:
                    GetMaxNumberFromUserChoices();
                    break;
            }
        }
        #endregion

        #region ReadString Function
        public static string ReadString(string fieldNumber)
        {
            Console.Write($"Please Enter {fieldNumber} :");
            return Console.ReadLine();
        }
        #endregion

        #region ReadChar Function
        public static bool ReadChar(string fieldNumber, out char userChar)
        {
            bool Flag;

            Console.Write($"Please Enter {fieldNumber} \"Y\" for Yes or \"N\" for No :");
            Flag = char.TryParse(Console.ReadLine(), out userChar);
            if (!Flag)
            {
                Console.WriteLine("Invalid Input Try Again");
                return false;
            }

            return true;
        }
        #endregion

        #region ReadDecimalNumder Function
        public static bool ReadDecimalNumder(string fieldNumber, out decimal number)
        {
            bool Flag;

            Console.Write($"Please Enter {fieldNumber} :");
            Flag = decimal.TryParse(Console.ReadLine(), out number);
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

        #region Areaofrectangle
        public static void Areaofrectangle()
        {
            Welcome("Welcome in Area Of Rectangle App :");
            int length, width;

            if (!ReadNumder("The Length Of Rectangle", out length))
                return;

            if (!ReadNumder("The Width Of Rectangle", out width))
                return;

            PrintMassage($"The Area Of Rectangle = {length} * {width} = {length * width}");
        }
        #endregion

        #region Areaoftriangle
        public static void Areaoftriangle()
        {
            Welcome("Welcome in Area Of Triangle App :");
            int theBase, hight;

            if (!ReadNumder("The Base Of Triangle", out theBase))
                return;

            if (!ReadNumder("The Hight Of Triangle", out hight))
                return;

            PrintMassage($"The Area Of Triangle = .5 * {theBase} * {hight} = {.5 * theBase * hight}");
        }
        #endregion

        #region PrintUserInfo
        public static void PrintUserInfo()
        {
            Welcome("Welcome in Print User Info App :");

            PrintMassage($"""
                        Your Name is : {ReadString("Your Name")}
                        Your Jop Title is : {ReadString("Your Job Title")}
                        Working At : {ReadString("Your Company You Working At")}
                        """);
        }
        #endregion

        #region Helf Number Function
        public static void HelfNumber()
        {
            Welcome("Welcome in Helf Number App :");
            int number;

            if (!ReadNumder("Number ", out number))
                return;

            PrintMassage($"Helf Of {number} = {number} / 2 = {number/2}");
        }
        #endregion

        #region Areaoftriangle
        public static void CircleAreaThroughDiameter()
        {
            Welcome("Welcome in Circle Area Through Diameter App :");
            int diameter;

            if (!ReadNumder("The Diameter Of Circle", out diameter))
                return;

            PrintMassage($"The Circle Area Through Diameter = (3.14*4) / ({diameter} * {diameter}) = {(3.14*4) / (diameter * diameter)}");
        }
        #endregion

        #region Swap Two Numbers Function
        public static void SwapTwoNumbers()
        {
            Welcome("Welcome in Swap Two Numbers App :");
            int number1, number2 , temp;

            if (!ReadNumder("Number 1", out number1))
                return;

            if (!ReadNumder("Number 2", out number2))
                return;

            temp = number1;
            number1 = number2;
            number2 = temp;

            PrintMassage($"Numbers After Swaping Number 1 = {number1} , Number 2 = {number2}");
        }
        #endregion

        #region PassOrFail Function
        public static void PassOrFail()
        {
            Welcome("Welcome in Pass Or Fail App :");
            int userGrade;
            if (!ReadNumder("Your Grade", out userGrade))
                return;
            if (userGrade < 50)
                PrintMassage("Fail");
            else
                PrintMassage("Pass");
        }

        #endregion

        #region CanEnterColledge Function
        public static void CanEnterColledge()
        {
            Welcome("Welcome in Can Enter Colledge App :");
            int userGrade;
            char canPay;

            if (!ReadNumder("Your Grade", out userGrade))
                return;

            if (userGrade >= 90)
                PrintMassage("Accepted");
            else
            {
                if (!ReadChar("If You can Pay Or not", out canPay))
                    return;

                if (canPay.ToString().ToLower() == "y")
                    PrintMassage("Accepted");
                else
                    PrintMassage("Rejected");
            }
        }
        #endregion

        #region OddOrEven Function
        public static void OddOrEven()
        {
            Welcome("Welcome in Odd Or Even App :");
            int userNumber;

            if (!ReadNumder("Your Number", out userNumber))
                return;

            if (userNumber % 2 == 0)
                PrintMassage($"{userNumber} is Odd");
            else
                PrintMassage($"{userNumber} is Even");
        }
        #endregion

        #region CentureOfTheYear Function
        public static void CentureOfTheYear()
        {
            Welcome("Welcome in Centure Of The Year App :");
            int userYear;

            if (!ReadNumder("Your Year You Wanna know Centure it", out userYear))
                return;

            if (userYear % 100 == 0)
                PrintMassage($"The Centure Of The Year Is : {userYear / 100}");
            else
                PrintMassage($"The Centure Of The Year Is : {(userYear / 100) + 1}");
        }
        #endregion

        #region ValidatePercentage Function
        public static void ValidatePercentage()
        {
            Welcome("Welcome in Validate Percentage App :");
            int userPercentage;

            if (!ReadNumder("Your Percentage Number", out userPercentage))
                return;

            if (userPercentage >= 0 && userPercentage <= 100)
                PrintMassage($"{userPercentage} is Valid Percentage");
            else
                PrintMassage($"{userPercentage} is Invalid Percentage");
        }
        #endregion

        #region CompareTwoNumbers Function
        public static void CompareTwoNumbers()
        {
            Welcome("Welcome in Compare Two Numbers App :");
            int userNum1, userNum2;

            if (!ReadNumder("Number1", out userNum1))
                return;

            if (!ReadNumder("Number2", out userNum2))
                return;

            if (userNum1 > userNum2)
                PrintMassage($"{userNum1} is Greater than {userNum2}");
            else if (userNum1 < userNum2)
                PrintMassage($"{userNum2} is Greater than {userNum1}");
            else
                PrintMassage($"{userNum1} It equals {userNum2}");
        }
        #endregion

        #region CompareThreeNumbers Function
        public static void CompareThreeNumbers()
        {
            Welcome("Welcome in Compare Three Numbers App :");
            int userNum1, userNum2, userNum3;

            if (!ReadNumder("Number1", out userNum1))
                return;

            if (!ReadNumder("Number2", out userNum2))
                return;

            if (!ReadNumder("Number3", out userNum3))
                return;

            if (userNum1 > userNum2 && userNum1 > userNum3)
                PrintMassage($"{userNum1} is Greater than {userNum2} and {userNum3}");
            else if (userNum2 > userNum1 && userNum2 > userNum3)
                PrintMassage($"{userNum2} is Greater than {userNum1} and {userNum3}");
            else if (userNum3 > userNum1 && userNum3 > userNum2)
                PrintMassage($"{userNum3} is Greater than {userNum1} and {userNum2}");
            else
                PrintMassage($"{userNum1} , {userNum2} , {userNum3} : Are Equal to each other");
        }
        #endregion

        #region SalesSalary Function
        public static void SalesSalary()
        {
            Welcome("Welcome in Sales App :");
            decimal sales, salary , commission;

            if (!ReadDecimalNumder("your Fixed Salary", out salary))
                return;

            if (!ReadDecimalNumder("your Total Sales", out sales))
                return;

            if (sales >= 1000000)
            {
                commission = 0.01m;
                PrintMassage($"Your salary after commission (0.01 * {salary}) = {salary += salary * commission}");
            }
            else if (sales >= 500000)
            {
                commission = 0.02m;
                PrintMassage($"Your salary after commission (0.02 * {salary}) = {salary += salary * commission}");
            }
            else if (sales >= 100000)
            {
                commission = 0.03m;
                PrintMassage($"Your salary after commission (0.03 * {salary}) = {salary += salary * commission}");
            }
            else if (sales >= 50000)
            {
                commission = 0.04m;
                PrintMassage($"Your salary after commission (0.04 * {salary}) = {salary += salary * commission}");
            }
            else
                PrintMassage("You don't have a commission.");
        }
        #endregion

        #region PrintSumFrom1To99 Function
        public static void PrintSumFrom1To99()
        {
            Welcome("Welcome in Print Sum From 1 To 99 App :");

            int sum = 0;

            for (int i = 1; i <= 99; i++)
            {
                sum += i;
            }

            PrintMassage($"Numbers Sum from 1 to 99 = {sum}");
        }
        #endregion

        #region MultiplyFrom1ToN Function
        public static void MultiplyFrom1ToN()
        {
            Welcome("Welcome in Multiply From 1 To N App :");

            int userNum, resuilt = 1;

            if (!ReadNumder("Number you Wanna Multiply to it", out userNum))
                return;

            for (int i = 1; i <= userNum; i++)
            {
                resuilt *= i;
            }

            PrintMassage($"Multiply Numbers from 1 to {userNum} = {resuilt}");
        }
        #endregion

        #region SumFromNto1 Function
        public static void SumFromNto1()
        {
            Welcome("Welcome in Sum From N to 1 App :");

            int userNum, resuilt = 0;

            if (!ReadNumder("Number you Wanna Sum from it", out userNum))
                return;

            for (int i = userNum; i >= 1; i--)
            {
                resuilt += i;
            }

            PrintMassage($"Sum Numbers from {userNum} to 1 = {resuilt}");
        }
        #endregion

        #region SubtractFromNto1 Function
        public static void SubtractFrom1toN()
        {
            Welcome("Welcome in Subtract From 1 to N App :");

            int userNum, resuilt = 0;

            if (!ReadNumder("Number you Wanna Subtract to it", out userNum))
                return;

            for (int i = 1; i <= userNum; i++)
            {
                resuilt -= i;
            }

            PrintMassage($"Subtracting Numbers from {userNum} to 1 = {resuilt}");
        }
        #endregion

        #region GetMaxNumberFromUserChoices Function
        public static void GetMaxNumberFromUserChoices()
        {
            Welcome("Welcome in Get Max Number From User Choices App :");

            int maxNum = 0, userNum, userCounter;

            if (!ReadNumder("Number you Wanna Count to it", out userCounter))
                return;

            for (int i = 0; i < userCounter; i++)
            {
                if (!ReadNumder("Number you Wanna Check it if Max or Not", out userNum))
                    return;

                if (userNum > maxNum)
                    maxNum = userNum;
            }

            PrintMassage($"Max Number = {maxNum}");
        } 
        #endregion

        static void Main(string[] args)
        {
            bool isWorking = true;
            char userChoice ;

            while (isWorking)
            {
                PrintMassage("Welcome in Problem Solving App Please Enter Your App From Choices");
                Console.WriteLine("""
                1- Write your Name
                2- Print Name From User
                3- Sum Two Numbers
                4- Avarage Three Numbers
                5- Area Of Rectangle
                6- Area Of Triangle
                7- Circle Area Through Diameter
                8- Print FullName
                9- Helf Number
                10- Swap Two Numbers
                11- Pass Or Fail
                12- Can Enter Colledge
                13- Odd Or Even
                14- Centure Of The Year
                15- Validate Percentage
                16- Compare Two Numbers
                17- Compare Three Numbers
                18- Sales Salary
                19- Print Sum From 1 To 99
                20- Multiply From 1 To N
                21- Sum From N to 1
                22- Subtract From 1 to N
                23- Get Max Number From User Choices
                """);

                int userChoiceNumbr;

                if (!ReadNumder("User Choices", out userChoiceNumbr))
                    return;
                SelectProgram(userChoiceNumbr);


                ReadChar("Are you Wanna continue",out userChoice);

                if (userChoice.ToString().ToLower() == "y")
                {
                    Console.Clear();
                    isWorking = true;
                }
                else
                    isWorking = false;
            }
        }
    }
}
