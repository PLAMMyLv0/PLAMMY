//โจทย์ที่ 1: ระบบจัดการหนังสือในห้องสมุด
//สร้างคลาส Book ที่มีข้อมูลต่อไปนี้:

//Title(ชื่อหนังสือ)
//Author(ผู้เขียน)
//ISBN(รหัส ISBN)
//YearPublished(ปีที่พิมพ์)
//จากนั้นสร้างคลาส Library ที่สามารถ:

//เพิ่มหนังสือเข้าไปในห้องสมุด
//ลบหนังสือออกจากห้องสมุด
//ค้นหาหนังสือจากชื่อหนังสือหรือผู้เขียน
//แสดงรายการหนังสือทั้งหมดในห้องสมุด
using PLAMMYLibrary;
var Gen = new Library();
Gen.Create();
Console.WriteLine("Books in Library:");
Gen.Display();

// แสดงข้อมูลหนังสือทั้งหมดอีกครั้งหลังจากเพิ่ม
var newBook = new Books("HENTAI", "A85", 4751, 1998);
Gen.AddBook(newBook);
Console.WriteLine("\nAfter adding a new book:");
Gen.Display();

// แสดงข้อมูลหนังสือทั้งหมดหลังจากลบ
Gen.RemoveBook("ERROR:D{KIDDING}");
Console.WriteLine("\nAfter removing a book:");
Gen.Display();