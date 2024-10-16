# Sorting Algorithms

This project is designed to be an exploration of sorting algorithms. You are to determine
the effectiveness of different sorting algorithms depending on the data being sorted. Variables
of concern are the number of elements to sort, reference type vs value type, and O(n2) vs
O(Lg(n)) algorithmic runtimes. Additionally, you must demonstrate my ability to
experiment with data, collaborate with others, and present your findings.

Part 1 – Implement At Least 2 Sorting Algorithms
1. Create an interface called ISort which uses generics to define the method header void
Sort(List<T> values)
2. Constrain types of T to derive from IComparable<T>
3. Create a new class that implements the ISort interface you created previously. This
class should use an iterative sorting algorithm to sort the list of given values.
4. Create a second class that implements the ISort interface you created previously. This
class should use a recursive sorting algorithm to sort the list of given values.

Part 2 – Create a Method to Load Integer Test Data
1. Create a LoadIntegerTestData(string filePath) method to assist you later on.
2. This method should read in a file at a given path.
a. You may accomplish this however you see fit.
3. This method should return a list of integers read from a file.

Part 3 – Testing Your Sorting Algorithms Using Integers.
1. Create a list of file names for each integer test file.
a. Be sure to include each of the test files. All types of data (Random order, reverse
order, in order, and almost in order) and all sizes of data (10, 100, 1000, and 10000)
2. For each file, print out the name of the file, then load in the data from the file using the
method that you created previously.
3. Create a new Stopwatch.
4. Run each your iterative sorting algorithm on the data at least 5 times.
5. Use the Stopwatch to record how long it takes your sorting algorithm to execute.
6. Add the Stopwatch’s Elapsed Milliseconds to an accumulator.
7. After all runs are complete, calculate the average run time for your algorithm in
milliseconds.
8. Record these times in a spreadsheet.
9. Repeat this process for your recursive sorting algorithm.
TIPS:
1. The ISort interface assumes the List given to the Sort method will be modified. So, you’ll
need to reload the data before each execution of your algorithm.
2. Make sure you aren’t recording the time it takes to load the data with your Stopwatch.
Part 4 – Adding Complex Data to Your Project
1. Create a new class called Book that implements IComparable<Book>
a. The book class should have 4 properties:
i. Last Name of Author
ii. First Name of Author
iii. Title of the Book
iv. Release Date of the Book
b. The book class should have at least 4 methods:
i. Parse(string str) which converts a string to a book
ii. TryParse(string str, out Book book) which behaves in the following ways:
1. TryParse must determine if a given string matches the correct
format for a book.
2. TryParse must return true if and only if a given string is able to be
parsed into a book
3. TryParse sets the out variable, book, to the result of a Book.Parse()
iii. ToString() which formats the book into a string representation
1. Mine ended up looking like so: $"{lastName}, {firstName}, \"{title}\",
{releaseDate.ToShortDateString()}"
2. you are welcome to use this same format, or create your own.
iv. CompareTo(Book other) which compares books in the following priority:
1. Author’s last name
2. Author’s first name
3. Book’s title
4. Book’s release date
TIPS:
1. Use a regular expression inside of the TryParse() method.
2. Int.Parse, Double.Parse, etc. are all static methods. Maybe yours should be too?
3. When comparing two books, check if two attributes are equal to one another. If not, then you
can compare them based on that attribute.
4. Read the Microsoft documentation on out variables and the ICompareTo<T> interface
Part 5 – Testing Your Sorting Algorithms Using Reference-Type Data
1. Repeat parts 2 and 3 except using the book test data and the newly created book class.
2. Procedure wise, these are the exact same, just modify or extend your code, depending
on implementation, to accommodate this change.
3. Like before, make sure to record all results in a spreadsheet for later analysis.
Part 6 – Report You Findings
1. Use the data collected in parts 3 and 5 to create a document summarizing the results
of this experiment. Be sure to include each of the following:
a. At least 2 graphs showing the run time of your algorithms under different
conditions:
i. Number of elements
ii. State of the list (Random order, reverse order, etc.)
iii. Iterative vs. recursive approach
iv. Value type data vs reference type data
b. Include how the different conditions affected the runtime of each of your
algorithms.
c. Include under which conditions your algorithms performed their best.
d. Include under which conditions your algorithms performed their worst.
e. Speculate on why your algorithms produced those results with that data.
2. Be sure to follow best practices for writing a report:
a. Pick a format and stick with it (APA, MLA, IEEE, etc.)
b. Include an introduction.
c. Include a conclusion.
d. Ensure your name is written somewhere near the top.
3. The report should be long enough to cover everything, but short enough to be readable.
