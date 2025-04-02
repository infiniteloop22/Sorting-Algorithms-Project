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

                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");*/

                    /*for (int i = 1; i <= 5; i++)
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

                    /*for (int i  = 0; i < bookList.Count; i++)
                    {
                        Console.WriteLine(bookList[i].ToString());
                    }*/

                    //Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                    //Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                    //Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");

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
