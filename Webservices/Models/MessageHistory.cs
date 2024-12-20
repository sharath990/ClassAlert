namespace Webservices.Models
{
    public class MessageHistory
    {
        public int MessageHistoryID { get; set; }
        public int StudentID { get; set; }
        public Student? Student { get; set; }
        public DateTime MessageDate { get; set; } = default!;
        public string MessageContent { get; set; } = default!;
        public string DeliveryStatus { get; set; } = default!;
    }
}
