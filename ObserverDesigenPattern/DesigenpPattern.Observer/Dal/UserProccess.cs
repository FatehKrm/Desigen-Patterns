using System.ComponentModel.DataAnnotations;

namespace DesigenpPattern.Observer.Dal
{
    public class UserProccess
    {
        [Key]
        public int UserProccessId { get; set; }
        public string NameSurname { get; set; }
        public string Content { get; set; }
        public string Magazine { get; set; }
    }
}
