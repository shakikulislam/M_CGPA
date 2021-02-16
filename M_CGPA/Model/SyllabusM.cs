
namespace M_CGPA.Model
{
    class SyllabusM
    {
        public int Id { get; set; }
        public string Year { get; set; }
        public int ClassId { get; set; }
        public int BookId { get; set; }
        public string Class { get; set; }
        public string Book { get; set; }
    }
}
