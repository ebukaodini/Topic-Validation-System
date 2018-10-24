using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            string[] category = new string[10];
            string[] topics = new string[30];
            int[,] rate = new int[30, 2];

            //calling the initialization procedure
            init(category, rate, topics);

            Console.WriteLine("A Project - Seminar Validation System");
            Console.WriteLine("=====================================");

            Console.WriteLine("I am picking a Topic for ...");
            Console.WriteLine("1) Project.");
            Console.WriteLine("2) Seminar");
            int type = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Menu"); //a menu list to select from
            Console.WriteLine("====");
            Console.WriteLine("1) Select Topics from List.");
            Console.WriteLine("2) Show Topic Category.");
            Console.WriteLine("3) Exit");
            int menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    print_topics(topics);

                    Console.WriteLine("\nTopic 1.");
                    int t1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Topic 2.");
                    int t2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Topic 3.");
                    int t3 = int.Parse(Console.ReadLine());

                    topic_pick(topics, rate, type, t1, t2, t3);
                    break;
                case 2:
                    print_category(category);
                    break;
                case 3:
                    Console.WriteLine("Bye.");
                    Console.ReadKey();
                    break;
            }
        }

        static void print_topics(string[] topics)
        {
            Console.Clear();
            Console.WriteLine("List of Topics you can pick from.");
            Console.WriteLine("=================================");
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine((i + 1) + " - " + topics[i]);
            }
        }

        static void print_category(string[] category)
        {
            Console.Clear();
            Console.WriteLine("List of Topic Category.");
            Console.WriteLine("========================");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine((i + 1) + " - " + category[i]);
            }
        }

        static void init(string[] category, int[,] rate, string[] topics)
        {
            //initialization process of the program
            //assigning topics to arrays
            Console.Title = "A Project - Seminar Validation System.";
            topics[0] = "Children Tracking System using Bluetooth MANET Composed of Android Mobile Terminals.";
            topics[1] = "Automatic Brightness Control of the Hand-Held Device Display with low illumination.";
            topics[2] = "A Personalized  Mobile Search Engine (PSME).";

            topics[3] = "Online Shopping.";
            topics[4] = "Online Auction System.";
            topics[5] = "Simple PHP Blog without database.";

            topics[6] = "Result Alert System with Email and SMS.";
            topics[7] = "Employee Tracking System.";
            topics[8] = "ATM Reporting System.";

            topics[9] = "A machine learning approach in financial markets.";
            topics[10] = "Real Time Speech Driven Face Animation.";
            topics[11] = "Face Detection by image discriminating.";

            topics[12] = "Design and implementation of a medical diagnostic system.";
            topics[13] = "Design and implementation of a web base office management system.";
            topics[14] = "Design and implementation of campus online Help Desk information system.";

            topics[15] = "Analysis of Algorithm.";
            topics[16] = "Genetic Algorithm.";
            topics[17] = "Dijkstra's Algorithm.";

            topics[18] = "First person shooter.";
            topics[19] = "Snake and Ladder.";
            topics[20] = "Simple Arcade Game.";

            topics[21] = "A scientific Calculator.";
            topics[22] = "Calender.";
            topics[23] = "Stopwatch.";

            topics[24] = "Using pointer to map the cities in Nigeria.";
            topics[25] = "Implementing queues in a payroll system.";
            topics[26] = "Implementing queues in a traffic light system.";

            topics[27] = "A statistics softare for questionnaires.";
            topics[28] = "Implementing Linear programming in research methodology.";
            topics[29] = "A research on the success rate of students in Computer Science.";

            //rating values stored in array
            rate[0, 0] = 3; rate[0, 1] = 1;
            rate[1, 0] = 1; rate[1, 1] = 3;
            rate[2, 0] = 2; rate[2, 1] = 0;

            rate[3, 0] = 1; rate[3, 1] = 1;
            rate[4, 0] = 3; rate[4, 1] = 1;
            rate[5, 0] = 2; rate[5, 1] = 2;

            rate[6, 0] = 1; rate[6, 1] = 1;
            rate[7, 0] = 3; rate[7, 1] = 1;
            rate[8, 0] = 3; rate[8, 1] = 1;

            rate[9, 0] = 0; rate[9, 1] = 3;
            rate[10, 0] = 2; rate[10, 1] = 1;
            rate[11, 0] = 2; rate[11, 1] = 1;

            rate[12, 0] = 3; rate[12, 1] = 0;
            rate[13, 0] = 3; rate[13, 1] = 0;
            rate[14, 0] = 3; rate[14, 1] = 0;

            rate[15, 0] = 1; rate[15, 1] = 2;
            rate[16, 0] = 1; rate[16, 1] = 2;
            rate[17, 0] = 1; rate[17, 1] = 2;

            rate[18, 0] = 0; rate[18, 1] = 3;
            rate[19, 0] = 0; rate[19, 1] = 2;
            rate[20, 0] = 1; rate[20, 1] = 2;

            rate[21, 0] = 1; rate[21, 1] = 1;
            rate[22, 0] = 1; rate[22, 1] = 1;
            rate[23, 0] = 1; rate[23, 1] = 1;

            rate[24, 0] = 0; rate[24, 1] = 3;
            rate[25, 0] = 3; rate[25, 1] = 0;
            rate[26, 0] = 3; rate[26, 1] = 0;

            rate[27, 0] = 1; rate[27, 1] = 2;
            rate[28, 0] = 3; rate[28, 1] = 0;
            rate[29, 0] = 3; rate[29, 1] = 1;

            // Topic Categories
            category[0] = "App Development.";
            category[1] = "Web Development.";
            category[2] = "Database Engine.";
            category[3] = "Artificial Intelligence and Robotics.";
            category[4] = "System Analysis.";
            category[5] = "Algorithm Formulation.";
            category[6] = "Game Developments.";
            category[7] = "Basic Softwares.";
            category[8] = "Data Structures.";
            category[9] = "Research Methodology.";
        }

        static void topic_pick(string[] topics, int[,] rate, int type, int t1, int t2, int t3)
        {
            if (type == 1)
            { //local variables
                int[] list = new int[3];
                string[] name = new string[3];

                //collecting the rating of the selected topics into the array list
                list[0] = rate[(t1 - 1), 0];
                list[1] = rate[(t2 - 1), 0];
                list[2] = rate[(t3 - 1), 0];

                //collecting the selected topics into the array name
                name[0] = topics[(t1 - 1)];
                name[1] = topics[(t2 - 1)];
                name[2] = topics[(t3 - 1)];

                int pick = list.Max(); //gets the maximum value in the list array

                Console.Clear();
                //outputting the selected topics
                Console.WriteLine("Selected Topics");
                Console.WriteLine("===============");
                Console.WriteLine("1. " + topics[(t1 - 1)]);
                Console.WriteLine("2. " + topics[(t2 - 1)]);
                Console.WriteLine("3. " + topics[(t3 - 1)]);

                //if no valid project topic was selected, randomly pick one from topics array;
                if (list[0] < 2 && list[1] < 2 && list[2] < 2)
                {
                    Console.WriteLine("\nNone of the Topic is a Project Topic.");
                    Console.WriteLine("Here is a randomly selected Project Topic");
                    int b = 0;
                    do
                    {
                        Random a = new Random();
                        b = a.Next(30);
                    }while(rate[b, 0] < 2);
                    Console.WriteLine(topics[b]);
                }
                else { //else pick the best choice from selected project topics
                    Console.WriteLine("\nProject Topic: ");
                    int ans = (index(list, pick) - 1);
                    Console.WriteLine(name[ans]);
                }
            }
            else if (type == 2)
            {
                int[] list = new int[3];
                string[] name = new string[3];

                //collecting the rating of the selected topics into the array list
                list[0] = rate[(t1 - 1), 1];
                list[1] = rate[(t2 - 1), 1];
                list[2] = rate[(t3 - 1), 1];

                //collecting the selected topics into the array name
                name[0] = topics[(t1 - 1)];
                name[1] = topics[(t2 - 1)];
                name[2] = topics[(t3 - 1)];

                int pick = list.Max();

                Console.Clear();
                //outputting the selected topics
                Console.WriteLine("Selected Topics");
                Console.WriteLine("===============");
                Console.WriteLine("1. " + topics[(t1 - 1)]);
                Console.WriteLine("2. " + topics[(t2 - 1)]);
                Console.WriteLine("3. " + topics[(t3 - 1)]);

                //if no valid project topic was selected, randomly pick one from topics array;
                if (list[0] < 2 && list[1] < 2 && list[2] < 2)
                {
                    Console.WriteLine("\nNone of the Topic is a Seminar Topic.");
                    Console.WriteLine("Here is a randomly selected Seminar Topic");
                    int b = 0;
                    do
                    {
                        Random a = new Random();
                        b = a.Next(30);
                    } while (rate[b, 1] < 2);
                    Console.WriteLine(topics[b]);
                }
                else { //else pick the best choice from selected project topics
                    Console.WriteLine("\nSeminar Topic: ");
                    int ans = (index(list, pick) - 1);
                    Console.WriteLine(name[ans]);
                }
            }
        }

        static int index(int[] array, int val)
        {//function to get the index of an array value
            int ans = 0;
            
            if (array[0] == val) {
                ans = 1;
            }
            if (array[1] == val)
            {
                ans = 2;
            }
            if (array[2] == val)
            {
                ans = 3;
            }
            
            return ans;
        }

    }
}
