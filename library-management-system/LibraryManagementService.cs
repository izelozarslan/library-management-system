namespace library_management_system;

public class LibraryManagementService
{
    private Library _library = new();

    internal void Add(Book book)
    {
        _library.Books.Add(book);
        Console.WriteLine("Kitap eklendi, kitap sayısı : " + _library.Books.Count);
    }

    internal void Delete(Book book)
    {
        Console.WriteLine("Kütühanedeki kitap sayısı : " + _library.Books.Count);
        _library.Books.Remove(book);
        Console.WriteLine("Kitap silindi, kütüphanedeki kitap sayısı : " + _library.Books.Count);
    }

    internal void Lend(Book book, Member member)
    {
        if (book.Status == Status.Active)
        {
            book.Status = Status.Passive;
            _library.Books.Remove(book);
            member.BorrowedBookList.Add(book);
            Console.WriteLine("Kitap ödünç verildi. Aktiflik durumu : " + book.Status);
        }
        else
        {
            Console.WriteLine("Bu kitap şu anda başka bir üyede : " + book.Name);
        }
    }

    internal void GiveBack(Book book, Member member)
    {
        book.Status = Status.Active;
        _library.Books.Add(book);
        Console.WriteLine("Üyenin sahip olduğu kitap sayısı: " + member.BorrowedBookList.Count);
        member.BorrowedBookList.Remove(book);
        Console.WriteLine(
            $"Kitap iade edildi. Teşekkür ederiz : {book.Name} , üyenin sahip olduğu kitap sayısı : {member.BorrowedBookList.Count}");
    }

    internal void AddMemberToLibrary(Library library, Member member)
    {
        library.Members.Add(member);
        Console.WriteLine("Üye eklendi." + member.FirstName);
    }
}