using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_2
{
    interface IRepository
    {
        List<Books> GetAllBooks();
        void AddBook(Books book);
        Books GetBookById(int bookid);
        Books GetBookByName(string name);
        Books GetBookByAuthor(string author);
        Books GetBookByPublisher(string publisher);
        void UpdatePrice(Books book);
        void UpdateName(Books book);
        void UpdateAuthor(Books book);
        void UpdatePublisher(Books book);
    }
    class bookDet : IRepository
    {
        List<Books> list = new List<Books>();

        public void AddBook(Books book)
        {
            list.Add(book);
        }

        public List<Books> GetAllBooks()
        {
            return list;
        }

        public Books GetBookByAuthor(string author)
        {
            foreach (Books item in list)
            {
                if (item.Author == author)
                    return item;
            }
            return null;
        }

        public Books GetBookById(int bookid)
        {
            foreach (Books item in list)
            {
                if (item.bookId == bookid)
                    return item;
            }
            return null; 
        }

        public Books GetBookByName(string name)
        {
            foreach (Books item in list)
            {
                if (item.bookName == name)
                    return item;
            }
            return null;
        }

        public Books GetBookByPublisher(string publisher)
        {
            foreach (Books item in list)
            {
                if (item.Publisher == publisher)
                    return item;
            }
            return null;
        }

        public void UpdateAuthor(Books book)
        {
            foreach(Books item in list)
            {
                if(item.Author == book.Author)
                    item.Author = book.Author;
            }
        }

        public void UpdateName(Books book)
        {
            foreach (Books item in list)
            {
                if (item.bookName == book.bookName)
                    item.bookName = book.bookName;
            }
        }

        public void UpdatePrice(Books book)
        {
            foreach (Books item in list)
            {
                if (item.bookPrice == book.bookPrice)
                    item.bookPrice = book.bookPrice;
            }
        }

        public void UpdatePublisher(Books book)
        {
            foreach (Books item in list)
            {
                if (item.Publisher == book.Publisher)
                    item.Publisher = book.Publisher;
            }
        }
    }
    internal class BookDetails
    {
        static void Main()
        {
            try
            {
                bookDet obj = new bookDet();
                do
                {
                    Console.WriteLine("1.Add Book\n2.Display All Books\n3.Get Book By ID\n4.Get Book By Name\n5.Get Book By Author\n6.Get Book by Publisher\n7.Update Price\n8.Update NameofBook\n9.Update Author\n10.Update Publisher\n11.Exit");
                    int input = int.Parse(Console.ReadLine());
                    switch (input)
                    {
                        case 1:
                            {
                                Books book = new Books();
                                book.bookId =new Random().Next();
                                Console.WriteLine("Enter Book Name: ");
                                book.bookName = Console.ReadLine();
                                Console.WriteLine("Enter Book Price: ");
                                book.bookPrice = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Book Author: ");
                                book.Author = Console.ReadLine();
                                Console.WriteLine("Enter Book Publisher: ");
                                book.Publisher = Console.ReadLine();
                                obj.AddBook(book);
                            }
                            break;
                        case 2:
                            {
                                List<Books> books = obj.GetAllBooks();
                                if (books.Count > 0)
                                {
                                    foreach (Books items in books)
                                        Console.WriteLine(items);
                                }
                                else { Console.WriteLine("List is Empty.."); }
                            }
                            break;
                        case 3://by id
                            {
                                Console.WriteLine("Enter the ID: ");
                                int id = int.Parse(Console.ReadLine());
                                Books book = obj.GetBookById(id);
                                if (id == book.bookId)
                                {
                                    Console.WriteLine(book);
                                }
                                else { Console.WriteLine("Invalid ID...!"); }
                            }
                            break;
                        case 4://by bookname
                            {
                                Console.WriteLine("Enter Book Name: ");
                                string n = Console.ReadLine();
                                Books book = obj.GetBookByName(n);
                                if (n == book.bookName)
                                {
                                    Console.WriteLine(book);
                                }
                                else { Console.WriteLine("Invalid Name...!"); }
                            }
                            break;
                        case 5://by author
                            {
                                Console.WriteLine("Enter Author Name: ");
                                string a = Console.ReadLine();
                                Books book = obj.GetBookByAuthor(a);
                                if (a == book.Author)
                                {
                                    Console.WriteLine(book);
                                }
                                else { Console.WriteLine("Invalid Author Name...!"); }
                            }
                            break;
                        case 6: //publisher
                            {
                                Console.WriteLine("Enter Publisher Name: ");
                                string p = Console.ReadLine();
                                Books book = obj.GetBookByPublisher(p);
                                if (p == book.Publisher)
                                {
                                    Console.WriteLine(book);
                                }
                                else { Console.WriteLine("Invalid Publisher Name...!"); }
                            }
                            break;
                        case 7: //update price
                            {
                                Books book = new Books();
                                book.bookId = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Price: ");
                                book.bookPrice = int.Parse(Console.ReadLine());
                                obj.UpdatePrice(book);
                            }
                            break;
                        case 8: //update name
                            {
                                Books book = new Books();
                                book.bookId = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Book Name: ");
                                book.bookName = Console.ReadLine();
                                obj.UpdateName(book);
                            }
                            break;
                        case 9://update author
                            {
                                Books book = new Books();
                                book.bookId = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Author Name: ");
                                book.Author = Console.ReadLine();
                                obj.UpdateAuthor(book);
                            }
                            break;
                        case 10:
                            {
                                Books book = new Books();
                                book.bookId = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Publisher Name: ");
                                book.Publisher = Console.ReadLine();
                                obj.UpdatePublisher(book);
                            }
                            break;
                        case 11:
                            {
                                Environment.Exit(0);
                            }
                            break;

                        default:
                            {
                                Console.WriteLine("Invalid Input...!");
                            }
                            break;

                    }
                } while (true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

        }
    }
}
