namespace library_management_system;

public class LiteraryWork
{
    internal string Name { get; set; }
    internal string Author { get; set; }
    internal string PublicationYear { get; set; }

    public LiteraryWork(string name, string author, string publicationYear)
    {
        Name = name;
        Author = author;
        PublicationYear = publicationYear;
    }

    protected LiteraryWork()
    {}
}