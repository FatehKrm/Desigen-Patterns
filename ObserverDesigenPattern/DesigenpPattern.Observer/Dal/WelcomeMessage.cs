using System.ComponentModel.DataAnnotations;

namespace DesigenpPattern.Observer.Dal
{
    public class WelcomeMessage
    {
        [Key]
        public int WlcomeMessageId { get; set; }
        public string NameSurname { get; set; }
        public string Content { get; set; }
    }
}
