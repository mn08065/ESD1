namespace LibraryManagementSystem.Domain;

public class Author : BaseModel
{
    // DO NOT MODIFY ABOVE THIS LINE
    // TODO: 4.1 Add public Name property here with type 'string?' (nullable string)
    public string Name { get; set; } = default!;
    // TODO: 4.2 Add public Books property here with type 'ICollection<Book>' (collection of Book)
    public ICollection<Book> Books { get; set; } = new List<Book>();
    // An author may have written multiple books.
    // This will make the relationship between Book and Author many-to-many

    // DO NOT MODIFY BELOW THIS LINE

    public string BooksToString()
    {
        // DO NOT MODIFY ABOVE THIS LINE
        // This method should return a string with the names of the books of the author separated by commas
        // If the author has multiple books, the names should be separated by commas and the last name should be preceded by 'and'
        // If the author has only one book, the name should be returned as is
        // If the author has no books, an empty string should be returned
        // TODO: 4.3 Implement the BooksToString method
        if (Books.Count == 0)
        {
            return string.Empty;
        }
        else if (Books.Count == 1)
        {
            var book = Books.First();
            return book.Title;
        }
        else
        {
            var bookTitles = Books.Select(x => x.Title).ToList();
            var lastbook = bookTitles.Last();
            bookTitles.RemoveAt(bookTitles.Count - 1);
            return string.Join(", ", bookTitles) + " and " + lastbook;
        }

        throw new NotImplementedException("Author.BooksToString is not implemented");
        // DO NOT MODIFY BELOW THIS LINE
    }
}