using System.ComponentModel.DataAnnotations;

namespace API_CRUD_STUDENT.Models
{
    public class Student
    {
        [Key]
        public Guid studentId { get; set; }

        public string name { get; set; }

        public string department { get; set; }

        public string gender { get; set; }
        
        public string emailId { get; set; }

        public DateTime dob { get; set; }
    }
}
