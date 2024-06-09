using System;


namespace Project
{
    class MakeMath
    {
        public static void Main(string [] args)
        {
            Console.WriteLine("Please enter your dividend. ");
            string number1 = Console.ReadLine();

            Console.WriteLine("Please enter your divisor. ");
            string number2 = Console.ReadLine();

        
        try
        {
            int numb1 = Convert.ToInt32(number1);
            int numb2 = Convert.ToInt32(number2);
            
            int result = numb1 / numb2;
            Console.WriteLine(numb1  + " divided by " + numb2  + " equals " + result);
        }
        catch (FormatException)
        {
            Console.WriteLine("At least one of your numbers is not an integer. Please enter an integer.");

        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Undefined - You cannot divide by 0");


        }
        catch (OverflowException)
        {
            Console.WriteLine("Uh Oh! Let's use smaller numbers!");
        }      
        }

    
    }

}
