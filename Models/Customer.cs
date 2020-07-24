namespace customer_ratr.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public int Rating { get; set; }
        public bool Unhinged { get; set; }
        public int Likes { get; set; }
        public string Description { get; set; }
    }

    public class Comment : Customer
    {
        public int CommentId { get; set; }
        public int Body { get; set; }
    }

}