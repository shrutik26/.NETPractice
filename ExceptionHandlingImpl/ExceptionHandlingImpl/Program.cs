using System;
using System.IO;

namespace ExceptionHandlingImpl
{
    public class PracticeApp
    {
        public void Math()
        {
            try
            {
                int x = 0;
                int sum = 100 / x;
            }
            catch (DivideByZeroException)
            {
                throw;
            }
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {

            //int x = 0;
            //int div = 100 / x;
            //Console.WriteLine(div);

            //TRY CATCH BLOCK

            //int x = 0;
            //int div = 0;
            //try
            //{
            //    div = 100 / x;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Exception Occured" , ex);
            //}
            //finally
            //{
            //    Console.WriteLine("Inside Finally Block");
            //}
            //Console.WriteLine($"Result is {0}");


            // MULTIPLE CATCH BLOCK

            //int x = 0;
            //int div = 0;
            //try
            //{
            //    div = 100 / x;
            //    Console.WriteLine("Not executed line");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Exception Occured");
            //}
            //catch
            //{
            //    Console.WriteLine("Inside Catch block");
            //}
            //finally
            //{
            //    Console.WriteLine("Inside Finally Block");
            //}
            //Console.WriteLine($"Result is {0}");

            //PracticeApp practiceApp = new PracticeApp();
            //try
            //{
            //    practiceApp.Math();
            //}
            //catch(Exception)
            //{
            //    Console.WriteLine("Exception Occured");
            //}
            //Console.WriteLine("Program execution completed");


            try
            {
                using StreamReader streamReader = new StreamReader(@"D:\.NET_Practice");
                var content = streamReader.ReadToEnd();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error Occured",ex);
            }
        }
    }
}
