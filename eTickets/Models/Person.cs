using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Person
    {
        [Key]
        public uint Guid { get; set; }

        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Biography { get; set; }
    }
}
