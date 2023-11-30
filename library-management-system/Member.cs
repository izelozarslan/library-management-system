namespace library_management_system;

public class Member
{
    private string MembershipNumber { get; }
    private string FirstName { get; set; }
    private string LastName { get; set; }
    private List<Book> BorrowedBookList { get; set; }

    public Member(string firstName, string lastName, List<Book> borrowedBookList)
    {
        FirstName = firstName;
        LastName = lastName;
        BorrowedBookList = borrowedBookList;
    }
}