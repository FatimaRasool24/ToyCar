using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Domain1
{
    class Program
    {
        static void Main(string[] args)
        {
         try { 
                Console.WriteLine("How many cars do you want?");
                int amount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your order total will be {0} dollars", amount*16);
         } 
        catch (Exception ex)
        {
                Console.WriteLine(ex.Message);
        }
        GC.Collect();
        Console.WriteLine("Memory used: {0}", GC.GetTotalMemory(true));
        }
    } 
 }
    

    