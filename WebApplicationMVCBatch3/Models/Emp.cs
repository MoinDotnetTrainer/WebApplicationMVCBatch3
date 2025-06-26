using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVCBatch3.Models
{
    public class Emp
    {
        [Key]
        // one to one relation
        public int ID { get; set; }
        public string? EName { get; set; }
        public Location? Location { get; set; }  // naigations, Id as a pk
    }

    public class Location
    {

        [Key]  // pk and Fk for Locations , PK for EMp
        public int EmpID { get; set; }
        public string? LocAddress { get; set; }
        public Emp? Emp { get; set; }  // navigation

    }
}
