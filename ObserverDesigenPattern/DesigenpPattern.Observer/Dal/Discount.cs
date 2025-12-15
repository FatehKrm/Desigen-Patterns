using System.ComponentModel.DataAnnotations;

namespace DesigenpPattern.Observer.Dal
{
    public class Discount
    {
        [Key]
        public int DiscountId { get; set; }
        public string DiscountCode { get; set; }
        public int DiscountAmount { get; set; }
        public bool Status { get; set; }
    }
}
