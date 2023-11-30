namespace library_management_system;

public class Member
{
    internal string MembershipNumber { get; set; }
    internal string FirstName { get; set; }
    internal string LastName { get; set; }
    internal List<Book> BorrowedBookList { get; set; } = new();

    public Member(string membershipNumber ,string firstName, string lastName, List<Book> borrowedBookList)
    {
        FirstName = firstName;
        LastName = lastName;
        BorrowedBookList = borrowedBookList;
        MembershipNumber = membershipNumber;
    }
    
    public Member(){}
}