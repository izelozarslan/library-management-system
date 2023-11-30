namespace library_management_system;

public class Library
{
    internal List<Member> Members { get; set; } = new();
    internal List<Book> Books { get; set; } = new();

    public Library(List<Member> members, List<Book> books)
    {
        Members = members;
        Books = books;
    }

    public Library()
    {
        
    }
}