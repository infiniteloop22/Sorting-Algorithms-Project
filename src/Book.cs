using System.Text.RegularExpressions;

namespace SortingAlgorithms
{
    /// <summary>
    /// Class for representing a book in a table.
    /// The class has properties for the book's last name, first name, title, and release date.
    /// </summary>
    internal class Book : IComparable<Book>
    {
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string title { get; set; }
        public DateTime releaseDate { get; set; }

        /// <summary>
        /// Parses a string into a Book object. The string should contain the fields
        /// Last Name, First Name, Title, and Release Date, separated by pipes
        /// (|). The fields should be in the order indicated by the type parameter.
        /// </summary>
        /// <returns>A Book object containing the parsed data</returns>
        public static Book Parse(string str)
        {
            string[] delimiter = str.Split('|');

            Book book = new Book
            {
                lastName = delimiter[1].Trim(),
                firstName = delimiter[2].Trim(),
                title = delimiter[3].Trim(),
                releaseDate = DateTime.Parse(delimiter[4].Trim())
            };

            return book;
        }

        /// <summary>
        /// Tries to parse a string into a Book object. If successful, assigns the parsed Book object to the out parameter.
        /// If the provided string does not match the expected pattern, it falls back to using the static Parse method.
        /// </summary>
        /// <returns>A boolean value indicating whether the string was successfully parsed.</returns>
        public static bool TryParse(string str, out Book book)
        {
            string pattern = @"\|\s*(?<LastName>[A-Za-z]+)\s*\|\s*(?<FirstName>[A-Za-z]+)\s*\|\s*(?<Title>[\w\s']+)\s*\|\s*(?<ReleaseDate>\d{4}-\d{2}-\d{2})\s*\|";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(str))
            {
                book = null;
                return false;
            }
            else
            {
                book = Parse(str);
                return true;
            }

        }

        /// <summary>
        /// Returns a formatted string containing the book's data: "{lastName}, {firstName}, \"{title}\", {releaseDate}"
        /// </summary>
        /// <returns>A formatted string</returns>
        public string ToString()
        {
            return $"{lastName}, {firstName}, \"{title}\", {releaseDate.ToShortDateString()}";
        }

        /// <summary>
        /// Compares the current Book object to another Book object.
        /// </summary>
        /// <returns>
        /// A value less than zero if the current book comes before the other book in a sorted list,
        /// a value greater than zero if the current book comes after the other book in a sorted list,
        /// or zero if the two books are equal.
        /// </returns>
        public int CompareTo(Book other)
        {
            int lastNameComparison = this.lastName.CompareTo(other.lastName);
            int firstNameComparison = this.firstName.CompareTo(other.firstName);
            int titleComparison = this.title.CompareTo(other.title);
            int releaseDateComparison = this.releaseDate.CompareTo(other.releaseDate);

            if (other == null) { return 1; }

            if (lastNameComparison != 0) { return lastNameComparison; }

            if (firstNameComparison != 0) { return firstNameComparison; }

            if (titleComparison != 0) { return titleComparison; }

            return releaseDateComparison;
        }
    }
}