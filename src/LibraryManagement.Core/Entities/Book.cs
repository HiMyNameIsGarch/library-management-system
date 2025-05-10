using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LibraryManagement.Core.Entities
{
    public class Book
    {
        // the properties from the requirements
        [Key]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("author")]
        public string Author { get; set; }

        // ISBN is a unique identifier for books
        // the question remains if it should be unique in the database
        // but also how unique can a string be ?
        public string ISBN { get; set; }

        // additional data for my sanity
        public int TotalCopies { get; set; }
        public int AvailableCopies { get; set; }
        public DateTime? PublishedDate { get; }

        // additional properties (maybe i'll need them in the future)
        // public string Genre { get; set; }
        // public string Publisher { get; set; }

        // contructor
        public Book ()
        {
            Id = 0;
            // initialize everything to empty stuff with the default contructor
            Title = string.Empty;
            Author = string.Empty;
            ISBN = string.Empty;
            TotalCopies = 0;
            AvailableCopies = 0;
            PublishedDate = null;
        }

        // constructor with parameters
        public Book (string title, string author, string isbn, DateTime? publishedDate)
        {
            Id = 0; // default value for Id ( CHANGE THIS LATER )
            Title = title;
            Author = author;
            ISBN = isbn;
            TotalCopies = 0;
            AvailableCopies = 0;
            PublishedDate = publishedDate;
        }
    }
}
