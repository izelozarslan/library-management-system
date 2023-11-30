namespace library_management_system;

public class Member
{
    internal string MembershipNumber { get; }
    internal string FirstName { get; set; }
    internal string LastName { get; set; }
    internal List<Book> BorrowedBookList { get; set; }

    public Member(string firstName, string lastName, List<Book> borrowedBookList)
    {
        FirstName = firstName;
        LastName = lastName;
        BorrowedBookList = borrowedBookList;
    }
}