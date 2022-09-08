using System;

namespace P229Error
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lesson
            //string num1Str = Console.ReadLine();

            //string num2Str = Console.ReadLine();

            //try
            //{
            //    byte a = byte.Parse(num1Str);
            //    byte b = byte.Parse(num2Str);

            //    Console.WriteLine(a / b);
            //}
            //catch(DivideByZeroException)
            //{
            //    Console.WriteLine("Sifira Bolunme Emeliyyat Ola Bilmez");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Yalniz Reqem Daxil Edin");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("0 - 255 araliginda deyer daxil");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Sehflik var");
            //}
            //finally
            //{
            //    Console.WriteLine("Finaly Isledi");
            //}

            //int bigNum = 564654;
            //byte smallNum = 0;

            //try
            //{
            //    checked
            //    {
            //        smallNum = (byte)bigNum;
            //    }

            //    //unchecked
            //    //{
            //    //    smallNum = (byte)bigNum;
            //    //}
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("deyer Asimi Bas Verir");
            //}

            //Console.WriteLine(smallNum);

            //int num1 = 54894;
            //int num2 = 56421;

            //ReverseNum(46546);
            //int a = ReverseNum(num2);
            //Console.WriteLine(a);
            //Console.WriteLine(a*a);
            #endregion


            //int result1 = SumOfNumsDigitCoube(123);
            //int result2 = SumOfNumsDigitCoube(87979);
            //int result3 = SumOfNumsDigitCoube(324212);
            //int result4 = SumOfNumsDigitCoube(234456);
            //int result5 = SumOfNumsDigitCoube(321231);
            //int result6 = SumOfNumsDigitCoube(12315);

            //Console.WriteLine(result1);
            //Console.WriteLine(result2);
            //Console.WriteLine(result3);
            //Console.WriteLine(result4);
            //Console.WriteLine(result5);
            //Console.WriteLine(result6);

            int a = 564645;
            int result = SumOfNumsDigitCoube(a);
            int numasdasd = 0;

            int num1 = 0;
            int num2 = 0;
            bool check = false;
            Sum(num1, num2);
        }

        static void Sum(int a, int b, bool check)
        {

        }

        static void Sum(bool c, int a, int b)
        {

        }

        static void Sum(int a, int b=25, int c = 15)
        {

        }

        static void Sum(double a, double b)
        {

        }

        static int SumOfNumsDigitCoube(int num)
        {
            num = ReverseNum(num);

            int module = 0;
            int sum = 0;

            while(num > 0)
            {
                module = num % 10;
                num = (num - module) / 10;
                sum += module * module * module;
            }

            return sum;
        }


        static int ReverseNum(int a)
        {
            int module = 0;
            int reversedNum = 0;

            while (a > 0)
            {
                module = a % 10;
                a = (a - module) / 10;
                reversedNum = (reversedNum * 10) + module;
            }

            return reversedNum;
        }
    }
}
