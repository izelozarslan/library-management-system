namespace library_management_system;

public class LibraryManagementService
{
    // private List<Book> _bookList = new ();

    private Library _library = new();
    //Kitap ekleme, silme, ödünç verme ve iade etme 

    private string Add(Book book)
    {
        _library.Books.Add(book);
        //_bookList.Add(book);
        return "Kitap eklendi.";
    }

    private string Delete(Book book)
    {
        _library.Books.Remove(book);
        //_bookList.Remove(book);
        return "Kitap silindi";
    }

    private string Lend(Book book, Member member)
    {
        if (book.Status == Status.Active)
        {
            book.Status = Status.Passive;
            _library.Books.Remove(book);
            member.BorrowedBookList.Add(book);
            return "Kitap ödünç verildi.";
        }
        else
        {
            return "Bu kitap şu anda başka bir üyede!";
        }
    }

    private string GiveBack(Book book, Member member)
    {
        book.Status = Status.Active;
        _library.Books.Add(book);
        member.BorrowedBookList.Remove(book);
        return "Kitap iade edildi. Teşekkür ederiz!";
    }
}