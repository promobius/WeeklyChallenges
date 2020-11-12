using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            var result = minuend - subtrahend;
            return result;
        }

        public int Add(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
           if (number1 < number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }

        public long Multiply(long factor1, long factor2)
        {
            var result = factor1 * factor2;
            return result;
        }

        public string GetGreeting(string nameOfPerson)
        {
            if (nameOfPerson == "")
            {
                return "Hello!";
            }

            string expectedgreet = ($"Hello, {nameOfPerson}!");
            return expectedgreet;
           
         
          
        }

        public string GetHey()
        {

            return "HEY!";
        }    
    }
}
