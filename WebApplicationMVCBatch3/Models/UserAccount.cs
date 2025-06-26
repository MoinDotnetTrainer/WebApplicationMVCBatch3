using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVCBatch3.Models
{

    public class UserAccount
    {
        [Key]
        public int Id { get; set; }
        public string? UserName { get; set; }
        public AccountName? AccountName { get; set; }
    }
    public class AccountName
    {
        [Key]
        public int Id { get; set; }
        public string? AccName { get; set; }

        [ForeignKey("Id")]
        public int AccountID { get; set; }
    }

    public class C1
    {
        [Key]
        public int Id { get; set; }
        public string? AccName { get; set; }
    }

    public class P1
    {
        [Key]
        public int Id { get; set; }
        public string? UserName { get; set; }
        public AccountName? C1 { get; set; }
    }

    public class P12
    {
        [Key]
        public int Id { get; set; }
        public string? UserName { get; set; }
        public C12? C12 { get; set; }
    }
    public class C12
    {
        [Key]
        public int Id { get; set; }
        public string? AccName { get; set; }
    }
   
  




}
