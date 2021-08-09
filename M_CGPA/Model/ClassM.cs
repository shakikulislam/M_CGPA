using System.ComponentModel.DataAnnotations;

namespace M_CGPA.Model
{
    public class ClassM
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
