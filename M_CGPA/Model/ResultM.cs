﻿namespace M_CGPA.Model
{
    class ResultM
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string SyllabusId { get; set; }
        public string Number { get; set; }
        public string OptionalSubject { get; set; }
        public string Grade { get; set; }
        public string Point { get; set; }
        public string AverageGrade { get; set; }
        public double AveragePoint { get; set; }
        public string Result { get; set; }
        public string RangeOfMarks { get; set; }
    }
}
