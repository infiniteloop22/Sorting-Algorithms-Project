using System.Diagnostics;

namespace SortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double iterativeTotalTime = 0, iterativeAverageTime = 0, recursiveTotalTime = 0, recursiveAverageTime = 0;
            const string INPUT_PROMPT = "Please input a file path: "/*or enter 'exit' to exit the recursive loop: "*/;
            string userInput;
            List<int> list = new List<int>();
            List<Book> bookList = new List<Book>();
            Stopwatch stopwatch = new Stopwatch();
            IterativeSort iterativeSort = new IterativeSort();
            RecursiveSort recursiveSort = new RecursiveSort();
            Book book = new Book();

            //do
            //{
                Console.Write(INPUT_PROMPT);
                userInput = Console.ReadLine();

                //Console.WriteLine("\n" + userInput);

                //if (userInput != "exit")
                //{
                    /*for (int i = 1; i <= 5; i++)
                    {
                        list = LoadIntegerTestData(userInput);
                        stopwatch.Reset();
                        stopwatch.Start();
                        iterativeSort.Sort(list);
                        stopwatch.Stop();
                        iterativeTotalTime += stopwatch.Elapsed.TotalMilliseconds;
                    }
                    iterativeAverageTime = iterativeTotalTime / 5;
                    Console.WriteLine("\n" + "Iterative sorting algorithm average run time (ms): {0} \n", iterativeAverageTime);

                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

                    for (int i = 1; i <= 5; i++)
                    {
                        list = LoadIntegerTestData(userInput);
                        stopwatch.Reset();
                        stopwatch.Start();
                        recursiveSort.Sort(list);
                        stopwatch.Stop();
                        recursiveTotalTime += stopwatch.Elapsed.TotalMilliseconds;
                    }
                    recursiveAverageTime = recursiveTotalTime / 5;
                    Console.WriteLine("\n" + "Recursive sorting algorithm average run time (ms): {0} \n", recursiveAverageTime);*/

                    //Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

                    //iterativeTotalTime = 0;
                    //recursiveTotalTime = 0;
                    for (int i = 1; i <= 1; i++)
                    {
                        bookList = LoadBookTestData(userInput);
                        stopwatch.Reset();
                        stopwatch.Start();
                        bookList.Sort(); 
                        stopwatch.Stop();
                        iterativeTotalTime += stopwatch.Elapsed.TotalMilliseconds;
                    }
                    iterativeAverageTime = iterativeTotalTime / 5;
                    Console.WriteLine("\n" + "Iterative sorting algorithm average run time (ms): {0} \n", iterativeAverageTime);
                    /*foreach (Book item in bookList)
                    {
                        Console.WriteLine(item.ToString());
                    }*/

                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");

                    for (int i = 1; i <= 5; i++)
                    {
                        bookList = LoadBookTestData(userInput);
                        stopwatch.Reset();
                        stopwatch.Start();
                        bookList.Sort();
                        stopwatch.Stop();
                        recursiveTotalTime += stopwatch.Elapsed.TotalMilliseconds;
                    }
                    recursiveAverageTime = recursiveTotalTime / 5;
                    Console.WriteLine("\n" + "Recursive sorting algorithm average run time (ms): {0} \n", recursiveAverageTime);
                    /*foreach (Book item in bookList)
                    {
                        Console.WriteLine(item.ToString());
                    }*/
                //}
                //else
                //{
                    userInput = "exit";
                //}
            //}
            //while (userInput != "exit");

        }

        public static List<int> LoadIntegerTestData(string filePath)
        {
            string[] fileLines;
            List<int> list = new List<int>();
            fileLines = File.ReadAllLines(filePath);

            foreach (string lines in fileLines)
            {
                list.Add(int.Parse(lines));
            }

            return list;
        }

        public static List<Book> LoadBookTestData(string filePath)
        {
            string[] fileLines;
            List<Book> bookList = new List<Book>();
            fileLines = File.ReadAllLines(filePath);

            for (int i = 3; i < fileLines.Length - 1; i++)
            {
                if (Book.TryParse(fileLines[i], out Book book))
                {
                    bookList.Add(book);
                }
            }

            return bookList;
        }
    }
}

/*..
C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataIntegers\AlmostInOrder_10.txt
C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataIntegers\AlmostInOrder_100.txt
C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataIntegers\AlmostInOrder_1000.txt
C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataIntegers\AlmostInOrder_10000.txt
C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataIntegers\AlmostInOrder_100000.txt
C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataIntegers\InOrder_10.txt
C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataIntegers\InOrder_100.txt
C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataIntegers\InOrder_1000.txt
C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataIntegers\InOrder_10000.txt
C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataIntegers\InOrder_100000.txt
C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataIntegers\RandomOrder_10.txt
C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataIntegers\RandomOrder_100.txt
C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataIntegers\RandomOrder_1000.txt
C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataIntegers\RandomOrder_10000.txt
C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataIntegers\RandomOrder_100000.txt
C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataIntegers\ReverseOrder_10.txt
C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataIntegers\ReverseOrder_100.txt
C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataIntegers\ReverseOrder_1000.txt
C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataIntegers\ReverseOrder_10000.txt
C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataIntegers\ReverseOrder_100000.txt

C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataBooks\AlmostInOrder_10.table.txt
C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataBooks\AlmostInOrder_100.table.txt
C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataBooks\AlmostInOrder_1000.table.txt
C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataBooks\AlmostInOrder_10000.table.txt
C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataBooks\InOrder_10.table.txt
C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataBooks\InOrder_100.table.txt
C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataBooks\InOrder_1000.table.txt
C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataBooks\InOrder_10000.table.txt
C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataBooks\RandomOrder_10.table.txt
C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataBooks\RandomOrder_100.table.txt
C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataBooks\RandomOrder_1000.table.txt
C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataBooks\RandomOrder_10000.table.txt
C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataBooks\ReverseOrder_10.table.txt
C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataBooks\ReverseOrder_100.table.txt
C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataBooks\ReverseOrder_1000.table.txt
C:\Users\alexg\Desktop\CSCI-2210-001 - Data Structures\projects\SortingAlgorithms\TestDataBooks\ReverseOrder_10000.table.txt
..*/