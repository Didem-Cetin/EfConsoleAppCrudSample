using System.ComponentModel.DataAnnotations;

namespace EfConsoleAppCrudSample
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [StringLength(50)]
        public string CourseName { get; set; }
    }
}
