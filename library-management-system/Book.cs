namespace library_management_system;

public class Book
{
    private string Id { get; }
    private string Name { get; set; }
    private string Author { get; set; }
    private string PublicationYear { get; set; }

    public Book(string name, string author, string publicationYear)
    {
        Name = name;
        Author = author;
        PublicationYear = publicationYear;
    }
}