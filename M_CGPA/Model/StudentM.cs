using System;

namespace M_CGPA.Model
{
    class StudentM
    {
        public int Id { get; set; }
        public int Roll { get; set; }
        public int Reg { get; set; }
        public int ClassId { get; set; }
        public string Class { get; set; }
        public string Session { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime Dob { get; set; }
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Nid { get; set; }
        public string Brn { get; set; }
        public string PresentAddress { get; set; }
        public string PermanentAddress { get; set; }
    }
}
