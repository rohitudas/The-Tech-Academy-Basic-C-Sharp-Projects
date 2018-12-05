using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] StringAr = new string[2];
            StringAr[0] = "example text";
            string input1;

            Console.WriteLine("step 1:");
            Console.Write("Enter string:");
            input1 = Console.ReadLine();
            StringAr[1] = input1;

            Console.WriteLine("Array contains");
            for (int i = 0; i < 2; i++) 
            {
                Console.WriteLine((i+1)+". "+StringAr[i]);
            }
            Console.ReadLine();

            //STEP 2
            //int count = 0;
            //while (count < 1)
            //{
            //    Console.WriteLine("Infinte loop");
            //}

            Console.WriteLine("step 3 & 4:");
            int count = 0;
            while (count < 2)
            {
                Console.WriteLine(count + ". Infinite loop?");
                count += 1;
            }

            Console.WriteLine();
            Console.WriteLine("step 5");
            int count2 = 0;
            while (count2 <= 5)
            {
                Console.WriteLine((count2 + 1) + ". <= test (press enter)");
                Console.ReadLine();
                count2 = count2 + 1;
            }

            string input;
            Console.WriteLine("step 6 to 8");
            List<string> String2Ar = new List<string>();
            String2Ar.Add("Hello");
            String2Ar.Add("is");
            String2Ar.Add("it");
            String2Ar.Add("me");
            String2Ar.Add("you're");
            String2Ar.Add("looking");
            String2Ar.Add("for?");
            bool trigger = false;
            bool trigger2 = false;
            while (trigger == false)
            {
                Console.Write("Search(type quit to exit):");
                input = Console.ReadLine();
                for (int i = 0; i < String2Ar.Count; i++)
                {
                    if (input == String2Ar[i])
                    {
                        Console.WriteLine("Index " + i + " for " + String2Ar[i]);
                        trigger2 = false;
                        //^ to make sure no matches found doesn't display again.
                        break;
                    }
                    else if (input == "quit")
                    {
                        trigger = true;
                    }
                    else
                    {
                        trigger2 = true;
                    }
                    
                }
                if (trigger2 == true)
                {
                    Console.WriteLine("No matches found please try again.");
                }
            }


            List<string> stringList1 = new List<string>();
            stringList1.Add("not a cry for help");
            stringList1.Add("not a cry for help");
            stringList1.Add("not");
            stringList1.Add("a");
            stringList1.Add("cry");
            stringList1.Add("for");
            stringList1.Add("help");
            trigger = false;
            trigger2 = false;
            bool trigger3 = true;

            Console.WriteLine("step 10");
            while (trigger == false)
            {
                Console.Write("Search(type quit to exit):");
                input = Console.ReadLine();
                for (int i = 0; i < stringList1.Count; i++)
                {
                    if (input == stringList1[i])
                    {
                        Console.WriteLine("Index " + i + " for " + stringList1[i]);
                        trigger2 = false;
                        trigger3 = false;
                    }
                    else if (input == "quit")
                    {
                        trigger = true;
                    }
                    else
                    {
                        trigger2 = true;
                    }

                }

                if ((trigger2 == true) && (trigger3 == true)) 
                {
                    Console.WriteLine("No matches found please try again.");
                }
                trigger3 = true;
            }







            List<string> stringList = new List<string>();
            stringList.Add("not a cry for help");
            stringList.Add("not");
            stringList.Add("a");
            stringList.Add("cry");
            stringList.Add("for");
            stringList.Add("help");
            stringList.Add("not a cry for help");
 
            trigger = false;
            trigger2 = false;
            List<string> doubleCheck = new List<string>();
       
            int counter = 0;

            Console.WriteLine("step 11");
            
            foreach (string string2 in stringList)
            {
                foreach (string string1 in stringList)
                {
                    if (string2 == string1)
                    {
                        counter += 1;
                        
                    }

                }
                
                Console.WriteLine("\"" + string2 + "\"" + " list appearance count: " + counter + ".");
                counter = 0;

            }

            Console.ReadLine();

        }
    }
}
