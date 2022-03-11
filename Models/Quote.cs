namespace QuotesApp.Models
{
    public class Quote
    {
        // creating models properties
        public int Id { get; set; }
        public string QuoteAuthor { get; set; }
        public string QuoteText { get; set; }

        public Quote() //creating an empty constructor
        {

        }

    }
}
