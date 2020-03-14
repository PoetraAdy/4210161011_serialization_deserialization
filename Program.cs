using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Serialization_Deserialization {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("DATA AWAL");

            Comic comic = new Comic(2, 40, "Naruto", 60);
            Novel novel = new Novel(7, 30, "MengejarMimpi", 11.1);

            OutputObject(comic);
            OutputObject(novel);


            Console.WriteLine("\n Serialization ");

            byte[] comicByte = Serialize(comic);
            byte[] novelByte = Serialize(novel);

            Console.WriteLine("Comic: ");
            OutputByte(comicByte);

            Console.WriteLine("\nNovel: ");
            OutputByte(novelByte);


            Console.WriteLine("\n Deserialization");

            Book sameComic = Deserialize(comicByte);
            Book sameNovel = Deserialize(novelByte);

            OutputObject(sameComic);
            OutputObject(sameNovel);
        }

        static byte[] Serialize(Object _book) {
            BinaryFormatter bf = new BinaryFormatter();
            using (var ms = new MemoryStream()) {
                bf.Serialize(ms, _book);
                return ms.ToArray();
            }
        }

        static Book Deserialize(byte[] _byteBook) {
            using (var memStream = new MemoryStream()) {
                var binForm = new BinaryFormatter();
                memStream.Write(_byteBook, 0, _byteBook.Length);
                memStream.Seek(0, SeekOrigin.Begin);

                var obj = binForm.Deserialize(memStream);
                return (Book)obj;
            }
        }

        static void OutputObject(Book _book) {
            _book.Run();
        }

        static void OutputByte(byte[] _bookByte) {
            Console.WriteLine("new byte[] { " + string.Join(", ", _bookByte) + " }");
        }
    }
}
