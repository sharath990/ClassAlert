namespace Webservices.DTOs
{
    public class MessageRequest
    {
        public string RollNumber { get; set; } = default!;
        public int? TemplateID { get; set; } = default!;
        public string CustomMessage { get; set; } = default!;
        public string AbsentSubject { get; set; } = default!;
        public string AbsentTime { get; set; } = default!;
    }
}