using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PLAMMYLibrary
{
    internal class Library
    {
        List<Books> BooksList = new List<Books>();
        public Library()
        {
            BooksList = new List<Books>();
        }

        public void Create()
        {
            FakeData data = new FakeData();
            Random random = new Random();
            for (int i = 0; i < data.Names_.Count; i++)
            {
                var book = new Books(
                    data.Names_[i],
                    data.Authors_[i],
                    random.Next(4444, 8889),
                    random.Next(1980, 2025)
                );
                BooksList.Add(book);
            }
        }
        public void AddBook(Books book)
        {
            BooksList.Add(book);
        }

        public void RemoveBook(string name)
        {
            var bookToRemove = BooksList.FirstOrDefault(b => b.Name == name);
            if (bookToRemove != null)
            {
                BooksList.Remove(bookToRemove);
            }
        }

        public void Display()
        {
            Console.WriteLine($"{"ISBN"}\t{"Year"}\t{"Author"}\t{"Name"}");
            foreach (var item in BooksList)
            {
                Console.WriteLine($"{item.ISBN}\t{item.Years}\t{item.Author}\t{item.Name}");
            }
        }
        //จากนั้นสร้างคลาส Library ที่สามารถ:
        //เพิ่มหนังสือเข้าไปในห้องสมุด
        //ลบหนังสือออกจากห้องสมุด
        //ค้นหาหนังสือจากชื่อหนังสือหรือผู้เขียน
        //แสดงรายการหนังสือทั้งหมดในห้องสมุด
    }
}