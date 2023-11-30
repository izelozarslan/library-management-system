namespace library_management_system;

public class Book
{
    internal string Id { get; set; }
    internal string Name { get; set; }
    internal string Author { get; set; }
    internal string PublicationYear { get; set; }
    internal Status Status { get; set; }

    public Book(string name, string author, string publicationYear, Status status)
    {
        Name = name;
        Author = author;
        PublicationYear = publicationYear;
        Status = status;
    }
    
}