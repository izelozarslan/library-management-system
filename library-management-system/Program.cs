using library_management_system;

LibraryManagementService service = new LibraryManagementService();
Library _library = new Library();

Book firstBook = new Book("1", "Nutuk" , "M.Kemal Atatürk", "1927", Status.Active);
Book secondBook = new Book("2", "Kaşağı", "Ömer Seyfettin", "1919", Status.Active);

//kitabı kütüphaneye ekle
service.Add(firstBook);
service.Add(secondBook);

Member member = new Member();
member.FirstName = "Sedef";
member.LastName = "Yılmaz";
member.MembershipNumber = "001";

Member member2 = new Member();
member2.MembershipNumber = "002";
member2.FirstName = "Ahmet";
member2.LastName = "Okur";

List<Member> members = new(){member,member2};

//kütüphaneye üye ekle
service.AddMemberToLibrary(_library, member);
service.AddMemberToLibrary(_library, member2);

//kitap ödünç al
service.Lend(firstBook, member);
service.Lend(secondBook,member2);
service.Lend(firstBook,member2);

//kitap iade et
service.GiveBack(secondBook, member2);

//kitap sil
service.Delete(secondBook);

//üyeleri yazdır
service.Print(_library, members);

