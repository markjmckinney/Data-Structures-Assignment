/*
 *Mark McKinney
 *Tim Robertson
 *Sam Roberts
 *Joseph Potter
 *IS 403 Group 2-9
 * 
 * Data Structures Assignment

This is a program in C# using a console application that demonstrates the use of a Stack, Queue, and Dictionary (Map). I want you to start trying to use GitHub for this assignment.

Make sure you document your code. This might seem like a big program but it really isn't since a lot of the code is copied and reused. In fact, it might be a good idea as a group to divide up the work and then try to bring it all together into one project.

When completed, everyone needs to zip the project and upload to Learning Suite and make sure code is committed to GitHub.

As a group, schedule a time with the TAs for grading
 * 
 * 
 * 
 * */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> myStack = new Stack<string>();
            Queue<string> myQueue = new Queue<string>();
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();

            

            Boolean a = true;

            
            while (a == true)
            {
                Console.WriteLine("1. Stack \n2. Queue \n3. Dictionary \n4. Exit");
                int input = Convert.ToInt32(Console.ReadLine());
                int input2 = 0;
                string inputque1;
                switch (input)
                {
                    case 1: Console.WriteLine("1. Add one time to Stack");
                        Console.WriteLine("2. Add Huge List of Items to Stack");
                        Console.WriteLine("3. Display Stack");
                        Console.WriteLine("4. Delete from Stack");
                        Console.WriteLine("5. Clear Stack");
                        Console.WriteLine("6. Search Stack");
                        Console.WriteLine("7. Return to Main Menu");
                        input2 = Convert.ToInt32(Console.ReadLine());
                        switch (input2)
                        {
                            case 1:
                                Console.WriteLine("Enter in a String value");
                                String input3 = Console.ReadLine();
                                myStack.Push(input3);
                                break;
                            case 2:
                                myStack.Clear();
                                for (int i = 0; i < 2000; i++)
                                {
                                    Console.WriteLine("New Entry " + i);
                                }
                                break;
                            case 3:
                                foreach (String item in myStack)
                                {
                                    Console.WriteLine(item);

                                }
                                break;
                            case 4: break;
                            case 5: break;
                            case 6: break;
                            case 7: break;
                        }
                        break;

                    case 2: 
                        
                        
                        Console.WriteLine("1. Add one time to Queue");
                        Console.WriteLine("2. Add Huge List of Items to Queue");
                        Console.WriteLine("3. Display Queue");
                        Console.WriteLine("4. Delete from Queue");
                        Console.WriteLine("5. Clear Queue");
                        Console.WriteLine("6. Search Queue");
                        Console.WriteLine("7. Return to Main Menu");
                        input2 = Convert.ToInt32(Console.ReadLine());
                        switch (input2)
                        {
                            case 1:
                                Console.WriteLine("Please enter a 'string' value");
                               
                                //need to do a try catch here. haven't done it yet
                                
                                inputque1 = Console.ReadLine();
                                myQueue.Enqueue(inputque1);

                                Console.WriteLine("\n\n\n");

                                
                                break;
                                


                            case 2:
                                
                                myQueue.Clear();
                               
                               
                                while(myQueue.Count <= 2000)
                                {
                                    myQueue.Enqueue("New Entry " + myQueue.Count.ToString());


                                }

                                Console.WriteLine("\n\n\n");

                                break;

                            case 3: 
                                
                                foreach(string item in myQueue)
                                {
                                    Console.WriteLine(item);
                                }
                                Console.WriteLine("\n\n\n");
                                break;

                            case 4:





                                Console.WriteLine("\n\n\n");

                                break;

                            case 5:


                                Console.WriteLine("\n\n\n");

                                break;

                            case 6:


                                Console.WriteLine("\n\n\n");

                                break;

                            case 7:


                                Console.WriteLine("\n\n\n");

                                break;



                        }
                        break;
                    case 3: Console.WriteLine("1. Add one item to Dictionary");
                        Console.WriteLine("2. Add Huge List of Items to Dictionary");
                        Console.WriteLine("3. Display Dictionary");
                        Console.WriteLine("4. Delete from Dictionary");
                        Console.WriteLine("5. Clear Dictionary");
                        Console.WriteLine("6. Search Dictionary");
                        Console.WriteLine("7. Return to Main Menu");

                        input = Convert.ToInt32(Console.ReadLine());
                        switch (input2)
                        {
                            case 1: break;

                            case 2: break;

                            case 3: break;

                            case 4: break;

                            case 5: break;

                            case 6: break;

                            case 7: break;



                        }

                        break;
                    default: a = false; break;
                }
            }
        }
    }
}
