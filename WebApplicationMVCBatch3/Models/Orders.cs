using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationMVCBatch3.Models
{
    [Table("tbl_NewOrders")]
    public class Orders
    {
        [Key]
        public int OrderID { get; set; }
        public string? OrderName { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }
    }
}
