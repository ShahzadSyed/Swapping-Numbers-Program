using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace numberSwapping
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize & Declaration
            int number1 = 10, number2 = 20, temp = 0;
            
            //Before Swapping
            Console.WriteLine(@"Before Swapping number1= " + number1 + ", number2 = " + number2);

            //Re-initialized
            temp = number1; //temp=10
            number1 = number2; //number1=20      
            number2 = temp; //number2=10    

            //After Swapping
            Console.WriteLine(@"After Swapping number1= " + number1 + ", number2 = " + number2);
            

            /*
             *Swap two integers without using the third variable in C#
             */
            int randomNumber1 = 10, randomNumber2 = 20;
            //before Swapping
            Console.WriteLine(@"Before Swaping without using 3rd variable Number1 = " + randomNumber1 +",Number2 ="+randomNumber2);
            
            //Re-initialized
            randomNumber1 = randomNumber1 * randomNumber2;
            randomNumber2 = randomNumber1 / randomNumber2;
            randomNumber1 = randomNumber1 / randomNumber2;
            
            //After Swapping
            Console.WriteLine(@"After Swaping without using 3rd variable Number1 =" + randomNumber1 + ",Number2 =" + randomNumber2);
            Console.ReadKey();
        }
    }
}
