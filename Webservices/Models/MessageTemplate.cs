namespace Webservices.Models
{
    public class MessageTemplate
    {
        public int TemplateID { get; set; }
        public string TemplateName { get; set; } = default!;
        public string TemplateContent { get; set; } = default!;

    }
}
