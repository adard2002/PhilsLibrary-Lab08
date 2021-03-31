# PhilsLibrary-Lab08

# tell them what it is (with context, provide a summary)
Your solution should include the following:

- Create a Book class to hold appropriate properties (e.g. Title, Author)

- Copy this interface into your project, then create a Library class that implements it:

 public interface ILibrary : IReadOnlyCollection<Book>
 {
     /// <summary>
     /// Add a Book to the library.
     /// </summary>
     void Add(string title, string firstName, string lastName, int numberOfPages);

     /// <summary>
     /// Remove a Book from the library with the given title.
     /// </summary>
     /// <returns>The Book, or null if not found.</returns>
     Book Borrow(string title);

     /// <summary>
     /// Return a Book to the library.
     /// </summary>
     void Return(Book book);
 }
Since books need to be borrowed by Title, use a private Dictionary<string, Book> for storage.
Copy this interface into your project, then create a generic Backpack<T> class that implements it to hold anything (like borrowed Books!):

 public interface IBag<T> : IEnumerable<T>
 {
     /// <summary>
     /// Add an item to the bag. <c>null</c> items are ignored.
     /// </summary>
     void Pack(T item);

     /// <summary>
     /// Remove the item from the bag at the given index.
     /// </summary>
     /// <returns>The item that was removed.</returns>
     T Unpack(int index);
 }
Since items need to be unpacked by index, use a private List<T> for storage.

## Unit Tests
Test that your program has the following functionality:

1. Add a Book to your Library
2. Borrowing an existing title returns the Book and remove it
Hint: Assert.DoesNotContain(book, library)
Hint: Count should decrease
3. Borrowing a missing title returns null
4. A returned book is once again in the Library
Hint: Assert.Contains(book, library)
Hint: Count should increase
5. Pack and Unpack your Backpack
Hint: Backpack can store anything so it may be easier to test with string or int instead of Book



# show them how they use it (Step by step directions, “Happy Path” walk through)



