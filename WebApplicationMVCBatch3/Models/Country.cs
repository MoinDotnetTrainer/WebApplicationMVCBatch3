using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVCBatch3.Models
{
    public class Country
    {
        [Key]
        public int Cid { get; set; }
        public string Cname { get; set; }

        public ICollection<States> States { get; set; }  // one to many relation
    }

    public class States
    {

        [Key]
        public int Sid { get; set; }

        public string sname { get; set; }

        public int refid { get; set; }//fk

        public Country Country { get; set; }  // navigation  , fk
    }
}
