namespace customer_ratr.Models
{

    public class Comment
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public int CustomerId { get; set; }
    }
}