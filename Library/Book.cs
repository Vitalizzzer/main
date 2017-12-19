using System.Drawing;

namespace Library
{
    public class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Date { get; set; }
        public string Info { get; set; }
        public Bitmap Pic { get; set; }
        public Book(string author, string title, string genre, string date, string info, Bitmap pic)
        {
            Author = author;
            Title = title;
            Genre = genre;
            Info = info;
            Date = date;
            Pic = pic;
        }
    }
}
