using System;

namespace PracticeCode
{
    class One
    {
        public int x = 5, y = 2;
        public int addResult, subResult;
        public int Add()
        {
            addResult = x + y;
            return addResult;
        }
        public int Subtract()
        {
            subResult = x - y;
            return subResult;
        }
    }

    class Two : One
    {
        public int multResult;
        public int Multiply()
        {
            multResult = Add() * Subtract();
            return multResult;
        }
    }
    class Three
    {   
    static void Main(string[] args)
       {
            One myOne = new One();
            Two myTwo = new Two();

            Console.WriteLine("5 + 2 = " + myOne.Add() + "\n" + "5 - 2 = " + myTwo.Subtract() 
                + "\n" + "5 * 2 = " + myTwo.Multiply());
        }
    }
}