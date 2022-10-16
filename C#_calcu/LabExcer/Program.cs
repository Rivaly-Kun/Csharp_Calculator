using System;

namespace KaputanInaHan
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
            
                Console.Write("number 1 = ");
                string str = Console.ReadLine();
                if (str != "exit");

                {
                    
                    try
                    {
                        Char value = '.';
                        Boolean result = str.Contains(value);
                        if (result == false)
                        {
                            int num1 = Convert.ToInt32(str);
                            Console.Write("number 2 = ");
                            int num2 = Convert.ToInt32(Console.ReadLine());

                            Console.Write("number 3  = ");
                            int num3 = Convert.ToInt32(Console.ReadLine());

                            int sum = num1 + num2 + num3;
                            Console.WriteLine("Result: {0}", sum);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You have entered a decimal please try again");
                        }
                    }
                    catch (System.FormatException e)
                    {
                        Console.WriteLine("You have entered a letter please try again");
                    }
                }
            }
            while (true);
        }
    }
}