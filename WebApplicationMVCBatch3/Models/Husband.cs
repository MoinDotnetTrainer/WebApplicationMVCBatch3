using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationMVCBatch3.Models
{
    public class Husband
    {
        [Key]
        public int ID { get; set; }

        public string HName { get; set; }

        // navigation key

        public Wife wife { get; set; }
    }

    public class Wife
    {
        [Key]
        public int RefID { get; set; }

        public string WName { get; set; }

    }
}
