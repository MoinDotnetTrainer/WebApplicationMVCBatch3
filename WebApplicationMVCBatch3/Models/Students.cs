using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVCBatch3.Models
{
    public class Students
    {
        [Key]
        public int SID { get; set; }

        public string SName { get; set; }

        public ICollection<Books> Books { get; set; }  // one to many relation  
    }
    public class Books
    {
        [Key]
        public int BID { get; set; }

        public string SName { get; set; }

        public Students Students { get; set; }  // nav
    }

}
