namespace library_management_system;

public class Library
{
    internal List<Member> Members { get; set; }
    internal List<Book> Books { get; set; }

    public Library(List<Member> members, List<Book> books)
    {
        Members = members;
        Books = books;
    }

    public Library()
    {
        
    }
}