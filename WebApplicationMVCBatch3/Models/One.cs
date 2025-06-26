using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVCBatch3.Models
{
    public class One
    {

        [Key]
        public int Id { get; set; }
        public string? OneName { get; set; }
        public Two? two { get; set; }


    }
    public class Two
    {
        [Key]
        public int Id { get; set; }
        public string? OneEmail { get; set; }

        [ForeignKey("Id")]
        public int RefID { get; set; }

    }

    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }

        // Navigation to profile (1-to-1)
        public UserProfile? Profile { get; set; }
    }

    public class UserProfile
    {
        [Key]
        public int UserId { get; set; }  // Acts as both PK and FK
        public string? Address { get; set; }

        // Navigation to user
        public User? User { get; set; }
    }

}
