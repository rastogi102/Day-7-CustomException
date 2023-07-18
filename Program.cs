using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppCustomEx
{
    public class CustomException : Exception
    {
        public CustomException(string message):base(message) 
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                int userAge;
                Console.WriteLine("Enter your age");
                userAge=int.Parse(Console.ReadLine());
                if (userAge < 0)
                {
                    throw new CustomException("Age should be negative number, Please enter positive Number only");
                }
                else if(userAge >= 18) 
                {
                    Console.WriteLine("YOu are eligible for voting");
                }
                else
                {
                    Console.WriteLine("You are not eligible for voting,You have to Wait");

                }
                
                
            }
            catch(CustomException ce) 
            {
                Console.WriteLine("Custom Error!!!" + ce.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error!!!"+ex.Message);
            }
            finally 
            {
                Console.WriteLine("***Bye Bye***");
                Console.ReadKey();
            }
        }
    }
}
