namespace LMS.Models
{
    //User class
    public class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Role { get; set; }
    }

    // Books Class
    public class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public bool AvailabilityStatus { get; set; }
        public string CoverImageUrl { get; set; }
        public string Summary { get; set; }
    }

    //Loan/transactionid
    public class Transactions
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public string TransactionType { get; set; } // Check-out or Check-in
        public DateTime TransactionDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }

    //User Book History
    public class UserBookHistory
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }

    //Payments class for fines
    public class Payments
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
    }

    //Ratings and reviews
    public class RatingReview
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int Rating { get; set; } // Assuming 1 to 5 star rating
        public string? Review { get; set; }
        public DateTime ReviewDate { get; set; }
    }
}
