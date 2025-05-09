namespace LibraryManagement.Core.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public string UserId { get; set; } // Could be extended to User entity
        public DateTime ReservationDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool IsFulfilled { get; set; }

        // default contructor
        public Reservation() {
            Book = new Book(); // Assuming Book is a class that has been defined elsewhere
            UserId = string.Empty;
            ReservationDate = DateTime.Now;
            ExpiryDate = DateTime.Now.AddDays(7); // Default expiry date set to 7 days from now
            IsFulfilled = false;
        }

        // constructor
        public Reservation(int bookId, string userId, DateTime reservationDate, DateTime expiryDate)
        {
            Book = new Book(); // Assuming Book is a class that has been defined elsewhere
            BookId = bookId;
            UserId = userId;
            ReservationDate = reservationDate;
            ExpiryDate = expiryDate;
            IsFulfilled = false;
        }
    }
}
