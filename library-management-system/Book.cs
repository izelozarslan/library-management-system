namespace library_management_system;

public class Book : LiteraryWork
{
    internal string Id { get; set; }
    internal Status Status { get; set; }

    public Book(string id, string name, string author, string publicationYear, Status status)
    {
        Id = id;
        Name = name;
        Author = author;
        PublicationYear = publicationYear;
        Status = status;
    }
    
    public Book(){}
    
}