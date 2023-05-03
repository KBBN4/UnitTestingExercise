using System;
namespace UnitTestingExercise.Tests
{
	public class Method
	{
        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public int Subtract(int minuend, int subtrhend, int expected)
        {
            //throw new NotImplementedException();

            return minuend - subtrhend;

        }

        public int Multiplication(int num1, int num2, int expected)
        {

            return num1 * num2;
        }

        public int Division ( int num1 , int num2, int expected)
        {
            return num1 / num2;
           
        }


        
    }
}

